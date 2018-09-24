using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.BuildingVM;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Building
{
    [Route("building-permit-system")]
    public class BuildingPermitSystemController : Controller
    {
        private readonly IBuildingPermitSystemRepository _buildingModuleRepository;

        public BuildingPermitSystemController(IBuildingPermitSystemRepository buildingModuleRepository)
        {
            _buildingModuleRepository = buildingModuleRepository;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, BuildingPermitSystemFilterViewModel filter = default(BuildingPermitSystemFilterViewModel))
        {
            int resultCount;
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _buildingModuleRepository.GetAll(filter.ApplicationNumber, filter.ApplicationYear, filter.DepartmentCode, filter.JurisdictionCode, out resultCount, pageNumber, AppSettings.PageSize).ToList();
            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<BuildingPermitSystem, BuildingPermitSystemViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var entity = _buildingModuleRepository.Details(id);
            if (entity == null)
                return NotFound();

            var viewmodel = AutoMapper.Mapper.Map<BuildingPermitSystemDetailsViewModel>(entity);

            // load permit details data.
            (ViewBag.PermitDetailViewName, ViewBag.PermitDetailViewModel) = GetPermitDetail(id, entity.PermitCode);
            return View(viewmodel);
        }

        private (string viewName, dynamic permitDetail) GetPermitDetail(int id, string permitCode)
        {
            dynamic permitDetailViewModel = null;
            string permitDetailViewName = string.Empty;
            switch (permitCode)
            {
                case "DEMO":
                    var permitDetailEntity = _buildingModuleRepository.GetDemolitionPermitByBuildingPermitSystemId(id);
                    permitDetailViewModel = AutoMapper.Mapper.Map<DemolitionPermitViewModel>(permitDetailEntity);
                    permitDetailViewName = "_DemolitionPermit";
                    break;
                case "GRAD":
                case "MECH":
                    var mechanicalPermitDetailEntity = _buildingModuleRepository.GetMechanicalPermitDetailByBuildingPermitSystemId(id);
                    permitDetailViewModel = AutoMapper.Mapper.Map<MechanicalPermitDetailViewModel>(mechanicalPermitDetailEntity);
                    permitDetailViewName = "_MechanicalPermitDetail";
                    break;
                case "FIREM":
                    var otherPermitDetailEntity = _buildingModuleRepository.GetOtherPermitDetailByBuildingPermitSystemId(id);
                    permitDetailViewModel = AutoMapper.Mapper.Map<OtherPermitDetailViewModel>(otherPermitDetailEntity);
                    permitDetailViewName = "_OtherPermitDetail";
                    break;
                case "MANH":
                case "PLMB":
                case "STRUT":
                    var structurePermitDetailEntity = _buildingModuleRepository.GetStructurePermitDetailByBuildingPermitSystemId(id);
                    permitDetailViewModel = AutoMapper.Mapper.Map<StructurePermitDetailViewModel>(structurePermitDetailEntity);
                    permitDetailViewName = "_StructurePermitDetail";
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException(
                        nameof(permitCode),
                        permitCode,
                        $"Couldn't find PermitCode: {permitCode} for Building Permit System with ID:{id}");
            }
            return (permitDetailViewName, permitDetailViewModel);
        }
    }
}