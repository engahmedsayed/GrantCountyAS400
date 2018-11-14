using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable
{
    public class TaxReceivableDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal? ParcelNumber { get; set; }
        [Display(Name = "Tax Code Area")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? TaxCodeArea { get; set; }
        public string TaxpayerCode { get; set; }
        public string TaxpayerName { get; set; }

        public IEnumerable<PropertyTaxReceivableViewModel> PropertyTaxReceivables { get; set; }

        [Display(Name = "Tax Payer(code - name)")]
        public string TaxPayerDisplay => $"{TaxpayerCode} - {TaxpayerName}";
    }

    public class PropertyTaxReceivableViewModel
    {
        [Display(Name = "Extension")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? ParcelExtension { get; set; }
        [Display(Name = "Year")]
        public int TaxYear { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal? TaxAmount { get; set; }
        [Display(Name = "Type")]
        public string Type { get; set; }
        public IEnumerable<SpecialAssessmentTaxReceivableViewModel> SpecialAssessmentTaxReceivables { get; set; }
        public IEnumerable<PropertyTaxReceivableTransactionViewModel> Transactions { get; set; }

        [Display(Name = "Total Assessment")]
        public decimal? TotalAssessmentAmount => SpecialAssessmentTaxReceivables.Sum(x => x.AssessmentAmount);
        [Display(Name = "Total Penalty")]
        public decimal? TotalPenaltyAmount => SpecialAssessmentTaxReceivables.Sum(x => x.PenaltyAmount);
        [Display(Name = "Total Interest")]
        public decimal? TotalInterestPaid => SpecialAssessmentTaxReceivables.Sum(x => x.InterestPaid);
    }

    public class SpecialAssessmentTaxReceivableViewModel
    {
        public decimal? AssessmentAmount { get; set; }
        public decimal? PenaltyAmount { get; set; }
        public decimal? InterestPaid { get; set; }
    }

    public class PropertyTaxReceivableTransactionViewModel
    {
        [Display(Name = "Extension")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? ParcelExtension { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal? TaxAmount { get; set; }
        public int TaxYear { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime? TransactionDate { get; set; }
        [Display(Name = "Transaction #")]
        public int? TransactionNumber { get; set; }
        [Display(Name = "Type")]
        public string Type { get; set; }
        public IEnumerable<SpecialAssessmentTransactionViewModel> SpecialAssessmentTransactions { get; set; }

        [Display(Name = "Assessment Paid")]
        public decimal? TotalAssessmentPaid => SpecialAssessmentTransactions.Sum(x => x.AssessmentPaid);
        [Display(Name = "Penalty Paid")]
        public decimal? TotalPenaltyPaid => SpecialAssessmentTransactions.Sum(x => x.PenaltyPaid);
        [Display(Name = "Interest Paid")]
        public decimal? TotalInterestPaid => SpecialAssessmentTransactions.Sum(x => x.InterestPaid);
    }

    public class SpecialAssessmentTransactionViewModel
    {
        public decimal? AssessmentPaid { get; set; }
        public decimal? PenaltyPaid { get; set; }
        public decimal? InterestPaid { get; set; }
    }
}