using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.TreasurerVM.ExciseTaxRate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Treasurer
{
    [Route("excise-taxrates")]
    public class ExciseTaxRateController : Controller
    {
        private readonly IExciseTaxRateRepository _exciseTaxRateRepository;

        public ExciseTaxRateController(IExciseTaxRateRepository exciseTaxRateRepository)
        {
            _exciseTaxRateRepository = exciseTaxRateRepository;
        }

        [HttpGet]
        public IActionResult Index(ExciseTaxRateFilterViewModel filter, int pageNumber = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _exciseTaxRateRepository.GetAll(filter.Description, filter.RecordType, out int resultCount, pageNumber, AppSettings.PageSize).ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            ViewBag.TaxRateDescriptions = _exciseTaxRateRepository.GetAllDescriptions().Select(taxrateDescription => new SelectListItem()
            {
                Value = taxrateDescription,
                Text = taxrateDescription
            });
            ViewBag.RecordTypes = new[] {
                new SelectListItem() { Value = "L", Text = "Local" },
                new SelectListItem() { Value = "S", Text = "State" }
            };

            return View(results.ToMappedPagedList<ExciseTaxRate, ExciseTaxRateViewModel>(pagingInfo));
        }
    }
}