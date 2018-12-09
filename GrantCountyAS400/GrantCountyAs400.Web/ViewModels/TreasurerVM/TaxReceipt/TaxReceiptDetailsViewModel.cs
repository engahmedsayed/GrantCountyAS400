using GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class TaxReceiptDetailsViewModel
    {
        public decimal TransactionNumber { get; set; }
        public IEnumerable<CashReceiptViewModel> CashReceipts { get; set; }
        public IEnumerable<GeneralReceiptViewModel> GeneralReceipts { get; set; }
        public IEnumerable<AffadavitReceiptViewModel> AffadavitReceipts { get; set; }
        public IEnumerable<PropertyTaxReceivableReceiptViewModel> PropertyReceipts { get; set; }

        [Display(Name = "Total Tax")]
        public decimal? TotalTaxAmount => PropertyReceipts.Sum(t => t.TaxAmount);
        [Display(Name = "Total Assessment")]
        public decimal? TotalAssessment => PropertyReceipts.Sum(t => t.TotalAssessmentPaid);
        [Display(Name = "Total Interest / Penalty")]
        public decimal? TotalTotalInterestAndPenalty => PropertyReceipts.Sum(t => t.TotalInterestAndPenaltyPaid);
        [Display(Name = "Total Paid")]
        public decimal? TotalPaid => PropertyReceipts.Sum(t => t.TotalPaid) +
                                     AffadavitReceipts.Sum(t => t.TotalPaid) +
                                     GeneralReceipts.Sum(t => t.TaxAmount);
    }

    public class CashReceiptViewModel
    {
        public int Id { get; set; }
        public int TransactionYear { get; set; }
        [Display(Name = "Receipt Number")]
        public decimal ReceiptNumber { get; set; }
        public string TaxpayerCode { get; set; }
        [Display(Name = "Taxpayer Name")]
        public string TaxPayerName { get; set; }
        [Display(Name = "Address line (1)")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address line (2)")]
        public string AddressLine2 { get; set; }
        [Display(Name = "Receipt Date")]
        [DataType(DataType.Date)]
        public DateTime? ReceiptDate { get; set; }
        [Display(Name = "Clerk")]
        public string ChangeSerId { get; set; }
        [Display(Name = "Comments")]
        public string Comments { get; set; }
        [Display(Name = "Comments (2)")]
        public string Comments2 { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? AmountTendered { get; set; }

        public decimal? AmountTenderedDisplay => (AmountTendered.HasValue) ? Math.Abs(AmountTendered.Value) : AmountTendered;
        public string PaymentMethodDisplay
        {
            get
            {
                switch (PaymentMethod)
                {
                    case "1":
                        return "Check";

                    case "2":
                        return "Cash";

                    case "3":
                        return "Money Order";

                    case "4":
                        return "Warrent";

                    case "5":
                        return "See Terrascan";

                    case "6":
                        return "EFT";

                    case "7":
                        return "Refund";

                    case "8":
                        return "Over/Short";

                    case "9":
                        return "Cash Back";

                    case "I":
                        return "Investment";

                    default:
                        return PaymentMethod;
                }
            }
        }
    }

    public class GeneralReceiptViewModel
    {
        public int Id { get; set; }
        public int TransactionYear { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "General Receipt")]
        public decimal ReceiptNumber { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:000-000-000}")]
        [Display(Name = "Fund/Department")]
        public decimal? FundNumber { get; set; }
        public decimal? BarsNumber { get; set; }
        public decimal? Element { get; set; }
        public decimal? Object { get; set; }
        public decimal? Function { get; set; }
        [Display(Name = "Paid")]
        public decimal? TaxAmount { get; set; }

        [Display(Name = "Revenue")]
        public string RevenueDisplay => $"{BarsNumber}  {Element}  {Object}  {Function}";
    }

    public class AffadavitReceiptViewModel
    {
        public int Id { get; set; }
        public int TransactionYear { get; set; }
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "Affdvt Number")]
        public decimal ReceiptNumber { get; set; }
        [Display(Name = "Buyer")]
        public string NewOwnerBuyer { get; set; }
        [Display(Name = "Seller")]
        public string PreviousOwnerSeller { get; set; }
        [Display(Name = "Paid")]
        public decimal? TotalPaid { get; set; }
    }

    public class PropertyTaxReceivableReceiptViewModel
    {
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        [Display(Name = "Parcel")]
        public decimal? ParcelNumber { get; set; }
        [Display(Name = "Tax")]
        public decimal? TaxAmount { get; set; }
        [Display(Name = "Tax Year")]
        public int TaxYear { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TransactionDate { get; set; }
        public int? TransactionNumber { get; set; }
        public string ChangeReasonCode { get; set; }
        public decimal? InterestPaid { get; set; }
        public decimal? LpAmount { get; set; }
        public IEnumerable<SpecialAssessmentTransactionViewModel> SpecialAssessmentTransactions { get; set; }

        [Display(Name = "Assessment")]
        public decimal? TotalAssessmentPaid => SpecialAssessmentTransactions.Sum(x => x.AssessmentPaid);
        [Display(Name = "Interest / Penalty")]
        public decimal? TotalInterestAndPenaltyPaid
            => (SpecialAssessmentTransactions.Sum(x => x.PenaltyPaid) + LpAmount) +
               (SpecialAssessmentTransactions.Sum(x => x.InterestPaid) + InterestPaid);

        [Display(Name = "Paid")]
        public decimal? TotalPaid => TotalInterestAndPenaltyPaid + TotalAssessmentPaid + TaxAmount;
    }
}