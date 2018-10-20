using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class StructurePermitDetailViewModel
    {
        [Display(Name ="Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name ="Res(R), Ag(A), Comm(C) or Other(O)?")]
        public string ResAgCommOther { get; set; }

        [Display(Name ="# Bedrooms?")]
        public decimal? NumberOfBedrooms { get; set; }

        [Display(Name ="# Bathrooms?")]
        public decimal? NumberOfBathrooms { get; set; }

        [Display(Name ="# Units (multi-family)?")]
        public decimal? NumberOfUnits { get; set; }

        [Display(Name ="Bldg heated?")]
        public string Heated { get; set; }

        [Display(Name ="Heat Source")]
        public string HeatSourceDescription { get; set; }

        [Display(Name ="Prscrpt Rvw?")]
        public string PrescriptiveReviewDone { get; set; }

        [Display(Name ="Wattsun Rvw?")]
        public string WattsunRunReviewDone { get; set; }

        [Display(Name ="NREC Rcvd?")]
        public string NRECReceived { get; set; }
        
        public string PlansAnalystReviewDone { get; set; }

        public string PlansAnalystReviewDescription { get; set; }

        [Display(Name = "Plans analyst review?")]
        public string PlansAnalystReviewDoneDisplay => PlansAnalystReviewDone + PlansAnalystReviewDescription;

        public string SprinklerSystemRequired { get; set; }

        public string SprinklerSyustemDescription { get; set; }

        [Display(Name = "Sprinkler system req?")]
        public string SprinklerSystemRequiredDisplay => SprinklerSystemRequired + SprinklerSyustemDescription;

        
        public string AlarmSystemRequired { get; set; }

        public string AlarmSystemDescription { get; set; }

        [Display(Name = "Alarm system req?")]
        public string AlarmSystemRequiredDisplay => AlarmSystemRequired + AlarmSystemDescription;

        public string SpecialInspectionRequired { get; set; }

        public string SpecialInspectionDescription { get; set; }

        [Display(Name ="Spec Insp by other?")]
        public string SpecialInspectionRequiredDisplay => SpecialInspectionRequired + SpecialInspectionDescription;

        [Display(Name ="Plumbing Included in permit?")]
        public string PermitIncludePlumbing { get; set; }

        [Display(Name ="Mechanical included in permit?")]
        public string PermitIncludeMechanical { get; set; }

        public string FireDistrictCode { get; set; }

        public string LongFireDistrictName { get; set; }

        [Display(Name ="Fire Dist")]
        public string FireDistrictCodeDisplay => FireDistrictCode + " " + LongFireDistrictName;

        [Display(Name ="Fire Flow: Provided")]
        public string FireFlowAlreadyProvided { get; set; }

        [Display(Name ="Addl. Req?")]
        public string AdditionalFireFlowRequired { get; set; }

        [Display(Name ="How much?")]
        public string AmountOfFireFlowRequired { get; set; }

        [Display(Name ="Bldg Setbacks")]
        public decimal? BldgDeptSetback { get; set; }

        [Display(Name ="FM Setbacks")]
        public decimal? FireMarshalSetback { get; set; }
        public bool IsConditionExistInApcn { get; set; }
        [Display(Name = "Conditions")]
        public string ConditionExistInApcnDisplay => IsConditionExistInApcn ? "Condition Exist" : "";

        public bool IsConditionExistInApin { get; set; }

        [Display(Name = "Inspections")]
        public string ConditionExistInApinDisplay => IsConditionExistInApin ? "Inspection Exist" : "";

        [Display(Name = "Total Valuation")]
        public decimal? ExtendedValue { get; set; }

        public PermitApprovedInfoViewModel BldgDept { get; set; }
        public PermitApprovedInfoViewModel FireMarshal { get; set; }
    }
}
