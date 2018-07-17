using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.GeneralLedgerVM;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Accounting
{
    [Route("GeneralLedger")]
    public class GeneralLedgerController : Controller
    {
        private readonly IGeneralLedgerRepository _generalLedgerRepository;

        public GeneralLedgerController(IGeneralLedgerRepository generalLedgerRepository)
        {
            _generalLedgerRepository = generalLedgerRepository;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, GeneralLedgerFilterVM filter = default(GeneralLedgerFilterVM))
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            if (filter.FiscalYear < 1900)
            {
                filter.FiscalYear = 2008;
            }
            var results = _generalLedgerRepository
                                .GetAll(out resultCount, pageNumber, AppSettings.PageSize, filter.FiscalYear,filter.Fund,filter.Department,filter.Program)
                                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<GeneralLedger, GeneralLedgerViewModel>(pagingInfo));
        }
    }
}