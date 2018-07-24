using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.HomePark;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("home-parks")]
    public class ManufacturedHomeParkController : Controller
    {
        private readonly IManufacturedHomeParkRepository _manufacturedHomeParkRepository;

        public ManufacturedHomeParkController(IManufacturedHomeParkRepository manufacturedHomeParkRepository)
        {
            _manufacturedHomeParkRepository = manufacturedHomeParkRepository;
        }

        [HttpGet]
        public IActionResult Index(ManufacturedHomeParkFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _manufacturedHomeParkRepository.GetAll(filter.MhparkCode, filter.Name, filter.ContactName,
                                                                 out resultCount, pageNumber, AppSettings.PageSize)
                                                         .ToList();

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<ManufacturedHomePark, ManufacturedHomeParkViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _manufacturedHomeParkRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<ManufacturedHomeParkDetailsViewModel>(entity);
            return View(viewmodel);
        }
    }
}