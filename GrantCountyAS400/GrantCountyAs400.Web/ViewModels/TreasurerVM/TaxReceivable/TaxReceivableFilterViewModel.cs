using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.TaxReceivable
{
    public class TaxReceivableFilterViewModel
    {
        [Display(Name = "Parcel")]
        public decimal ParcelNumber { get; set; }
    }
}