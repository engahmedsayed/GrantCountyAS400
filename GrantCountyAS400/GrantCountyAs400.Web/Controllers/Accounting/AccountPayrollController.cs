using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Domain.ExportingService;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.AccountingVM.AccountPayroll;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("account-payroll")]
    [Authorize(Policy = "RequireEitherAccountantOrAdminRole")]
    public class AccountPayrollController : Controller
    {
        private readonly IAccountPayrollRepository _accountPayrollRepository;
        private readonly IExportingService _exportingService;

        public AccountPayrollController(IAccountPayrollRepository accountPayrollRepository, IExportingService exportingService)
        {
            _accountPayrollRepository = accountPayrollRepository;
            _exportingService = exportingService;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, AccountPayrollFilterViewModel filter = default(AccountPayrollFilterViewModel))
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results =
                _accountPayrollRepository
                    .GetAll(filter.FirstName, filter.LastName, filter.SSN, filter.MinDate, filter.MaxDate, filter.EmployeeNumber, out int resultCount, pageNumber,
                            AppSettings.PageSize)
                    .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<AccountPayroll, AccountPayrollViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("export/pdf", Name = "ExportAccountPayrollAsPdf")]
        public ActionResult ExportAccountPayrollAsPdf(AccountPayrollFilterViewModel filter)
        {
            //In order to get all data that match the given filter.
            var pagingInfo = new PagingInfo() { PageNumber = -1 };

            var entities = _accountPayrollRepository
                    .GetAll(filter.FirstName, filter.LastName, filter.SSN, filter.MinDate, filter.MaxDate, filter.EmployeeNumber, out int resultCount, pagingInfo.PageNumber,
                            AppSettings.PageSize)
                    .ToList();
            return new Rotativa.AspNetCore.ViewAsPdf(entities.ToMappedPagedList<AccountPayroll, AccountPayrollViewModel>(pagingInfo)) { FileName = $"AccountPayroll.pdf" };
        }
    }
}