using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class DemolitionPermitViewModel
    {
        [Display(Name = "Applicant Project Description")]
        public string ApplicantProjectDescription { get; set; }

        [Display(Name = "Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name = "Total Square Feet of the Building to be Demolished")]
        public decimal SquareFeet { get; set; }

        [Display(Name = "Dimensions")]
        public string Dimensions { get; set; }

        [Display(Name = "Building Description")]
        public string BuildingDescription { get; set; }

        [Display(Name = "Demolition Handout Requirements Provideded? ")]
        public string RequiredHandoutsProvided { get; set; }

        [Display(Name = "Date Provided")]
        public DateTime? DateProvided { get; set; }

        [Display(Name = "To Whom")]
        public string ToWhomProvided { get; set; }

        public string FireDistrictCode { get; set; }

        [Display(Name = "Building Setback")]
        public decimal BldgDeptSetback { get; set; }

        [Display(Name = "Fire Marshal Setback ")]
        public decimal FireMarshalSetback { get; set; }

        public string LongFireDistrictName { get; set; }
        public bool HasBuildingApplicationCondition { get; set; }
        public bool HasBuildingApplicationInspection { get; set; }
        public PermitApprovedInfoViewModel BldgDept { get; set; }
        public PermitApprovedInfoViewModel FireMarshal { get; set; }

        [Display(Name = "Fire District")]
        public string FireDistrictDisplay => $"{FireDistrictCode} - {LongFireDistrictName}";

        [Display(Name = "Add/Review/Remove Conditions")]
        public string ConditionsExist => (HasBuildingApplicationCondition) ? "Conditions Exist" : string.Empty;

        [Display(Name = "Add/Review/Remove Inspections")]
        public string InspectionsExist => (HasBuildingApplicationInspection) ? "Inspections Exist" : string.Empty;
    }
}