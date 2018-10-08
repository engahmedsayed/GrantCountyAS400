using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.RealProperty;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("realproperty")]
    [Authorize]
    public class RealPropertyController : Controller
    {
        private readonly IRealPropertyRepository _assessmentRepository;

        public RealPropertyController(IRealPropertyRepository assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }

        [HttpGet]
        public IActionResult Index(RealPropertyFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _assessmentRepository.GetAll(filter.ParcelNumber, filter.TaxPayer, filter.Owner, filter.ContractHolder, filter.TaxCodeArea,
                                                       out resultCount, pageNumber, AppSettings.PageSize)
                                                       .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<RealProperty, RealPropertyViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _assessmentRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<RealPropertyDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}