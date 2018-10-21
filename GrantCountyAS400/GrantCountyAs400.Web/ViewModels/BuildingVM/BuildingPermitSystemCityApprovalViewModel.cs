using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        
        public string JurisdictionCode { get; }

        public string ShortDepartmentName { get; }

        [Display(Name = "What city is this inside?")]
        public string JurisdictionDisplay => JurisdictionCode + ShortDepartmentName;

        [Display(Name = "City approval for zoning, etc?")]
        public string ZoniongApproval { get; }

        [Display(Name = "Does this approval include utilitiez?")]
        public string UtilitiesApproval { get; }
    }
}
