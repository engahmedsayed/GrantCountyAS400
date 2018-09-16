using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.ViewModels.Assessment.LegalDocument;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("legal-document")]
    public class LegalDocumentController : Controller
    {
        private readonly ILegalDocumentRepository _legalDocumentRepository;

        public LegalDocumentController(ILegalDocumentRepository legalDocumentRepository)
        {
            _legalDocumentRepository = legalDocumentRepository;
        }

        [HttpGet]
        public IActionResult Index(LegalDocumentFilterViewModel filter)
        {
            RealPropertyLegalDocumentViewModel viewmodel = null;
            if (filter.ParcelNumber > 0)
            {
                var legalDocument = _legalDocumentRepository.GetByParcelNumber(filter.ParcelNumber);
                viewmodel = AutoMapper.Mapper.Map<RealPropertyLegalDocumentViewModel>(legalDocument);
                ViewBag.DisplayResults = true;
            }
            else
            {
                ViewBag.DisplayResults = false;
            }

            ViewBag.EmptyResults = (viewmodel == null);
            ViewBag.FilterViewModel = filter;
            return View(viewmodel);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _legalDocumentRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<LegalDocumentDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}