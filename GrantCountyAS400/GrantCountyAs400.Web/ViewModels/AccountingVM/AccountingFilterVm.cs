using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class AccountingFilterVm
    {
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        //[Range(0,double.MaxValue,ErrorMessage = "SSN Number is not in a correct format")]
        public decimal SSN { get; set; }
    }
}
