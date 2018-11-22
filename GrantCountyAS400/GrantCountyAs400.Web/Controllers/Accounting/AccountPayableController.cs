using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.AccountingVM.VenderWarrent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("account-payable")]
    [Authorize(Policy = "RequireEitherAccountantOrAdminRole")]
    public class AccountPayableController : Controller
    {
        private readonly IAccountPayableRepository _accountPayableRepository;

        public AccountPayableController(IAccountPayableRepository accountPayableRepository)
        {
            _accountPayableRepository = accountPayableRepository;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, VenderWarrentFilterViewModel filter = default(VenderWarrentFilterViewModel))
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results =
                _accountPayableRepository
                    .GetAll(filter.VendorId, filter.Name, filter.Representative, filter.MinPayDate, filter.MaxPayDate, out int resultCount, pageNumber,
                            AppSettings.PageSize)
                    .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<VenderWarrent, VenderWarrentViewModel>(pagingInfo));
        }
    }
}