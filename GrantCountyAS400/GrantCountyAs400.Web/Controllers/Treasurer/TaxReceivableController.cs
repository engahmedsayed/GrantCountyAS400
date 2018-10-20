using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Treasurer
{
    [Route("tax-receivable")]
    public class TaxReceivableController : Controller
    {
        private readonly ITreasurerMasterRepository _treasurerMasterRepository;

        public TaxReceivableController(ITreasurerMasterRepository treasurerMasterRepository)
        {
            _treasurerMasterRepository = treasurerMasterRepository;
        }

        [HttpGet]
        public IActionResult Index(TaxReceivableFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _treasurerMasterRepository.GetAll(filter.ParcelNumber, out int resultCount, pageNumber, AppSettings.PageSize).ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<TreasurerMaster, TreasurerMasterViewModel>(pagingInfo));
        }
    }
}