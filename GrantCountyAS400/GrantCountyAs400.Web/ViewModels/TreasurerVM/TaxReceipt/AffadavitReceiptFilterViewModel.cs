using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class AffadavitReceiptFilterViewModel
    {
        [Display(Name = "Receipt From")]
        public decimal MinReceiptNumber { get; set; }

        [Display(Name = "Receipt To")]
        public decimal MaxReceiptNumber { get; set; }

        [Display(Name = "Affidavit From")]
        public decimal MinAffidavitNumber { get; set; }

        [Display(Name = "Affidavit To")]
        public decimal MaxAffidavitNumber { get; set; }
    }
}