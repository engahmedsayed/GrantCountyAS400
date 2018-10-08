using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("legal-description")]
    [Authorize]
    public class LegalDescriptionController : Controller
    {
        private readonly ILegalDescriptionRepository _legalDescriptionRepository;

        public LegalDescriptionController(ILegalDescriptionRepository legalDescriptionRepository)
        {
            _legalDescriptionRepository = legalDescriptionRepository;
        }

        [HttpGet]
        public IActionResult Index(LegalDescriptionFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _legalDescriptionRepository.GetAll(filter.ParcelNumber, filter.TaxPayer, filter.Owner, filter.ContractHolder,
                                                             out resultCount, pageNumber, AppSettings.PageSize
                                                    ).ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<RealPropertyWithLegalDescriptions, RealPropertyWithLegalDescriptionsViewModel>(pagingInfo));
        }
    }
}