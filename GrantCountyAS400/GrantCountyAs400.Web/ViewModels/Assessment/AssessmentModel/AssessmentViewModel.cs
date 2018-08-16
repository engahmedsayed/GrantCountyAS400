using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AssessmentModel
{
    public class AssessmentViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayerName { get; set; }

        [Display(Name = "Title Owner")]
        public string TitleOwnerName { get; set; }

        [Display(Name = "Contract Holder")]
        public string ContractHolderName { get; set; }

        [Display(Name = "Tax Code Area")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal TaxCodeArea { get; set; }

        [Display(Name = "Tax Code Description")]
        public string TaxCodeDesc { get; set; }
    }
}