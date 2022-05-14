using GrantCountyAs400.PersistenceAdapter.SecurityModule.Models;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels.AccountVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using X.PagedList;

namespace GrantCountyAs400.Web.Controllers.UserAdmin
{
    [Route("user-admin")]
    [Authorize(Policy = "RequireAdminRole")]
    public class UserAdminController : Controller
    {
        private int pageSize = AppSettings.PageSize;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ActionResult Index(string searchVal, int page = 1)
        {
            ViewBag.FromSearch = false;
            return Request.Headers["x-requested-with"] == "XMLHttpRequest"
                    ? GetUsers(string.Empty, page)
                    : View(GetUsersData(page, string.Empty));
        }

        public UserAdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Route("GetUsers")]
        public ActionResult GetUsers(string searchVal, int page = 1)
        {
            var query = GetUsersData(page, searchVal);
            return PartialView(query);
        }

        [Route("Create")]
        public async Task<ActionResult> Create()
        {
            //Get the list of Roles
            ViewBag.RoleId = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create(RegisterViewModel userViewModel, params string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { EmailConfirmed = true, UserName = userViewModel.UserName, Email = userViewModel.Email, PhoneNumber = userViewModel.PhoneNumber, };
                var adminresult = await _userManager.CreateAsync(user, userViewModel.Password);

                //Add User to the selected Roles
                if (adminresult.Succeeded)
                {
                    if (selectedRoles != null)
                    {
                        var result = await _userManager.AddToRolesAsync(user, selectedRoles);
                        if (!result.Succeeded)
                        {
                            ModelState.AddModelError("", result.Errors.Select(t => t.Description).First());
                            ViewBag.RoleId = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");
                            return View();
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", adminresult.Errors.Select(t => t.Description).First());
                    ViewBag.RoleId = new SelectList(_roleManager.Roles, "Name", "Name");
                    return View();
                }
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(_roleManager.Roles, "Name", "Name");
            return View();
        }

        //
        // GET: /Users/Edit/1
        /// <summary>
        /// edit user page
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>edit user page html</returns>
        [Route("Edit/{id}")]
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }

                bool lockedout = await _userManager.IsLockedOutAsync(user); // Check for lockout
                // UserManager.ResetAccessFailedCountAsync(user.Id); // Clear failed count after success
                //UserManager.AccessFailedAsync(user.Id); // Record a failure (this will lockout if enabled)
                //UserManager.SetLockoutEnabled(user.Id, enabled) // Enables or disables lockout for a user

                var userRoles = await _userManager.GetRolesAsync(user);
                var roles = await _roleManager.Roles.ToListAsync();

                return View(new EditUserViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    LockedOut = lockedout,

                    RolesList = await roles.Select(x => new SelectListItem()
                    {
                        Selected = userRoles.Contains(x.Name),
                        Text = x.Name,
                        Value = x.Name
                    }).ToListAsync()
                });
            }
            return new StatusCodeResult((int)HttpStatusCode.BadRequest);
        }

        //
        // POST: /Users/Edit/5
        /// <summary>
        /// update user information in database
        /// </summary>
        /// <param name="editUser">user information</param>
        /// <param name="selectedRole">user roles</param>
        /// <returns>if success go to users index page if there is error stay in the same page</returns>
        [HttpPost]
        [Route("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(include: "Email,Id,PhoneNumber, UserName,LockedOut,RolesList")] EditUserViewModel editUser, params string[] selectedRole)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(editUser.Id);
                if (user == null)
                {
                    return NotFound();
                }
                user.UserName = editUser.UserName;
                user.Email = editUser.Email;
                user.PhoneNumber = editUser.PhoneNumber;

                if (editUser.LockedOut)
                {
                    await _userManager.SetLockoutEnabledAsync(user, true);
                    int maxcount = 10;
                    for (int i = 0; i < maxcount; i++)
                    {
                        await _userManager.AccessFailedAsync(user); // Record a failure (this will lockout if enabled)
                    }
                }
                else
                {
                    await _userManager.SetLockoutEnabledAsync(user, false);
                    await _userManager.ResetAccessFailedCountAsync(user);
                }

                var userRoles = await _userManager.GetRolesAsync(user);

                selectedRole = editUser.RolesList.Where(ur => ur.Selected).Select(t => t.Text).ToArray() ?? new string[] { };

                var result = await _userManager.AddToRolesAsync(user, selectedRole.Except(userRoles).ToArray<string>());

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.Select(t => t.Description).First());
                    return View();
                }
                result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRole).ToArray<string>());

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.Select(t => t.Description).First());

                    return View();
                }
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "An error occured.");
            return View();
        }

        //
        // GET: /Users/Delete/5
        /// <summary>
        /// delete user page
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>delete user confirm page html</returns>
        [Route("Delete/{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //
        // POST: /Users/Delete/5
        /// <summary>
        /// delete user from database
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>if success return to users list page if there is error stay on the same page</returns>
        [HttpPost]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return BadRequest();
                }

                var user = await _userManager.FindByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                var result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.First().Description);
                    return View();
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("Details/{id}")]
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var user = await _userManager.FindByIdAsync(id);

            ViewBag.RoleNames = await _userManager.GetRolesAsync(user);

            return View(user);
        }

        [Route("reset/{id}")]
        public async Task<ActionResult> ResetPassword(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var viewmodel = new ChangePasswordByAdminViewModel { Id = user.Id, UserName = user.UserName };
            return View(viewmodel);
        }

        [Route("reset/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(string id, ChangePasswordByAdminViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, viewmodel.NewPassword);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View(viewmodel);
        }

        private IPagedList<ApplicationUser> GetUsersData(int? page, string searchVal)
        {
            int pageNumber = (page ?? 1);
            var query = _userManager.Users.Where(u => 1 == 1);
            if (!string.IsNullOrWhiteSpace(searchVal))
            {
                query = query.Where(u => u.UserName.Contains(searchVal));
            }
            foreach (var item in query)
            {
                item.Roles = (_userManager.GetRolesAsync(item)).Result.ToList();
            }

            return query.OrderByDescending(u => u.UserName).ToPagedList(pageNumber, pageSize);
        }
    }
}