using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class GeneralReceiptFilterViewModel
    {
        [Display(Name = "Receipt Number")]
        public decimal ReceiptNumber { get; set; }
    }
}