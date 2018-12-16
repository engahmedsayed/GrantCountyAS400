using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class TaxReceiptFilterViewModel
    {
        [Display(Name = "Receipt From")]
        public decimal MinReceiptNumber { get; set; }

        [Display(Name = "Receipt To")]
        public decimal MaxReceiptNumber { get; set; }

        [Display(Name = "Affidavit From")]
        public decimal MinAffidavitNumber { get; set; }

        [Display(Name = "Affidavit To")]
        public decimal MaxAffidavitNumber { get; set; }

        [Display(Name = "Date From")]
        [UIHint("DatePicker")]
        public DateTime? MinDate { get; set; } = null;

        [Display(Name = "Date To")]
        [UIHint("DatePicker")]
        public DateTime? MaxDate { get; set; } = null;
    }
}