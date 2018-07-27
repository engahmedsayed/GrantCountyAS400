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
                                .GetAll(filter.FiscalYear, filter.Fund, filter.Department, 
                                        filter.Program, filter.Project, filter.Base,
                                        out resultCount, pageNumber, AppSettings.PageSize)
                                .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<GeneralLedger, GeneralLedgerViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{fund}/{department}/{program}/{project}/{baseId}/{fiscalYear}/{pageNumber}")]
        public IActionResult Details(string fund,string department,string program,string project,string baseId,int fiscalYear,int pageNumber=1)
        {
            ViewBag.baseId = baseId;
            var results = new List<GeneralLedgerDetailsViewModel>();
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            
            var queryResults = _generalLedgerRepository
                                .GetAllDetails(fund, department,program,project,baseId,fiscalYear,
                                out resultCount, pageNumber, AppSettings.PageSize);

            pagingInfo.Total = resultCount;
            return View(queryResults.GeneralLedgers.ToMappedPagedList<GeneralLedgerDetailItem, GeneralLedgerDetailsViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("MonthDetails/{month}/{fiscalYear}/{fund}/{department}/{program}/{project}/{baseId}/{pageNumber}")]
        public IActionResult MonthDetails(int month, int fiscalYear, string fund, string department, string program, string project,string baseId,int pageNumber=1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _generalLedgerRepository.GetMonthDetails(month, fiscalYear, fund, department, program, project,baseId, out resultCount);
            return View(results.ToMappedPagedList<GeneralLedgerMonthDetail, GeneralLedgerMonthDetailsViewModel>(pagingInfo));
        }
    }
}