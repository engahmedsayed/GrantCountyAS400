using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("legal-description")]
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

            var results = _legalDescriptionRepository.GetAll(filter.ParcelNumber, out resultCount, pageNumber, AppSettings.PageSize)
                                                         .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<LegalDescription, LegalDescriptionViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _legalDescriptionRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<LegalDescriptionDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}