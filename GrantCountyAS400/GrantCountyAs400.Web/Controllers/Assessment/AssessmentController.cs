using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.AssessmentModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AssessmentModel = GrantCountyAs400.Domain.Assessment.Assessment;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("assessment")]
    public class AssessmentController : Controller
    {
        private readonly IAssessmentRepository _assessmentRepository;

        public AssessmentController(IAssessmentRepository assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }

        [HttpGet]
        public IActionResult Index(AssessmentFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _assessmentRepository.GetAll(filter.ParcelNumber, filter.TaxPayer, filter.Owner, filter.ContractHolder, filter.TaxCodeArea,
                                                       filter.TaxCodeDesc, out resultCount, pageNumber, AppSettings.PageSize)
                                                       .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<AssessmentModel, AssessmentViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _assessmentRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<AssessmentDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}