using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class TaxReceiptViewModel
    {
        [Display(Name = "Receipt Number")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal ReceiptNumber { get; set; }

        [Display(Name = "Receipt Date")]
        [DataType(DataType.Date)]
        public DateTime? ReceiptDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:F0}")]
        [Display(Name = "Affdvt Number")]
        public decimal? AffidavitNumber { get; set; }
    }
}