using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription
{
    public class LegalDescriptionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Description")]
        public string Descrtiption { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayerName { get; set; }

        [Display(Name = "Title Owner")]
        public string TitleOwnerName { get; set; }

        [Display(Name = "Contract Holder")]
        public string ContractHolderName { get; set; }
    }
}