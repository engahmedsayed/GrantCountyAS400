using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class OtherPermitDetailViewModel
    {
        [Display(Name ="Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        public string FireDistrictCode { get; set; }
        public string LongFireDistrictName { get; set; }

        [Display(Name = "Fire Dist")]
        public string FireDistrictDisplay => FireDistrictCode + LongFireDistrictName;

        [Display(Name ="Fire Flow: Provided")]
        public string FireFlowAlreadyProvided { get; set; }
        [Display(Name ="Addl Req?")]
        public string AdditionalFireFlowRequired { get; set; }
        [Display(Name ="How Much?")]
        public string AmountOFFireFlowRequired { get; set; }
        [Display(Name ="Bldg Setbacks")]
        public decimal? BldgDeptSetback { get; set; }
        [Display(Name ="FM Setbacks")]
        public decimal? FireMarshalSetback { get; set; }

        public bool IsConditionExistInApcn { get; set; }
        [Display(Name ="Conditions")]
        public string ConditionExistInApcnDisplay => IsConditionExistInApcn ? "Condition Exist" : "";
        
        public bool IsConditionExistInApin { get; set; }

        [Display(Name ="Inspections")]
        public string ConditionExistInApinDisplay => IsConditionExistInApin ? "Inspection Exist" : "";
        [Display(Name ="Total Valuation")]
        public decimal? ExtendedValue { get; set; }
        
        public PermitApprovedInfoViewModel BldgDept { get; set; }
        public PermitApprovedInfoViewModel FireMarshal { get; set; }
        
    }
}
