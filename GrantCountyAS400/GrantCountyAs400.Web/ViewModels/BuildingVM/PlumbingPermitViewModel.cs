using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class PlumbingPermitViewModel
    {
        [Display(Name = "Office Project Description")]
        public string OfficeProjectDescription { get; set; }
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