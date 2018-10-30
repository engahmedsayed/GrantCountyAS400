using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.RealProperty
{
    public class RealPropertyFilterViewModel
    {
        [Display(Name = "Parcel (from)")]
        public decimal MinParcelNumber { get; set; }

        [Display(Name = "Parcel (to)")]
        public decimal MaxParcelNumber { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayer { get; set; }

        [Display(Name = "Title Owner")]
        public string Owner { get; set; }

        [Display(Name = "Contract Holder")]
        public string ContractHolder { get; set; }

        [Display(Name = "Tax Code Area")]
        public decimal TaxCodeArea { get; set; }
    }
}