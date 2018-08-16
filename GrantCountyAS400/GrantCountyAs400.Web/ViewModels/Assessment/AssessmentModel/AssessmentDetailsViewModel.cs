using GrantCountyAs400.Web.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AssessmentModel
{
    public class AssessmentDetailsViewModel
    {
        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        public string TaxPayerCode { get; set; }
        public string TaxPayerName { get; set; }
        public string TitleOwnerCode { get; set; }
        public string TitleOwnerName { get; set; }
        public string ContractHolderCode { get; set; }
        public string ContractHolderName { get; }

        [Display(Name = "Tax Year")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal TaxYear { get; set; }

        [Display(Name = "Date of Name Change")]
        [DataType(DataType.Date)]
        public DateTime? NameChangeDate { get; set; }

        public string NameChangeId { get; set; }

        [Display(Name = "Reason of Name Change")]
        public string NameChangeReason { get; set; }

        [Display(Name = "Loan Number")]
        public string LoanNumber { get; set; }

        public string PlatCode { get; set; }
        public string PlatCodeType { get; set; }

        [Display(Name = "Block Number")]
        public string BlockNumber { get; set; }

        [Display(Name = "Lot Number")]
        public string LotNumber { get; set; }

        [Display(Name = "Unit Number")]
        public string UnitNumber { get; set; }

        [Display(Name = "Dock Number")]
        public string DockNumber { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
        public decimal TaxCodeArea { get; }
        public string TaxCodeDesc { get; }
        public decimal LandUseCode { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Change Date")]
        public DateTime ChangeDate { get; set; }

        public string ChangeId { get; set; }
        public string ChangeReasonCode { get; set; }
        public string UseCodeShortDesc { get; set; }
        public string ZoneCode { get; set; }
        public string ZoneCodeDesc { get; set; }

        [Display(Name = "Status")]
        public string TaxStatus { get; set; }

        [Display(Name = "Revalution Phase")]
        public string RevalutionPhase { get; set; }

        public decimal UnimprovedLandAcres { get; set; }
        public decimal ImprovedLandAcers { get; set; }
        public decimal TimberAcers { get; set; }
        public decimal UnimprovedLandValue { get; set; }
        public decimal ImprovedLandValue { get; set; }
        public decimal TimberlandValue { get; set; }
        public decimal BuildingValue { get; set; }
        public decimal FmbuildingValue { get; set; }
        public decimal FmunimprovedLandValue { get; set; }
        public decimal FmimprovedLandValue { get; set; }
        public decimal FmtimberValue { get; set; }

        [Display(Name = "New Construction")]
        public decimal NewConstructionBuildingAv { get; }

        [Display(Name = "Assoc Mhparcel")]
        public decimal AssocMhparcel { get; set; }

        public decimal AffidavitAssessmentYear { get; set; }
        public decimal AffidavitTaxYear { get; set; }

        [Display(Name = "Openspace Application #")]
        public decimal OpenspaceApplicationNum { get; set; }

        [Display(Name = "Openspace Agreement #")]
        public decimal OpenSpaceAgreementNum { get; set; }

        [Display(Name = "Undivided Interest %")]
        public decimal UndividedInterestPercent { get; set; }

        [Display(Name = "Mobile Home Value")]
        public decimal MobileHomeValue { get; set; }

        [Display(Name = "Senior Citizend Code")]
        public string SeniorCitizenCode { get; set; }

        [Display(Name = "SubsidiaryParcelCode")]
        public string SubsidiaryParcelCode { get; set; }

        [Display(Name = "Tax Payer(code - name)")]
        public string TaxPayerDisplay => $"{TaxPayerCode} - {TaxPayerName}";

        [Display(Name = "Title Owner(code - name)")]
        public string TitleOwnerDisplay => $"{TitleOwnerCode} - {TitleOwnerName}";

        [Display(Name = "Contract Holder(code - name)")]
        public string ContractHolderDisplay => (string.IsNullOrWhiteSpace(ContractHolderCode)) ? "" : $"{ContractHolderCode} - {ContractHolderName}";

        [Display(Name = "Plat Code(type - code)")]
        public string PlatCodeDisplay => $"{PlatCodeType} - {PlatCode}";

        [Display(Name = "Tax Code(area - desciption)")]
        public string TaxCodeDisplay => $"{TaxCodeArea} - {TaxCodeDesc}";

        [Display(Name = "Land Use(code - desciption)")]
        public string LandUseDisplay => $"{LandUseCode} - {UseCodeShortDesc}";

        [Display(Name = "Zone Code(code - desciption)")]
        public string ZoneCodeDisplay => $"{ZoneCode} - {ZoneCodeDesc}";

        [Display(Name = "Affidavit(Assessment Year - Tax Year)")]
        public string AffidavitTaxYearDisplay => $"{AffidavitAssessmentYear} - {AffidavitTaxYear}";

        public string TaxStatusDisplay => TaxStatusFactory.TaxStatusCodeToDescription(TaxStatus);
        public decimal TotalLand => ImprovedLandValue + UnimprovedLandValue;
        public decimal TotalFmLand => FmimprovedLandValue + FmunimprovedLandValue;
        public decimal TotalFm => FmimprovedLandValue + FmunimprovedLandValue + FmbuildingValue;

        [Display(Name = "Reg Taxable")]
        public decimal RegTaxable => TotalLand + FmbuildingValue;
    }
}