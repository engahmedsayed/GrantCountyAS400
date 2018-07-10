using GrantCountyAs400.Domain.Accounting;
using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class PersonnelWithContractFullDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "SSN")]
        [DisplayFormat(DataFormatString = "{0:###-##-####}")]
        public decimal SSNumber { get; set; }

        [Display(Name = "Employee #")]
        [DisplayFormat(DataFormatString = "{0:00000}")]
        public decimal PersonNumber { get; set; }

        [Display(Name = "Organization")]
        public OrganizationViewModel Organization { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Termination Date")]
        [DataType(DataType.Date)]
        public DateTime? TerminationDate { get; set; }

        [Display(Name = "Status")]
        public string Status { get { return TerminationDate.HasValue ? "Terminated" : ""; } }

        public int Count { get; set; }

        [Display(Name = "Pay Code")]
        public PayCode PayCode { get; set; }

        [Display(Name = "Pay Rate")]
        public decimal Rate { get; set; }

        [Display(Name = "Table")]
        public string Table { get; set; }

        [Display(Name = "Grade")]
        public string Grade { get; set; }

        [Display(Name = "Step")]
        public string Step { get; set; }

        [Display(Name = "Position Code")]
        public string JobCode { get; set; }

        [Display(Name = "P")]
        public string CountDisplay => Count == 1 ? "P" : string.Empty;

        [Display(Name ="Table/Range/Step")]
        public string TableRangeStepDisplay => $"{Table}/Range/{Step}";

        [Display(Name = "Longevity")]
        public decimal EmpLongevityAmount { get; set; }

        [Display(Name = "Employee Type")]
        [DisplayFormat(DataFormatString = "{0:00}")]
        public decimal Type { get; set; }
        [Display(Name = "Positions Filled")]
        public decimal EmpFilled { get; set; }
        [Display(Name = "Retirement - Lock")]
        public decimal RetirementLock { get; set; }
        [Display(Name = "Retirement - Plan")]
        public decimal RetirementCode { get; set; }
        [Display(Name = "Retirement - Account Number")]
        public decimal RetirementNumber { get; set; }
        [Display(Name = "Service Date")]
        [DataType(DataType.Date)]
        public DateTime? ServiceDate { get; set; }
        [Display(Name = "Anniversary Date")]
        [DataType(DataType.Date)]
        public DateTime? AnniversaryDate { get; set; }        
        [Display(Name = "Termination Type")]
        public string TerminationType { get; set; }
        [Display(Name = "Merit Status")]
        public string MeritStatus { get; set; }
        [Display(Name = "EEO Function")]
        public string EmpEeofunction { get; set; }
        [Display(Name = "Position Title")]
        public string JobTitle{ get; set; }
    }
}