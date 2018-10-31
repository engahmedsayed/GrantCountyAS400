using AutoMapper;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.BuildingVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Building
{
    [Route("building-permit-system")]
    //[Authorize(Policy = "RequireAdminRole")]
    [Authorize]
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
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results = _buildingModuleRepository.GetAll(
                filter.ApplicationNumber,
                filter.ApplicationYear,
                filter.PermitNumber,
                filter.ApplicantBusinessName,
                filter.ApplicantLastName,
                filter.ApplicantFirstName,
                filter.PreliminaryParcelNumber,
                filter.AssessorParcelNumber,
                filter.JurisdictionCode,
                out int resultCount,
                pageNumber,
                AppSettings.PageSize).ToList();
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

            var viewmodel = Mapper.Map<BuildingPermitSystemDetailsViewModel>(entity);

            // load permit details data.
            (ViewBag.PermitDetailViewName, ViewBag.PermitDetailViewModel) = GetPermitDetail(id, entity.PermitCode);
            ViewBag.ValuationAndFeesViewModel = GetValuationAndFees(id, viewmodel.BasicInfo.ApplicationYear, viewmodel.BasicInfo.ApplicationNumber);

            // load inspections & Conditions & receipts data.
            ViewBag.Inspections = GetInspections(id);
            ViewBag.Conditions = GetConditions(id);
            ViewBag.Receipts = GetReceiptsReport(id);
            TempData["BasicInfo"] = Newtonsoft.Json.JsonConvert.SerializeObject(viewmodel.BasicInfo);
            TempData.Keep("BasicInfo");
            return View(viewmodel);
        }

        [HttpGet]
        [Route("/building-permit-system/grading-details/{id}",Name ="gradingDetailsRoute")]
        public IActionResult GradingFeesDetails(int id)
        {
            GradingFeesDetailsViewModel result = new GradingFeesDetailsViewModel();
            string tempDataObj = TempData.Peek("BasicInfo") as string;
            result.BasicInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<BuildingPermitSystemBasicInfoViewModel>(tempDataObj);
            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            result.CubicYardsOfFill = gradingExcavationPermitDetailEntity?.CubicYardsOfFill;
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber,"grad");
            result.GradExtendedAmount = valuationAndFeesEntity?.AssignGradingFees;
            result.PlrvwExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.FeeDescription;
            result.BaseFee = valuationAndFeesEntity.BaseFee;
            result.FeeIncrement = valuationAndFeesEntity.FeeIncrement;
            result.MinMaxFlag = valuationAndFeesEntity.MinMaxFlag;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/statebuilding-fee-details/{id}", Name = "stateBuildingfeeDetailsRoute")]
        public IActionResult StateBuildingFeeDetails(int id)
        {
            StateBuildingFeesDetailsViewModel result = new StateBuildingFeesDetailsViewModel();
            string tempDataObj = TempData.Peek("BasicInfo") as string;
            result.BasicInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<BuildingPermitSystemBasicInfoViewModel>(tempDataObj);
            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "stbcd");
            result.StateBuildingExtendedAmount = valuationAndFeesEntity?.AssignBidBuildingCodeFee;
            result.NumberOfUnits = valuationAndFeesEntity?.NumberOfUnits;
            result.ExtendedAmount = valuationAndFeesEntity?.AssignBidBuildingCodeFee;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/other-fees-details/{id}", Name = "otherFeesDetailsRoute")]
        public IActionResult OtherFeesDetails(int id)
        {
            OtherFeesDetailsViewModel result = new OtherFeesDetailsViewModel();
            string tempDataObj = TempData.Peek("BasicInfo") as string;
            result.BasicInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<BuildingPermitSystemBasicInfoViewModel>(tempDataObj);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "othrb");
            result.OtherExtendedAmount = valuationAndFeesEntity?.AssignOtherFees;
            result.ExtendedAmount = valuationAndFeesEntity?.AssignOtherFees;
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.NumberOfUnits = valuationAndFeesEntity.NumberOfUnits;
            result.UnitCharge = valuationAndFeesEntity.UnitCharge;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/man-mod-fees-details/{id}", Name = "manModFeesDetailsRoute")]
        public IActionResult ManModFeesDetails(int id)
        {
            ManModFeesDetailsViewModel result = new ManModFeesDetailsViewModel();
            string tempDataObj = TempData.Peek("BasicInfo") as string;
            result.BasicInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<BuildingPermitSystemBasicInfoViewModel>(tempDataObj);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "bldg");
            result.ExtendedAmount = valuationAndFeesEntity?.AssignStructNanNodFees;
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.NumberOfUnits = valuationAndFeesEntity.NumberOfUnits;
            result.BaseFee = valuationAndFeesEntity?.BaseFee;
            result.TotalValue = valuationAndFeesEntity?.ExtendedValue;
            result.FeeIncrement = valuationAndFeesEntity?.FeeIncrement;
            result.MinMaxFlag = valuationAndFeesEntity?.MinMaxFlag;
            result.TotalBuildingFees = valuationAndFeesEntity?.BaseFee;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/plan-review-fee-details/{id}", Name = "planReviewFeeDetailsRoute")]
        public IActionResult PlanReviewFeeDetails(int id)
        {
            PlanReviewFeeDetailsViewModel result = new PlanReviewFeeDetailsViewModel();
            string tempDataObj = TempData.Peek("BasicInfo") as string;
            result.BasicInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<BuildingPermitSystemBasicInfoViewModel>(tempDataObj);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "plrvw");
            result.ExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.PlanReviewFee = valuationAndFeesEntity?.BaseFee;
            result.TotalValue = valuationAndFeesEntity?.ExtendedValue;
            result.TotalPlanReviewFees = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.BuildingPermit = valuationAndFeesEntity?.AssignStructNanNodFees;
                
            return View(result);
        }

        private (string viewName, dynamic permitDetail) GetPermitDetail(int id, string permitCode)
        {
            dynamic permitDetailViewModel = null;
            string permitDetailViewName = string.Empty;
            switch (permitCode)
            {
                case "DEMO":
                    var permitDetailEntity = _buildingModuleRepository.GetDemolitionPermitByBuildingPermitSystemId(id);
                    permitDetailViewModel = Mapper.Map<DemolitionPermitViewModel>(permitDetailEntity);
                    permitDetailViewName = "_DemolitionPermit";
                    break;

                case "GRAD":
                    var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
                    permitDetailViewModel = Mapper.Map<GradingExcavationPermitDetailViewModel>(gradingExcavationPermitDetailEntity);
                    permitDetailViewName = "_GradingExcavationPermitDetail";
                    break;

                case "MECH":
                    var mechanicalPermitDetailEntity = _buildingModuleRepository.GetMechanicalPermitDetailByBuildingPermitSystemId(id);
                    permitDetailViewModel = Mapper.Map<MechanicalPermitDetailViewModel>(mechanicalPermitDetailEntity);
                    permitDetailViewName = "_MechanicalPermitDetail";
                    break;

                case "FIREM":
                    var otherPermitDetailEntity = _buildingModuleRepository.GetOtherPermitDetailByBuildingPermitSystemId(id);
                    permitDetailViewModel = Mapper.Map<OtherPermitDetailViewModel>(otherPermitDetailEntity);
                    permitDetailViewName = "_OtherPermitDetail";
                    break;

                case "MANH":
                    var manufactureModularPermitEntity = _buildingModuleRepository.GetManufactureModularPermitByBuildingPermitSystemId(id);
                    permitDetailViewModel = Mapper.Map<ManufactureModularPermitViewModel>(manufactureModularPermitEntity);
                    permitDetailViewName = "_ManufactureModularPermit";
                    break;

                case "PLMB":
                    var plumbingPermitEntity = _buildingModuleRepository.GetPlumbingPermitByBuildingPermitSystemId(id);
                    permitDetailViewModel = Mapper.Map<PlumbingPermitViewModel>(plumbingPermitEntity);
                    permitDetailViewName = "_PlumbingPermit";
                    break;

                case "STRUT":
                    var structurePermitDetailEntity = _buildingModuleRepository.GetStructurePermitDetailByBuildingPermitSystemId(id);
                    permitDetailViewModel = Mapper.Map<StructurePermitDetailViewModel>(structurePermitDetailEntity);
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

        private ValuationAndFeesViewModel GetValuationAndFees(int id, decimal? applicationYear, decimal? applicationNumber,string feeCode=null)
        {
            var result = _buildingModuleRepository.GetValuationAndFees(id, applicationYear, applicationNumber,feeCode);
            var resultMapped = Mapper.Map<ValuationAndFeesViewModel>(result);
            resultMapped.Id = id;
            return resultMapped;
        }

        private List<BuildingInspectionViewModel> GetInspections(int id)
        {
            var inspections = _buildingModuleRepository.GetInspectionsByBuildingPermitSystemId(id);
            return Mapper.Map<IEnumerable<BuildingInspection>, IEnumerable<BuildingInspectionViewModel>>(inspections).ToList();
        }

        private List<BuildingConditionViewModel> GetConditions(int id)
        {
            var conditions = _buildingModuleRepository.GetConditionsByBuildingPermitSystemId(id);
            return Mapper.Map<IEnumerable<BuildingCondition>, IEnumerable<BuildingConditionViewModel>>(conditions).ToList();
        }

        private BuildingReceiptsReportViewModel GetReceiptsReport(int id)
        {
            var result = new BuildingReceiptsReportViewModel();

            var (receipts, fees) = _buildingModuleRepository.GetReceiptHeadersAndFeesByBuildingPermitSystemId(id);
            result.ReceiptHeaders = Mapper.Map<IEnumerable<ReceiptHeader>, IEnumerable<ReceiptHeaderViewModel>>(receipts).ToList();
            result.Fees = Mapper.Map<IEnumerable<BuildingApplicationFee>, IEnumerable<BuildingApplicationFeeViewModel>>(fees).ToList();

            return result;
        }
    }
}