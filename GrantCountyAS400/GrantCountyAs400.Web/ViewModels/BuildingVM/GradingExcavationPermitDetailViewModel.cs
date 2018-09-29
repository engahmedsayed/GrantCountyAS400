using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class GradingExcavationPermitDetailViewModel
    {
        [Display(Name ="Application Project Description")]
        public string ApplicationProjectDescription { get; set; }

        [Display(Name ="Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name ="Cubic Yds")]
        public decimal? CubicYardsOfFill { get; set; }

        [Display(Name ="Percent of slope")]
        public decimal? PercentOfSlope { get; set; }

        [Display(Name ="Soil erosion control reqd?")]
        public string SoilErosionControlRequired { get; set; }

        [Display(Name ="Dust and track out control rcvd?")]
        public string DustAndTrackControlReceived { get; set; }

        [Display(Name ="Date Received")]
        public DateTime? DustAndTrackReceivedDate { get; set; }

        [Display(Name ="EngineerReceived?")]
        public string EngineeringReceived { get; set; }

        [Display(Name ="Date Received")]
        public DateTime? EngineeringReceivedDate { get; set; }

        public string FireDistrictCode { get; set; }

        public string ShortFireDistrictName { get; set; }
        [Display(Name = "Fire Dist")]
        public string FireDistrictCodeDisplay => FireDistrictCode + " " + ShortFireDistrictName;

        [Display(Name ="Fire flow already provided?")]
        public string FireFlowAlreadyProvided { get; set; }

        [Display(Name ="Addtl fire flow req?")]
        public string AdditionalFireFlowRequired { get; set; }

        [Display(Name ="How much?")]
        public string AmountOfFireFlowRequired { get; set; }

        [Display(Name ="Bldg Setbacks")]
        public decimal? BldgDeptSetback { get; set; }

        [Display(Name ="FN Setbacks")]
        public decimal? FireMarshalSetback { get; set; }

        public bool IsConditionExistInApcn { get; set; }
        [Display(Name = "Conditions")]
        public string ConditionExistInApcnDisplay => IsConditionExistInApcn ? "Condition Exist" : "";

        public bool IsConditionExistInApin { get; set; }
        [Display(Name = "Inspections")]
        public string ConditionExistInApinDisplay => IsConditionExistInApin ? "Inspection Exist" : "";

        public PermitApprovedInfoViewModel BldgDept { get; set; }
        public PermitApprovedInfoViewModel FireMarshal { get; set; }

    }
}
