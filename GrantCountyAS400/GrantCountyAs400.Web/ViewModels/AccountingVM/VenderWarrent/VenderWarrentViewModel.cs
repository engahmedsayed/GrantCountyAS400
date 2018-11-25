using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM.VenderWarrent
{
    public class VenderWarrentViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Vendor")]
        public string Vendor { get; set; }
        [Display(Name = "Warrant Number")]
        public int WarrantNumber { get; set; }
        [Display(Name = "Check Number")]
        public int? CheckNumber { get; set; }
        [Display(Name = "Warrant Date")]
        [DataType(DataType.Date)]
        public DateTime? WarrantDate { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Display(Name = "Document")]
        public string Ponumber { get; set; }
        public string Fund { get; set; }
        public string Department { get; set; }
        public string Program { get; set; }
        public string Project { get; set; }
        public string Base { get; set; }
        [Display(Name = "Invoice #")]
        public string Invoice { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Final Payment")]
        public string FillType { get; set; }
        [Display(Name = "FY")]
        public int? FiscalYear { get; set; }
        [Display(Name = "Amount")]
        public decimal? Amount { get; set; }
        [Display(Name = "Pay Date")]
        [DataType(DataType.Date)]
        public DateTime? PayDate { get; set; }
        [Display(Name = "Combine?")]
        public string Combine { get; set; }
        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date)]
        public DateTime? InvoiceDate { get; set; }
        public string Name { get; set; }

        [Display(Name = "Account")]
        public string AccountDisplay => $"{Fund}-{Department}-{Program}-{Project}-{Base}";
    }
}