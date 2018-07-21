using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class PersonnelFilterViewModel
    {
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public decimal SSN { get; set; }
    }
}