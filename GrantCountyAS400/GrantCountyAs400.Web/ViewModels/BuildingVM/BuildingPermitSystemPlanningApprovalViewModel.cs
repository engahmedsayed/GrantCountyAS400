using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemPlanningApprovalViewModel
    {
        [Display(Name ="App Prj Dsc")]
        public string ApplicantProjectDescription { get; set; }

        [Display(Name ="Zoning Classification")]
        public string ZoneCode { get; set; }

        [Display(Name ="Front Property Line Setback")]
        public decimal? FrontPropertySetback { get; set; }

        [Display(Name ="Side or Flanking Street Setback")]
        public decimal? SideFlankingSetback { get; set; }

        [Display(Name ="Side Property Line Setback")]
        public decimal? SidePropertySetback { get; set; }

        [Display(Name ="Back Property Line Setback")]
        public decimal? BackPropertySetback { get; set; }

        [Display(Name ="Flood Zone")]
        public string FloodZone { get; set; }
        [Display(Name ="Flood Zone Map #")]
        public string FloodZoneMapNumber { get; set; }
        [Display(Name ="Requires Land Use Permit? (Y/N)")]
        public string LUPermitRequired { get; set; }

        [Display(Name ="Project Notes")]
        public string Comments { get; set; }

        [Display(Name ="Approved By")]
        public string ApprovedBy { get; set; }

        [Display(Name ="Chg User")]
        public string UserID { get; set; }

        [Display(Name ="Chg Date")]
        public DateTime? ChangeDate { get; set; }
    }
}
