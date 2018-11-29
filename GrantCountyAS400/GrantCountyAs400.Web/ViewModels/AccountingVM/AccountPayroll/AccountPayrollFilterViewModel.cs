using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM.AccountPayroll
{
    public class AccountPayrollFilterViewModel
    {
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public decimal SSN { get; set; }

        [Display(Name = "Employee Number")]
        [DataType(DataType.Text)]
        public decimal EmployeeNumber { get; set; }

        [Display(Name = "Date From")]
        [UIHint("DatePicker")]
        public DateTime? MinDate { get; set; } = null;

        [Display(Name = "Date To")]
        [UIHint("DatePicker")]
        public DateTime? MaxDate { get; set; } = null;
    }
}