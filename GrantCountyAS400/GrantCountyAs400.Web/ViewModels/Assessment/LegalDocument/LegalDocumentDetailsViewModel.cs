using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDocument
{
    public class LegalDocumentDetailsViewModel
    {
        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        public string TaxPayerCode { get; set; }
        public string TaxPayerName { get; set; }
        public string TitleOwnerCode { get; set; }
        public string TitleOwnerName { get; set; }
        public string ContractHolderCode { get; set; }
        public string ContractHolderName { get; set; }
        public decimal LandUseCode { get; set; }

        [Display(Name = "Loan Number")]
        public string LoanNumber { get; set; }

        [Display(Name = "Building AV")]
        [DisplayFormat(DataFormatString = "{0:##,#}")]
        public decimal BuildingValue { get; set; }

        public decimal UnimprovedLandValue { get; set; }
        public decimal ImprovedLandValue { get; set; }

        [Display(Name = "Instrument Date")]
        [DataType(DataType.Date)]
        public DateTime? LegalInstrumentDate { get; set; }

        [Display(Name = "Instrument Type")]
        public string LegalDocumentType { get; set; }

        [Display(Name = "Previous Owner")]
        public string PreviousOwnerSeller { get; set; }

        public decimal Volume { get; set; }
        public decimal Page { get; set; }
        public decimal AffidavitNumber { get; set; }
        public string AffidavitNumberExtension { get; set; }

        [Display(Name = "Auditor's File #")]
        public decimal AuditorFileNumber { get; set; }

        [Display(Name = "Comment")]
        public string LegalDocumentComment { get; set; }

        [Display(Name = "Change Id")]
        public string ChangeId { get; set; }

        [Display(Name = "Change Date")]
        [DataType(DataType.Date)]
        public DateTime ChangeDate { get; set; }

        [Display(Name = "Assocate R/P Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal AssocateParcelNumber { get; set; }

        [Display(Name = "Probate Number ")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal ProbateNumber { get; set; }

        [Display(Name = "Gross Sale Amount")]
        public decimal RPsalesAmount { get; set; }

        [Display(Name = "P/P Sale Amount")]
        public decimal PPsalesAmount { get; set; }

        [Display(Name = "Multiple Sale")]
        public string MultipleParcelSale { get; set; }

        [Display(Name = "Rejection Code")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal SaleRejectionCode { get; set; }

        [Display(Name = "Reason / Comment")]
        public string TaxDataComment { get; set; }

        [Display(Name = "P/P Parcel")]
        public decimal PersPropParcel { get; set; }

        [Display(Name = "Incorporated Area?")]
        public string IncorporatedArea { get; set; }

        [Display(Name = "Land AV")]
        [DisplayFormat(DataFormatString = "{0:##,#}")]
        public decimal AssessedValue { get; set; }

        [Display(Name = "Tax Year")]
        public int TaxYear { get; set; }

        [Display(Name = "Affidavit Date")]
        [DataType(DataType.Date)]
        public DateTime? SaleDate { get; set; }

        public string UseCodeShortDesc { get; set; }
        public string TaxCodeDesc { get; set; }
        public decimal TaxCodeArea { get; set; }

        [Display(Name = "Instrument Type Description ")]
        public string InstrumentTypeDescription { get; set; }

        [Display(Name = "Fulfillment")]
        public string RejectionReasonCodeComment { get; set; }

        [Display(Name = "Tax Payer(code - name)")]
        public string TaxPayerDisplay => $"{TaxPayerCode} - {TaxPayerName}";

        [Display(Name = "Title Owner(code - name)")]
        public string TitleOwnerDisplay => $"{TitleOwnerCode} - {TitleOwnerName}";

        [Display(Name = "Contract Holder(code - name)")]
        public string ContractHolderDisplay => (string.IsNullOrWhiteSpace(ContractHolderCode)) ? "" : $"{ContractHolderCode} - {ContractHolderName}";

        [Display(Name = "Tax Code(area - desciption)")]
        public string TaxCodeDisplay => $"{TaxCodeArea} - {TaxCodeDesc}";

        [Display(Name = "Land Use(code - desciption)")]
        public string LandUseDisplay => $"{LandUseCode} - {UseCodeShortDesc}";

        [Display(Name = "Affidavit #")]
        public string AffidavitDisplay => (string.IsNullOrWhiteSpace(GetAffidavitDisplay()) || string.IsNullOrWhiteSpace(AffidavitNumberExtension))
                                          ? "" : GetAffidavitDisplay() + AffidavitNumberExtension;

        [Display(Name = "Volume - Page")]
        public string VolumePageDisplay => $"{Volume} - {Page}";

        [Display(Name = "Total AV")]
        public decimal TotalValue => BuildingValue + ImprovedLandValue + UnimprovedLandValue;

        [Display(Name = "Net R/P Sale")]
        public decimal NetRPSale => RPsalesAmount;

        private string GetAffidavitDisplay()
        {
            var affidavitNumberString = AffidavitNumber.ToString();
            var withoutFirstTwoLetters = affidavitNumberString.Substring(2);
            var result = withoutFirstTwoLetters.Substring(0, 2) + "-" + withoutFirstTwoLetters.Substring(2);

            return result.EndsWith("00000") ? string.Empty : result;
        }
    }
}