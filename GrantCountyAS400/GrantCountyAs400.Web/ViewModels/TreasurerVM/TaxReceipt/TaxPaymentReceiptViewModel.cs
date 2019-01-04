using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class TaxPaymentReceiptViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Parcel Number")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }
        [Display(Name = "Parcel Extension")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal? ParcelExtension { get; set; }
        [Display(Name = "Tax Year")]
        public int TaxYear { get; set; }
        [Display(Name = "Tran Date")]
        [DataType(DataType.Date)]
        public DateTime? TransactionDate { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal? TaxAmount { get; set; }
        [Display(Name = "Tran Number")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal? ReceiptTranNumber { get; set; }
    }
}