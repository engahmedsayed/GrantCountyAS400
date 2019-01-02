using AutoMapper;
using GrantCountyAs400.Domain;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Domain.ExportingService;
using GrantCountyAs400.Web.Extensions;
using GrantCountyAs400.Web.ViewModels;
using GrantCountyAs400.Web.ViewModels.BuildingVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GrantCountyAs400.Web.Controllers.Building
{
    [Route("building-permit-system")]
    //[Authorize(Policy = "RequireAdminRole")]
    [Authorize]
    public class BuildingPermitSystemController : Controller
    {
        private readonly IBuildingPermitSystemRepository _buildingModuleRepository;
        private readonly IExportingService _exportingService;

        public BuildingPermitSystemController(IBuildingPermitSystemRepository buildingModuleRepository,IExportingService exportingService)
        {
            _buildingModuleRepository = buildingModuleRepository;
            _exportingService = exportingService;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, BuildingPermitSystemFilterViewModel filter = default(BuildingPermitSystemFilterViewModel))
        {
            var pagingInfo = new PagingInfo() { PageNumber = pageNumber };

            var results =
                _buildingModuleRepository.GetAll(
                    Mapper.Map<BuildingSearchCriteria>(filter),
                    out int resultCount,
                    pageNumber,
                    AppSettings.PageSize)
                .ToList();
            pagingInfo.Total = resultCount;
            ViewBag.FilterViewModel = filter;
            return View(results.ToMappedPagedList<BuildingPermitSystem, BuildingPermitSystemViewModel>(pagingInfo));
        }

        [HttpGet]
        [Route("export/excel", Name = "ExportBuildingPermitSystemAsExcel")]
        public FileResult ExportBuildingPermitSystemAsExcel(BuildingPermitSystemFilterViewModel filter)
        {
            //In order to get all data that match the given filter.
            var pagingInfo = new PagingInfo() { PageNumber = -1 };

            MemoryStream stream = _exportingService.GetBuildingPermitSystem(Mapper.Map<BuildingSearchCriteria>(filter));
            return File(stream, Constants.ExcelFilesMimeType,
            Constants.BuildingPermitTemplateExcelFileName);

        }

        [HttpGet]
        [Route("export/pdf",Name = "ExportBuildingPermitSystemAsPdf")]
        public ActionResult ExportBuildingPermitSystemAsPdf(BuildingPermitSystemFilterViewModel filter)
        {
            //In order to get all data that match the given filter.
            var pagingInfo = new PagingInfo() { PageNumber = -1 };

            var entities = _buildingModuleRepository.GetAll(
                Mapper.Map<BuildingSearchCriteria>(filter),
                out int resultCount,
                pagingInfo.PageNumber,
                AppSettings.PageSize).ToList();
            return new Rotativa.AspNetCore.ViewAsPdf(entities.ToMappedPagedList<BuildingPermitSystem, BuildingPermitSystemViewModel>(pagingInfo)) { FileName = $"BuildingPermitSystem.pdf" };
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
            return View(viewmodel);
        }

        [HttpGet]
        [Route("/building-permit-system/grading-details/{id}",Name ="gradingDetailsRoute")]
        public IActionResult GradingFeesDetails(int id)
        {
            GradingFeesDetailsViewModel result = new GradingFeesDetailsViewModel();
           
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));
            
            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            result.CubicYardsOfFill =new List<decimal?> { gradingExcavationPermitDetailEntity?.CubicYardsOfFill };
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber,"grad");
            result.GradExtendedAmount = valuationAndFeesEntity?.AssignGradingFees;
            result.PlrvwExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.BaseFee = valuationAndFeesEntity.BaseFee;
            result.FeeIncrement = valuationAndFeesEntity.FeeIncrement;
            result.ExtendedAmount = valuationAndFeesEntity.ExtendedAmount;
            result.MinMaxFlag = valuationAndFeesEntity.MinMaxFlag;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/plumbing-details/{id}", Name = "plumbingDetailsRoute")]
        public IActionResult PlumbingFeesDetails(int id)
        {
            PlumbingFeesDetailsViewModel result = new PlumbingFeesDetailsViewModel();

            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));

            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "plmb");
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.UnitCharge = valuationAndFeesEntity?.UnitCharge;
            result.ExtendedAmount = valuationAndFeesEntity?.ExtendedAmount;
            result.NumberOfUnits = valuationAndFeesEntity?.NumberOfUnits;
            result.PlrvwExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.PlumbingExtendedAmount = valuationAndFeesEntity?.AssignPlumbingFees;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/mechanical-details/{id}", Name = "mechanicalFeesDetailsRoute")]
        public IActionResult MechanicalFeesDetails(int id)
        {
            MechanicalFeesDetailsViewModel result = new MechanicalFeesDetailsViewModel();

            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));

            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "mech");
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.UnitCharge = valuationAndFeesEntity?.UnitCharge;
            result.NumberOfUnits = valuationAndFeesEntity?.NumberOfUnits;
            result.ExtendedAmount = valuationAndFeesEntity?.ExtendedAmount;
            result.PlrvwExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.MechanicalExtendedAmount = valuationAndFeesEntity?.AssignMechanicalFees;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/demolition-details/{id}", Name = "demolitionFeesDetailsRoute")]
        public IActionResult DemolitionFeesDetails(int id)
        {
            DemolitionFeesDetailsViewModel result = new DemolitionFeesDetailsViewModel();

            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));

            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "demo");
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.UnitCharge = valuationAndFeesEntity?.UnitCharge;
            result.NumberOfUnits = valuationAndFeesEntity?.NumberOfUnits;
            result.ExtendedAmount = valuationAndFeesEntity?.ExtendedAmount;
            result.PlrvwExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.DemolitionExtendedAmount = valuationAndFeesEntity?.AssignDemolitionFees;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/statebuilding-fee-details/{id}", Name = "stateBuildingfeeDetailsRoute")]
        public IActionResult StateBuildingFeeDetails(int id)
        {
            StateBuildingFeesDetailsViewModel result = new StateBuildingFeesDetailsViewModel();
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));
            var gradingExcavationPermitDetailEntity = _buildingModuleRepository.GetGradingExcavationPermitDetail(id);
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "stbcd");
            result.StateBuildingExtendedAmount = valuationAndFeesEntity?.AssignBidBuildingCodeFee;
            result.NumberOfUnits = valuationAndFeesEntity?.NumberOfUnits;
            result.ExtendedAmount = valuationAndFeesEntity?.ExtendedAmount;
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/other-fees-details/{id}", Name = "otherFeesDetailsRoute")]
        public IActionResult OtherFeesDetails(int id)
        {
            OtherFeesDetailsViewModel result = new OtherFeesDetailsViewModel();
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));
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
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "bldg");
            result.TotalBuildingFees = valuationAndFeesEntity?.AssignStructNanNodFees;
            result.ExtendedAmount = valuationAndFeesEntity?.BaseFee;
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.FeeCode = valuationAndFeesEntity?.FeeCode;
            result.NumberOfUnits = valuationAndFeesEntity.NumberOfUnits;
            result.BaseFee = valuationAndFeesEntity?.BaseFee;
            result.TotalValue = valuationAndFeesEntity?.ExtendedValue;
            result.FeeIncrement = valuationAndFeesEntity?.FeeIncrement;
            result.MinMaxFlag = valuationAndFeesEntity?.MinMaxFlag;
            result.TotalBuildingFees = valuationAndFeesEntity?.BaseFee.Where(t=>t.HasValue).Sum();
            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/plan-review-fee-details/{id}", Name = "planReviewFeeDetailsRoute")]
        public IActionResult PlanReviewFeeDetails(int id)
        {
            PlanReviewFeeDetailsViewModel result = new PlanReviewFeeDetailsViewModel();
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));
            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                             result.BasicInfo.ApplicationNumber, "plrvw");
            result.ExtendedAmount = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.PlanReviewFee = valuationAndFeesEntity?.BaseFee.FirstOrDefault();
            result.TotalValue = valuationAndFeesEntity?.ExtendedValue;
            result.TotalPlanReviewFees = valuationAndFeesEntity?.AssignPlanReviewFee;
            result.BuildingPermit = valuationAndFeesEntity?.AssignStructNanNodFees;

            return View(result);
        }

        [HttpGet]
        [Route("/building-permit-system/valuation-fee-details/{id}", Name = "valuationFeeDetailsRoute")]
        public IActionResult ValuationFeeDetails(int id)
        {
            ValuationFeeDetailsViewModel result = new ValuationFeeDetailsViewModel();
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));
            var valuationAndFeesEntity = _buildingModuleRepository.GetValuationDetails(id);
            result.ExtendedValue = valuationAndFeesEntity?.ExtendedValue;
            result.SquareFeet = valuationAndFeesEntity?.SquareFeet;
            result.Items = new List<ValuationFeeDetailsItemViewModel>();
            for (int i = 0; i < valuationAndFeesEntity?.Items?.Count; i++)
            {
                result.Items.Add(new ValuationFeeDetailsItemViewModel
                {
                    ComponentDescription = valuationAndFeesEntity.Items[i].ComponentDescription,
                    ConstructionTypeDescription = valuationAndFeesEntity.Items[i].ConstructionTypeDescription,
                    Cost = valuationAndFeesEntity.Items[i].Cost,
                    ExtendedValue = valuationAndFeesEntity.Items[i].ExtendedValue,
                    NumberOfOccupants = valuationAndFeesEntity.Items[i].NumberOfOccupants,
                    OccupantType = valuationAndFeesEntity.Items[i].OccupantType,
                    SectionDescription = valuationAndFeesEntity.Items[i].SectionDescription,
                    SequenceNumber = (int)valuationAndFeesEntity.Items[i].SequenceNumber,
                    SquareFeet = valuationAndFeesEntity.Items[i].SquareFeet,
                    TableNumberSectLineSeq = valuationAndFeesEntity.Items[i].TableNumberSectLineSeq
                });
            }
            return View(result);
        }

        [Route("/building-permit-system/fire-marshal-fees-details/{id}", Name = "fireMarshalFeesDetailsRoute")]
        public IActionResult FireMarchalFeesDetails(int id)
        {
            FireMarshalFeesDetailsViewModel result = new FireMarshalFeesDetailsViewModel();
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));

            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                            result.BasicInfo.ApplicationNumber, "fire");

            result.TotalValue = valuationAndFeesEntity?.ExtendedValue;
            result.TotalFireMarshalFees = valuationAndFeesEntity?.AssignFireMarshalFees;
            result.SequenceNumber = valuationAndFeesEntity?.SequenceNumber;
            result.FeeDescription = valuationAndFeesEntity?.Description;
            result.NumberOfUnits = valuationAndFeesEntity?.NumberOfUnits;
            result.UnitCharge = valuationAndFeesEntity?.UnitCharge;
            result.ExtendedAmount = valuationAndFeesEntity?.ExtendedAmount;
            return View(result);
        }

        [Route("/building-permit-system/total-fees-details/{id}", Name = "totalFeesDetailsRoute")]
        public IActionResult TotalFeesDetails(int id)
        {
            TotalFeesDetailsViewModel result = new TotalFeesDetailsViewModel();
            result.BasicInfo = Mapper.Map<BuildingPermitSystemBasicInfoViewModel>(_buildingModuleRepository.GetBasicInfo(id));

            var valuationAndFeesEntity = GetValuationAndFees(id, result.BasicInfo.ApplicationYear,
                                                            result.BasicInfo.ApplicationNumber, "fire");
            var receiptHeader = GetReceiptsReport(id);

            result.TotalValue = valuationAndFeesEntity?.AssignedValue;
            result.TotalFeesDue = valuationAndFeesEntity?.ExtendedAmountTotal;
            result.TotalPaid = receiptHeader?.ReceiptHeaders.Where(t=>t.ApplicationNumber == result.BasicInfo.ApplicationNumber && t.ApplicationYear == result.BasicInfo.ApplicationYear).
                               Select(t=>t.TotalReceipt-t.CheckAmount).Sum();
            result.BalanceDue = result.TotalFeesDue - result.TotalPaid;
            result.ProjectedExpireDate = valuationAndFeesEntity?.ProjectedExpireDate;
            result.ActualExpireDate = valuationAndFeesEntity?.ActualExpireDate;
            result.ByUser = valuationAndFeesEntity?.ExpiredByUser;
            return View(result);
        }

        ///totalFeesDetailsRoute

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