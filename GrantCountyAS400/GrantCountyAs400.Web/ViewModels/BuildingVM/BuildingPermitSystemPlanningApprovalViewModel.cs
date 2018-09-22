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

        public decimal? SideFlankingSetback { get; set; }

        public decimal? SidePropertySetback { get; set; }

        public decimal? BackPropertySetback { get; set; }

        public string FloodZone { get; set; }
        public string FloodZoneMapNumber { get; set; }
        public string LUPermitRequired { get; set; }

        public string Comments { get; set; }

        public string ApprovedBy { get; set; }

        public string UserID { get; set; }

        public DateTime? ChangeDate { get; set; }
    }
}
