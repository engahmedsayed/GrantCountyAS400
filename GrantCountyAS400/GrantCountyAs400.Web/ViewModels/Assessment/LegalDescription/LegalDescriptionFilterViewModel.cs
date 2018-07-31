using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription
{
    public class LegalDescriptionFilterViewModel
    {
        [Display(Name = "Parcel")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayer { get; set; }

        [Display(Name = "Title Owner")]
        public string Owner { get; set; }

        [Display(Name = "Contract Holder")]
        public string ContractHolder { get; set; }
    }
}