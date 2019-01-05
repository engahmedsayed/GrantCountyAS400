using GrantCountyAs400.Web.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class AffadavitReceiptDetailsViewModel
    {
        public int Id { get; set; }
        public int TransactionYear { get; set; }
        [DisplayFormat(DataFormatString = "{0:F0}")]
        [Display(Name = "Receipt Number")]
        public decimal ReceiptNumber { get; set; }
        [Display(Name = "Paid")]
        public decimal? TotalPaid { get; set; }
        [DisplayFormat(DataFormatString = "{0:F0}")]
        [Display(Name = "Affdvt Number")]
        public decimal? AffadavitNumber { get; set; }
        [Display(Name = "Affdvt Date")]
        [DataType(DataType.Date)]
        public DateTime? AffidavitDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        [Display(Name = "Parcel")]
        public decimal? ParcelNumber { get; set; }
        [Display(Name = "Legal Document Type")]
        public string LegalDocumentType { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Document Date")]
        public DateTime? DocumentDate { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public string TaxStatus { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReceiptDate { get; set; }
        public string TaxCodeDesc { get; set; }

        public IEnumerable<AffadavitReceiptParcelViewModel> AffadavitReceiptParcels { get; set; }

        [Display(Name = "Tax Status")]
        public string TaxStatusDisplay => TaxStatusFactory.TaxStatusCodeToDescription(TaxStatus);
        [Display(Name = "Tax Code(area - desciption)")]
        public string TaxCodeDisplay => $"{TaxCodeArea} - {TaxCodeDesc}";
    }

    public class AffadavitReceiptParcelViewModel
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        [Display(Name = "Parcel")]
        public decimal? ParcelNumber { get; set; }
        public decimal? AffadavitNumber { get; set; }
        public string NewOwnerBuyer { get; set; }
        public string PreviousOwnerSeller { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal? TaxAmount { get; set; }
        [Display(Name = "Paid")]
        public decimal? TotalPaid { get; set; }
        [Display(Name = "State Tax Paid")]
        public decimal? StateTaxPaid { get; set; }
        [Display(Name = "Assessed Value")]
        public decimal? AssessedValue { get; set; }
        [Display(Name = "P/P value")]
        public decimal? PPvalue { get; set; }
        [Display(Name = "Gift Debt")]
        public decimal? GiftDebt { get; set; }
        [Display(Name = "Local Tax Paid")]
        public decimal? LocalTaxPaid { get; set; }
        [Display(Name = "State Penalty")]
        public decimal? StatePenalty { get; set; }
        [Display(Name = "Local Penalty")]
        public decimal? LocalPenalty { get; set; }
        [Display(Name = "Local Interest")]
        public decimal? LocalInterest { get; set; }
        [Display(Name = "Technical Fee")]
        public decimal? TechnicalFee { get; set; }
        [Display(Name = "Subsidized Fee")]
        public decimal? SubsidizedFee { get; set; }
        public decimal? UnimprovedLandValue { get; set; }
        public decimal? ImprovedLandValue { get; set; }
        public decimal? BuildingValue { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        [Display(Name = "Legal Description")]
        public string LegalDescription { get; set; }

        [Display(Name = "Market Value")]
        public decimal? MarketValue => UnimprovedLandValue + ImprovedLandValue + BuildingValue;
    }
}