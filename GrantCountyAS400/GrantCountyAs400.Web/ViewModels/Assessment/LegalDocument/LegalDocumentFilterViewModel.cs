using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDocument
{
    public class LegalDocumentFilterViewModel
    {
        [Display(Name = "Parcel")]
        [Required(ErrorMessage = "Please enter value for Parcel Number")]
        public decimal ParcelNumber { get; set; }
    }
}