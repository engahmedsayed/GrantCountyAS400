using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits;
using Microsoft.AspNetCore.Mvc;

namespace GrantCountyAs400.Web.Controllers.Assessment
{
    [Route("building-permits")]
    public class BuildingPermitsController : Controller
    {
        private readonly IBuildingPermitsRepository _buildingPermitsRepository;
        public BuildingPermitsController(IBuildingPermitsRepository buildingPermitsRepository)
        {
            _buildingPermitsRepository = buildingPermitsRepository;
        }
        public IActionResult Index(int pageNumber = 1)
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };
            var results = _buildingPermitsRepository.GetBuldingPermitsMain(out resultCount, pageNumber).ToList();
            if (results != null)
            {
                pagingInfo.Total = resultCount;
                return View(results.ToMappedPagedList<BuildingPermitsMain, BuildingPermitsMainViewModel>(pagingInfo));
            }
            return View();
        }
    }
}