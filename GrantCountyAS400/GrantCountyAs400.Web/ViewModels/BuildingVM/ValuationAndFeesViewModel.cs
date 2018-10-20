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

        [Display(Name ="Assign Valuation")]
        public decimal? ExtendedValue { get; set; }

        [Display(Name = "Assign Strict/Man/Mod Fees")]
        public decimal? AssignStructNanNodFees { get; set; }

        [Display(Name ="Assign Plan Review Fee")]
        public decimal? AssignPlanReviewFee { get; set; }

        [Display(Name ="Assign Plumbing Fees")]
        public decimal? AssignPlumbingFees { get; set; }

        [Display(Name ="Assign Mechanical Fees")]
        public decimal? AssignMechanicalFees { get; set; }

        [Display(Name ="Assign Bid Permit Fees")]
        public decimal? AssignBidPermitFee { get; set; }

        [Display(Name ="Assign Bid Plan Review")]
        public decimal? AssignBidPlanReview { get; set; }

        [Display(Name = "Assign State Building Code Fee")]
        public decimal? AssignBidBuildingCodeFee { get; set; }

        [Display(Name ="Assign Other Fees")]
        public decimal? AssignOtherFees { get; set; }
    }
}
