using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingConditionViewModel
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
        [Display(Name = "Addendum #")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal AddendumNumber { get; set; }
        [Display(Name = "Dept")]
        public string ConditionDepartmentCode { get; set; }
        [Display(Name = "Seq #")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal? ConditionSequence { get; set; }
        [Display(Name = "Condition Line 1")]
        public string ConditionLine1 { get; set; }
        [Display(Name = "Condition Line 2")]
        public string ConditionLine2 { get; set; }
        [Display(Name = "Condition Line 3")]
        public string ConditionLine3 { get; set; }
        [Display(Name = "Condition Line 4")]
        public string ConditionLine4 { get; set; }
        [Display(Name = "Condition Line 5")]
        public string ConditionLine5 { get; set; }
        [Display(Name = "Condition Line 6")]
        public string ConditionLine6 { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Entry Date")]
        public DateTime? EntryDate { get; set; }
        [Display(Name = "Entered By")]
        public string EnteredByUser { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Removal Entered Date")]
        public DateTime? DateRemoved { get; set; }
        [Display(Name = "Removed By")]
        public string RemovedByUser { get; set; }
        [Display(Name = "Removal Authorized By")]
        public string RemoveAuthorizedBy { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Removal Authorized Date")]
        public DateTime? RemoveAuthorizedDate { get; set; }
        [Display(Name = "Comment")]
        public string ReasonRemoved { get; set; }
    }
}