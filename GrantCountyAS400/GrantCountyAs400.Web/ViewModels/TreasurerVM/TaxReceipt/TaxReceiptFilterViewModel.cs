using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class TaxReceiptFilterViewModel
    {
        [Display(Name = "Receipt Number (from)")]
        public decimal MinReceiptNumber { get; set; }

        [Display(Name = "Receipt Number (to)")]
        public decimal MaxReceiptNumber { get; set; }

        [Display(Name = "Date (from)")]
        [UIHint("DatePicker")]
        public DateTime? MinDate { get; set; } = null;

        [Display(Name = "Date (to)")]
        [UIHint("DatePicker")]
        public DateTime? MaxDate { get; set; } = null;
    }
}