using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable
{
    public class TaxReceivableFilterViewModel
    {
        [Display(Name = "Parcel From")]
        public decimal MinParcelNumber { get; set; }

        [Display(Name = "Parcel To")]
        public decimal MaxParcelNumber { get; set; }
    }
}