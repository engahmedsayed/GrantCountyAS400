using GrantCountyAs400.Domain.Accounting;
using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class ContractViewModel
    {
        public int Id { get; set; }
        public decimal SSNumber { get; set; }
        public decimal PersonNumber { get; set; }

        [Display(Name = "Organization")]
        public OrganizationViewModel Organization { get; set; }

        [Display(Name = "Hire")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        [Display(Name = "Term")]
        [DataType(DataType.Date)]
        public DateTime? TerminationDate { get; set; }

        [Display(Name = "S")]
        public string Status { get { return TerminationDate.HasValue ? "T" : ""; } }

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

        [Display(Name = "Job")]
        public string JobCode { get; set; }

        [Display(Name = "P")]
        public string CountDisplay => Count == 1 ? "P" : string.Empty;
    }
}