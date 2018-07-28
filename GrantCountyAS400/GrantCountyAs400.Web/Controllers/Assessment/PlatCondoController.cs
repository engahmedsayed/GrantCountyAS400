using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.PlatCondo;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("plat-condo")]
    public class PlatCondoController : Controller
    {
        private readonly IPlatCondoRepository _platCondoRepository;

        public PlatCondoController(IPlatCondoRepository platCondoRepository)
        {
            _platCondoRepository = platCondoRepository;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _platCondoRepository.GetAll(out resultCount, pageNumber, AppSettings.PageSize)
                                              .ToList();

            pagingInfo.Total = resultCount;
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