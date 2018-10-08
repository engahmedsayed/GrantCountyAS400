using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.AccountVM
{
    /// <summary>
    /// edit user page view model
    /// </summary>
    public class EditUserViewModel
    {
        /// <summary>
        /// user id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// user email
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// user name
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        /// <summary>
        /// user phone number
        /// </summary>
        [Display(Name = "Mobile number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// is this user lockedout
        /// </summary>
        [Display(Name = "Is locked out?")]
        public bool LockedOut { get; set; }

        /// <summary>
        /// roles that user part of
        /// </summary>
        public List<SelectListItem> RolesList { get; set; }
    }
}
