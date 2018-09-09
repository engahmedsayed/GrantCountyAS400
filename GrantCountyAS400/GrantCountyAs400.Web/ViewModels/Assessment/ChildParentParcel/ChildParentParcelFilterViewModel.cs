using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel
{
    public class ChildParentParcelFilterViewModel
    {
        [Display(Name = "Parcel Number")]
        public decimal ParcelNumber { get; set; }
    }
}