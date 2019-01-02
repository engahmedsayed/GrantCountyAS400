using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class TaxPaymentReceiptFilterViewModel
    {
        [Display(Name = "Parcel Number")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Parcel Extension")]
        public decimal ParcelExtension { get; set; }

        [Display(Name = "Tax Year")]
        public int TaxYear { get; set; }        
    }
}