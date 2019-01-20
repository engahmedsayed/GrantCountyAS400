using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceipt
{
    public class AffadavitReceiptFilterViewModel
    {
        [Display(Name = "Parcel From")]
        public decimal MinParcelNumber { get; set; }

        [Display(Name = "Parcel To")]
        public decimal MaxParcelNumber { get; set; }

        [Display(Name = "Affidavit From")]
        public decimal MinAffidavitNumber { get; set; }

        [Display(Name = "Affidavit To")]
        public decimal MaxAffidavitNumber { get; set; }
    }
}