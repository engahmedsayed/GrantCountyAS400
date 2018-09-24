using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class MechanicalPermitDetailViewModel
    {
        [Display(Name = "Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name = "NREC Received")]
        public string NrecReceived { get; set; }

        public string FireDistrictCode { get; set; }

        public string LongFireDistrictName { get; set; }

        [Display(Name = "Fire District")]
        public string FireDistrictDisplay => FireDistrictCode + LongFireDistrictName;

        [Display(Name = "Bldg Setbacks")]
        public string BldgDeptSetbacks { get; set; }

        [Display(Name = "Fn Setbacks?")]
        public string FireMarshallSetback { get; set; }

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
