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
                cfg.CreateMap<BuildingPermitSystemDetails, BuildingPermitSystemDetailsViewModel>()
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.AddendumNumber, source => source.MapFrom(n => n.AddendumNumber))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.ApplicationNumber, source => source.MapFrom(n => n.ApplicationNumber))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.ApplicationYear, source => source.MapFrom(n => n.ApplicationYear))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.DepartmentCode, source => source.MapFrom(n => n.DepartmentCode))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.DepartmentShortDepartmentName, source => source.MapFrom(n => n.DepartmentShortDepartmentName))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.JurisdictionCode, source => source.MapFrom(n => n.JurisdictionCode))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.JurisidictionShortDepartmentName, source => source.MapFrom(n => n.JurisidictionShortDepartmentName))
                .ForPath(destination => destination.BuildingPermitSystemDetailsHeaderViewModel.PermitStatus, source => source.MapFrom(n => n.PermitStatus))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.AdditionalInformation, source => source.MapFrom(n => n.AdditionalInformation))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ApplicantProjectDescription, source => source.MapFrom(n => n.ApplicantProjectDescription))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ApplicationName, source => source.MapFrom(n => n.ApplicationName))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ArchitectBusinessName, source => source.MapFrom(n => n.ArchitectBusinessName))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ArchitectFirmNumber, source => source.MapFrom(n => n.ArchitectFirmNumber))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ContractLicenseNumber, source => source.MapFrom(n => n.ContractLicenseNumber))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ContractorBusinessName, source => source.MapFrom(n => n.ContractorBusinessName))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.EnforcementDescription, source => source.MapFrom(n => n.EnforcementDescription))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.EngineerBusinessName, source => source.MapFrom(n => n.EngineerBusinessName))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.EngineerFirmNumber, source => source.MapFrom(n => n.EngineerFirmNumber))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.OnlyResidenceOnParcel, source => source.MapFrom(n => n.OnlyResidenceOnParcel))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.OnlyStructureOnParcel, source => source.MapFrom(n => n.OnlyStructureOnParcel))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.PlotPlanReceived, source => source.MapFrom(n => n.PlotPlanReceived))
                .ForPath(destination => destination.BuildingPermitSystemDetailsSubPageTwoViewModel.ResultOfEnforcementAction, source => source.MapFrom(n => n.ResultOfEnforcementAction));
                cfg.CreateMap<BuildingValueMasterNameInfo, BuildingValueMasterNameInfoViewModel>();
                cfg.CreateMap<BuildingSitusAddressInfo, BuildingSitusAddressInfoViewModel>();

                #endregion BuildingModule
            });
        }
    }
}