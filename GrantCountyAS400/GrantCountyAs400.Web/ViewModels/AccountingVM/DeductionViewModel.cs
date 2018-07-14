using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class DeductionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Year")]
        public int MiscYear { get; set; }

        [DisplayFormat(DataFormatString = "{0:00000}")]
        public decimal EmployeeNumber { get; set; }

        [Display(Name = "Code")]
        public string MiscCode { get; set; }

        public decimal MiscDeduction { get; set; }
        public decimal MiscBenefit { get; set; }
    }
}