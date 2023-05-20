using GrantCountyAs400.Web.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM.AccountPayroll
{
    public class AccountPayrollViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public decimal SSNumber { get; set; }
        [Display(Name = "Employee #")]
        [DisplayFormat(DataFormatString = "{0:00000}")]
        public decimal PersonNumber { get; set; }
        public IEnumerable<AccountPayrollWarrantViewModel> PayrollWarrants { get; set; }

        [Display(Name = "SSN")]
        public string SSNumberDisplay => this.SSNumber.MaskSSN();
    }

    public class AccountPayrollWarrantViewModel
    {
        [Display(Name = "Warrant #")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal? WarrantNumber { get; set; }
        [Display(Name = "Check #")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal? CheckNumber { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? Date { get; set; }
        [Display(Name = "Gross")]
        public decimal? Gross { get; set; }
        [Display(Name = "Fica")]
        public decimal? Fica { get; set; }
        [Display(Name = "Medical")]
        public decimal? Medical { get; set; }
        [Display(Name = "Ret Emp")]
        public decimal? RetirementPay { get; set; }
        [Display(Name = "Ret ER")]
        public decimal? RetirementBenefitsEmployer { get; set; }
        [Display(Name = "Net Pay")]
        public decimal? NetPay { get; set; }
        [Display(Name = "Hours Worked")]
        public decimal? HoursWorked { get; set; }

        [Display(Name = "Deferred Gross")]

        public decimal? DeferredGross { get; set; }

        [Display(Name = "Taxable")]

        public decimal? Taxable { get; set; }
    }
}