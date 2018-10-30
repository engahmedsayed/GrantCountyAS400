using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class ValuationAndFeesViewModel
    {
        [Display(Name ="Bid Amount")]
        public decimal? ExtendedAmountTotal { get; set; }

        public decimal? NumberOfUnits { get; set; }

        public decimal? UnitCharge { get; set; }

        public decimal? SequenceNumber { get; set; }

        public string FeeDescription { get; set; }

        public string Description { get; set; }

        public decimal? BaseFee { get; set; }

        public decimal? FeeIncrement { get; set; }

        public string MinMaxFlag { get; set; }

        [Display(Name ="Assign Valuation")]
        public decimal? ExtendedValue { get; set; }

        [Display(Name = "Assign Struct/Man/Mod Fees")]
        public decimal? AssignStructNanNodFees { get; set; }

        [Display(Name ="Assign Plan Review Fee")]
        public decimal? AssignPlanReviewFee { get; set; }

        [Display(Name ="Assign Plumbing Fees")]
        public decimal? AssignPlumbingFees { get; set; }

        [Display(Name ="Assign Mechanical Fees")]
        public decimal? AssignMechanicalFees { get; set; }

        [Display(Name = "Assign Grading Fees")]
        public decimal? AssignGradingFees { get; set; }

        [Display(Name = "Assign Demolition Fees")]
        public decimal? AssignDemolitionFees { get; set; }

        [Display(Name ="Assign Bid Permit Fees")]
        public decimal? AssignBidPermitFee { get; set; }

        [Display(Name ="Assign Bid Plan Review")]
        public decimal? AssignBidPlanReview { get; set; }

        [Display(Name = "Assign State Building Code Fee")]
        public decimal? AssignBidBuildingCodeFee { get; set; }

        [Display(Name = "Assign Fire Marshal Fees")]
        public decimal? AssignFireMarshalFees { get; set; }

        [Display(Name ="Assign Other Fees")]
        public decimal? AssignOtherFees { get; set; }

        public int Id { get; set; }
    }
}
