using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingInspectionViewModel
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
        public string InspectionDepartmentCode { get; set; }
        [Display(Name = "Seq #")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal SequenceNumber { get; set; }
        [Display(Name = "Inspection Line 1")]
        public string InspectionLine1 { get; set; }
        [Display(Name = "Inspection Line 2")]
        public string InspectionLine2 { get; set; }
        [Display(Name = "Inspection Line 3")]
        public string InspectionLine3 { get; set; }
        [Display(Name = "Inspection Line 4")]
        public string InspectionLine4 { get; set; }
        [Display(Name = "Inspection Line 5")]
        public string InspectionLine5 { get; set; }
        [Display(Name = "Inspection Line 6")]
        public string InspectionLine6 { get; set; }
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
        [DataType(DataType.Date)]
        [Display(Name = "Inspection Entered Date")]
        public DateTime? DateInspectionEntered { get; set; }
        [Display(Name = "Inspection Entered By")]
        public string InspectionEnteredByUser { get; set; }
        [Display(Name = "Inspected By")]
        public string InspectedBy { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Inspection Date")]
        public DateTime? InspectionDate { get; set; }
    }
}