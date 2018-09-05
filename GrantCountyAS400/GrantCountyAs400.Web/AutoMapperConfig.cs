using AutoMapper;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Web.ViewModels.AccountingVM;
using GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson;
using GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits;
using GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel;
using GrantCountyAs400.Web.ViewModels.Assessment.HomePark;
using GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription;
using GrantCountyAs400.Web.ViewModels.Assessment.PlatCondo;
using GrantCountyAs400.Web.ViewModels.Assessment.RealProperty;
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

                cfg.CreateMap<ChildParentParcel, ChildParentParcelViewModel>();
                cfg.CreateMap<ChildParentParcelDetails, ChildParentParcelDetailsViewModel>();

                cfg.CreateMap<AssociatedPerson, AssociatedPersonViewModel>();
                cfg.CreateMap<AssociatedPersonMain, AssociatedPersonMainViewModel>();
                cfg.CreateMap<LineValue, LineValueViewModel>();

                cfg.CreateMap<BuildingPermitsMain, BuildingPermitsMainViewModel>();

                cfg.CreateMap<RealProperty, RealPropertyViewModel>();
                cfg.CreateMap<RealPropertyDetails, RealPropertyDetailsViewModel>();

                #endregion Assessment Module
            });
        }
    }
}