using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class ReceiptHeaderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Jurs")]
        public string JurisdictionCode { get; set; }
        [Display(Name = "Dept")]
        public string DepartmentCode { get; set; }
        [Display(Name = "Year")]
        public int ApplicationYear { get; set; }
        [Display(Name = "App #")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal ApplicationNumber { get; set; }
        [Display(Name = "Add #")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal AddendumNumber { get; set; }
        public decimal? ReceiptNumber { get; set; }
        [Display(Name = "Type")]
        public string ReceiptType { get; set; }
        public string ReceiptName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Receipt Date")]
        public DateTime? ReceiptDate { get; set; }
        [Display(Name = "Check")]
        public decimal? CheckAmount { get; set; }
        [Display(Name = "Cash")]
        public decimal? CashAmount { get; set; }
        [Display(Name = "Other")]
        public decimal? OtherAmount { get; set; }
        [Display(Name = "Check #")]
        public string PaidByCheckNumber { get; set; }
        [Display(Name = "Change")]
        public decimal? ChangeAmount { get; set; }
        [Display(Name = "Name")]
        public string ReceiptComment { get; set; }
        public string UserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ChangeDate { get; set; }
        public decimal? ChangeTime { get; set; }
        public List<ApplicationReceiptInfoViewModel> ReceiptInfos { get; set; }

        [Display(Name = "Total Receipt")]
        public decimal? TotalReceipt => CheckAmount + CashAmount + OtherAmount + CheckAmount;
        [Display(Name = "Receipt #")]
        public string ReceiptNumberDisplay => ReceiptNumber?.ToString();
    }

    public class ApplicationReceiptInfoViewModel
    {
        [Display(Name = "Fee Distribution Description")]
        public string FeeDistributionDescription { get; set; }
        [Display(Name = "Fee Distribution Category ")]
        public decimal? FeeDistributionCategory { get; set; }
        [Display(Name = "Amount")]
        public decimal? Amount { get; set; }
    }
}