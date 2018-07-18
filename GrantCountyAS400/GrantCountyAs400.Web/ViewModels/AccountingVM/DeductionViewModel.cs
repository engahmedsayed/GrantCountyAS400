using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class DeductionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Year")]
        public int MiscYear { get; set; }

        [DisplayFormat(DataFormatString = "{0:00000}")]
        [Display(Name = " Employee #")]
        public decimal EmployeeNumber { get; set; }

        [Display(Name = "Code")]
        public string MiscCode { get; set; }

        [Display(Name = "Deduction")]
        public decimal MiscDeduction { get; set; }

        [Display(Name = "Benefit")]
        public decimal MiscBenefit { get; set; }
    }
}