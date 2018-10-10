using AutoMapper;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Web.ViewModels.AccountingVM;
using GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson;
using GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits;
using GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel;
using GrantCountyAs400.Web.ViewModels.Assessment.HomePark;
using GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription;
using GrantCountyAs400.Web.ViewModels.Assessment.LegalDocument;
using GrantCountyAs400.Web.ViewModels.Assessment.PlatCondo;
using GrantCountyAs400.Web.ViewModels.Assessment.RealProperty;
using GrantCountyAs400.Web.ViewModels.BuildingVM;
using GrantCountyAs400.Web.ViewModels.GeneralLedgerVM;

namespace GrantCountyAs400.Web
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                #region Accounting

                cfg.CreateMap<Personnel, PersonnelViewModel>();
                cfg.CreateMap<Contract, ContractViewModel>();
                cfg.CreateMap<Organization, OrganizationViewModel>();
                cfg.CreateMap<PersonnelWithContractDetails, PersonnelWithContractDetailsViewModel>();
                cfg.CreateMap<Deduction, DeductionViewModel>();
                cfg.CreateMap<YtdHistory, YtdHistoryViewModel>();

                #endregion Accounting

                #region General Ledger

                cfg.CreateMap<GeneralLedger, GeneralLedgerViewModel>();
                cfg.CreateMap<GeneralLedgerDetailItem, GeneralLedgerDetailsViewModel>();

                #endregion General Ledger

                #region Assessment Module

                cfg.CreateMap<LegalDescription, LegalDescriptionViewModel>();

                cfg.CreateMap<RealPropertyWithLegalDescriptions, RealPropertyWithLegalDescriptionsViewModel>();

                cfg.CreateMap<ManufacturedHomePark, ManufacturedHomeParkViewModel>();
                cfg.CreateMap<ManufacturedHomeParkDetails, ManufacturedHomeParkDetailsViewModel>();

                cfg.CreateMap<PlatCondo, PlatCondoViewModel>();

                cfg.CreateMap<ParentParcel, ParentParcelViewModel>();
                cfg.CreateMap<ChildParcelDetails, ChildParentParcelDetailsViewModel>();

                cfg.CreateMap<AssociatedPerson, AssociatedPersonViewModel>();
                cfg.CreateMap<AssociatedPersonMain, AssociatedPersonMainViewModel>();
                cfg.CreateMap<LineValue, LineValueViewModel>();

                cfg.CreateMap<BuildingPermitsMain, BuildingPermitsMainViewModel>();

                cfg.CreateMap<RealProperty, RealPropertyViewModel>();
                cfg.CreateMap<RealPropertyDetails, RealPropertyDetailsViewModel>();

                cfg.CreateMap<LegalDocument, LegalDocumentViewModel>();
                cfg.CreateMap<RealPropertyLegalDocument, RealPropertyLegalDocumentViewModel>();
                cfg.CreateMap<LegalDocumentDetails, LegalDocumentDetailsViewModel>();

                #endregion Assessment Module

                #region BuildingModule

                cfg.CreateMap<BuildingPermitSystem, BuildingPermitSystemViewModel>();
                cfg.CreateMap<BuildingPermitSystemDetails, BuildingPermitSystemDetailsViewModel>();

                cfg.CreateMap<BuildingPermitSystemApplicantDetails, BuildingPermitSystemApplicantDetailsViewModel>();
                cfg.CreateMap<BuildingPermitSystemBasicInfo, BuildingPermitSystemBasicInfoViewModel>();
                cfg.CreateMap<BuildingValueMasterNameInfo, BuildingValueMasterNameInfoViewModel>();
                cfg.CreateMap<BuildingSitusAddressInfo, BuildingSitusAddressInfoViewModel>();
                cfg.CreateMap<BuildingPermitSystemApprovalStatusInfo, BuildingPermitSystemApprovalStatusViewModel>();
                cfg.CreateMap<ApprovalStatusInfo, ApprovalStatusViewModel>();
                cfg.CreateMap<PlanningApproval, BuildingPermitSystemPlanningApprovalViewModel>();
                cfg.CreateMap<PermitApprovedInfo, PermitApprovedInfoViewModel>();
                cfg.CreateMap<DemolitionPermit, DemolitionPermitViewModel>();
                cfg.CreateMap<OtherPermitDetail, OtherPermitDetailViewModel>();
                cfg.CreateMap<MechanicalPermitDetail, MechanicalPermitDetailViewModel>();
                cfg.CreateMap<StructurePermitDetail, StructurePermitDetailViewModel>();
                cfg.CreateMap<ValuationAndFees, ValuationAndFeesViewModel>();
                cfg.CreateMap<GradingExcavationPermitDetail, GradingExcavationPermitDetailViewModel>();
                cfg.CreateMap<ManufactureModularPermit, ManufactureModularPermitViewModel>();
                cfg.CreateMap<DealersInstallersArchitectInfo, DealersInstallersArchitectInfoViewModel>();
                cfg.CreateMap<PlumbingPermit, PlumbingPermitViewModel>();
                cfg.CreateMap<BuildingInspection, BuildingInspectionViewModel>();
                cfg.CreateMap<BuildingCondition, BuildingConditionViewModel>();

                #endregion BuildingModule
            });
        }
    }
}