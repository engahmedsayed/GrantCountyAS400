using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription
{
    public class LegalDescriptionFilterViewModel
    {
        [Display(Name = "Parcel")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}