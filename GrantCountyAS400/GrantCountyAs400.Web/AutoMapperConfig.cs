﻿using AutoMapper;
using GrantCountyAs400.Domain;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Web.ViewModels.AccountingVM;
using GrantCountyAs400.Web.ViewModels.AccountingVM.AccountPayroll;
using GrantCountyAs400.Web.ViewModels.AccountingVM.VenderWarrent;
using GrantCountyAs400.Web.ViewModels.Assessment.AddressSearch;
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
using GrantCountyAs400.Web.ViewModels.TreasurerVM.ExciseTaxRate;
using GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt;
using GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable;

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
                cfg.CreateMap<VenderWarrent, VenderWarrentViewModel>();
                cfg.CreateMap<AccountPayroll, AccountPayrollViewModel>();
                cfg.CreateMap<AccountPayrollWarrant, AccountPayrollWarrantViewModel>();

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

                cfg.CreateMap<AddressSearch, AddressSearchViewModel>();

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
                cfg.CreateMap<AssessorApproval, BuildingPermitSystemAssessorApprovalViewModel>();
                cfg.CreateMap<PublicWorkApproval, BuildingPermitSystemPublicWorkApprovalViewModel>();
                cfg.CreateMap<HealthApproval, BuildingPermitSystemHealthApprovalViewModel>();
                cfg.CreateMap<CityApproval, BuildingPermitSystemCityApprovalViewModel>();
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
                cfg.CreateMap<ReceiptHeader, ReceiptHeaderViewModel>();
                cfg.CreateMap<BuildingApplicationFee, BuildingApplicationFeeViewModel>();
                cfg.CreateMap<ApplicationReceiptInfo, ApplicationReceiptInfoViewModel>();

                cfg.CreateMap<BuildingPermitSystemFilterViewModel, BuildingSearchCriteria>();

                cfg.CreateMap<HistoricValuesItems, HistoricValuesViewModel>();

                #endregion BuildingModule

                #region Treasurer

                cfg.CreateMap<TaxReceivable, TaxReceivableViewModel>();
                cfg.CreateMap<TaxReceivableDetails, TaxReceivableDetailsViewModel>();
                cfg.CreateMap<PropertyTaxReceivable, PropertyTaxReceivableViewModel>();
                cfg.CreateMap<SpecialAssessmentTaxReceivable, SpecialAssessmentTaxReceivableViewModel>();
                cfg.CreateMap<PropertyTaxReceivableTransaction, PropertyTaxReceivableTransactionViewModel>();
                cfg.CreateMap<SpecialAssessmentTransaction, SpecialAssessmentTransactionViewModel>();
                cfg.CreateMap<TaxReceiptDetails, TaxReceiptDetailsViewModel>();
                cfg.CreateMap<PropertyTaxReceivableTransaction, PropertyTaxReceivableReceiptViewModel>();
                cfg.CreateMap<TaxPaymentReceipt, TaxPaymentReceiptViewModel>();
                cfg.CreateMap<AffadavitReceipt, AffadavitReceiptViewModel>();
                cfg.CreateMap<AffadavitReceiptDetails, AffadavitReceiptDetailsViewModel>();
                cfg.CreateMap<AffadavitReceiptParcel, AffadavitReceiptParcelViewModel>();
                cfg.CreateMap<ExciseTaxRate, ExciseTaxRateViewModel>();

                #endregion Treasurer
            });
        }
    }
}