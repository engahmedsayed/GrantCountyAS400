using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class ValuationFeeDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }


        [Display(Name = "Total Valuation")]
        public decimal? ExtendedValue { get; set; }

        [Display(Name = "Total Square Feet")]
        public decimal? SquareFeet { get; set; }

        public List<ValuationFeeDetailsItemViewModel> Items { get; set; }


    }

    public class ValuationFeeDetailsItemViewModel
    {
        [Display(Name = "Seq")]
        public int? SequenceNumber { get; set; }

        [Display(Name ="Comp Desc")]
        public string ComponentDescription { get; set; }

        [Display(Name ="Occup Type")]
        public string OccupantType { get; set; }

        [Display(Name ="# of occup")]
        public decimal? NumberOfOccupants { get; set; }

        [Display(Name ="Code")]
        [DisplayFormat(DataFormatString = "{0}")]
        public decimal? TableNumberSectLineSeq { get; set; }

        [Display(Name ="Square Feet")]
        [DisplayFormat(DataFormatString = "{0}")]
        public decimal? SquareFeet { get; set; }

        [Display(Name ="Section Desc")]
        public string SectionDescription { get; set; }

        [Display(Name ="Construction Type")]
        public string ConstructionTypeDescription { get; set; }

        [Display(Name ="Cost/Sq Feet")]
        public decimal? Cost { get; set; }

        [Display(Name ="Extended Amt")]
        public decimal? ExtendedValue { get; set; }
    }
}
