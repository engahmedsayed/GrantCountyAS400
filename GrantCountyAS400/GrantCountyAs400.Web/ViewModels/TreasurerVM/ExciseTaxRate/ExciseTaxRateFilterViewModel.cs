using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.TreasurerVM.ExciseTaxRate
{
    public class ExciseTaxRateFilterViewModel
    {
        [Display(Name = "Record Type")]
        public string RecordType { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}