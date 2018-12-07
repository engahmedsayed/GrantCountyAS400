using AutoMapper;
using GrantCountyAs400.Domain;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Domain.ExportingService;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.AccountingVM.VenderWarrent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("account-payable")]
    [Authorize(Policy = "RequireEitherAccountantOrAdminRole")]
    public class AccountPayableController : Controller
    {
        private readonly IAccountPayableRepository _accountPayableRepository;
        private readonly IExportingService _exportingService;

        public AccountPayableController(IAccountPayableRepository accountPayableRepository, IExportingService exportingService)
        {
            _accountPayableRepository = accountPayableRepository;
            _exportingService = exportingService;

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

        
        [HttpGet]
        [Route("export/excel", Name = "ExportAccountPayableAsExcel")]
        public FileResult ExportAccountPayableAsExcel(VenderWarrentFilterViewModel filter)
        {
            //In order to get all data that match the given filter.
            var pagingInfo = new PagingInfo() { PageNumber = -1 };

            MemoryStream stream = _exportingService.GetAccountsPayable(filter.VendorId, filter.Name, filter.Representative, filter.MinPayDate, filter.MaxPayDate, out int resultCount, pagingInfo.PageNumber,
                            AppSettings.PageSize);
            return File(stream, Constants.ExcelFilesMimeType,
            Constants.BuildingPermitTemplateExcelFileName);

        }

        [HttpGet]
        [Route("export/pdf", Name = "ExportAccountPayableAsPdf")]
        public ActionResult ExportAccountPayableAsPdf(VenderWarrentFilterViewModel filter)
        {
            //In order to get all data that match the given filter.
            var pagingInfo = new PagingInfo() { PageNumber = -1 };

            var entities = _accountPayableRepository
                    .GetAll(filter.VendorId, filter.Name, filter.Representative, filter.MinPayDate, filter.MaxPayDate, out int resultCount, pagingInfo.PageNumber,
                            AppSettings.PageSize)
                    .ToList();
            return new Rotativa.AspNetCore.ViewAsPdf(entities.ToMappedPagedList<VenderWarrent, VenderWarrentViewModel>(pagingInfo)) { FileName = $"AccountPayabler.pdf" };
        }
    }
}