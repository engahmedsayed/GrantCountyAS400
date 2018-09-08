using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("child-parent-parcel")]
    public class ChildParentParcelController : Controller
    {
        private readonly IChildParentParcelRepository _childParentParcelRepository;

        public ChildParentParcelController(IChildParentParcelRepository childParentParcelRepository)
        {
            _childParentParcelRepository = childParentParcelRepository;
        }

        [HttpGet]
        public IActionResult Index(ChildParentParcelFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _childParentParcelRepository.GetAll(filter.ParcelNumber, filter.EffectiveDate, filter.LegalDocumentType, out resultCount, pageNumber, AppSettings.PageSize)
                                                      .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<ParentParcel, ParentParcelViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _childParentParcelRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<ChildParentParcelDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}