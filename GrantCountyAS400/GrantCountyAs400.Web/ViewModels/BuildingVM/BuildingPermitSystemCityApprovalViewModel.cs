using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemCityApprovalViewModel
    {
        [Display(Name = "App Prj Dsc")]
        public string ApplicantProjectDescription { get; set; }

        [Display(Name = "Project Notes")]
        public string Comments { get; set; }

        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }

        [Display(Name = "Chg User")]
        public string UserID { get; set; }

        [Display(Name = "Chg Date")]
        [DataType(DataType.Date)]
        public DateTime? ChangeDate { get; set; }

        public string JurisdictionCode { get; set; }

        public string ShortDepartmentName { get; set; }

        [Display(Name = "What city is this inside?")]
        public string CityCode { get; set; }

        [Display(Name = "City approval for zoning, etc?")]
        public string ZoniongApproval { get; set; }

        [Display(Name = "Does this approval include utilitiez?")]
        public string UtilitiesApproval { get; set; }
    }
}