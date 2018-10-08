using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.PlatCondo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("plat-condo")]
    [Authorize]
    public class PlatCondoController : Controller
    {
        private readonly IPlatCondoRepository _platCondoRepository;

        public PlatCondoController(IPlatCondoRepository platCondoRepository)
        {
            _platCondoRepository = platCondoRepository;
        }

        [HttpGet]
        public IActionResult Index(PlatCondoFilterViewModel filter, int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _platCondoRepository.GetAll(filter.CodeType, filter.Code, filter.Name, out resultCount, pageNumber, AppSettings.PageSize)
                                              .ToList();

            ViewBag.PlatCodeTypes = _platCondoRepository.GetAllPlatCodeTypes().Select(codeType => new SelectListItem()
            {
                Value = codeType,
                Text = codeType
            });

            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<PlatCondo, PlatCondoViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var entity = _platCondoRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<PlatCondoViewModel>(entity);
            return View(viewmodel);
        }
    }
}