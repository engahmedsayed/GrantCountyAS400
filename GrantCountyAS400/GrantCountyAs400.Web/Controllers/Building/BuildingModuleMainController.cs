using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.BuildingVM;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Building
{
    [Route("BuildingModuleMain")]
    public class BuildingModuleMainController : Controller
    {
        private readonly IBuildingModuleRepository _buildingModuleRepository;
        public BuildingModuleMainController(IBuildingModuleRepository buildingModuleRepository)
        {
            _buildingModuleRepository = buildingModuleRepository;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, BuildingMainModuleFilterViewModel filter = default(BuildingMainModuleFilterViewModel))
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _buildingModuleRepository.GetBuildingModuleMain(filter.ApplicationNumber,filter.ApplicationYear,filter.DepartmentCode,filter.JurisdictionCode,out resultCount, pageNumber, AppSettings.PageSize).ToList();
            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<BuildingModuleMain, BuildingMainModuleViewModel>(pagingInfo));
        }
    }
}