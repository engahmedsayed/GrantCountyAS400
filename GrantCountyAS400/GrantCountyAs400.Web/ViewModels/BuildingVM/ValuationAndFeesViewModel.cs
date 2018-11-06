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

        public List<string> Description { get; set; }

        public List<decimal?> NumberOfUnits { get; set; }

        public List<decimal?> UnitCharge { get; set; }

        public List<decimal?> SequenceNumber { get; set; }

        public List<decimal?>  ExtendedAmount { get; set; }



        public List<decimal?> BaseFee { get; set; }

        public List<decimal?> FeeIncrement { get; set; }

        public List<string> MinMaxFlag { get; set; }

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

        public decimal? AssignedValue { get; set; }

        public decimal? StateClassCode { get; set; }

        public DateTime? ProjectedExpireDate { get; set; }

        public string ExpiredByUser { get; set; }

        public DateTime? ActualExpireDate { get; set; }

        public int Id { get; set; }
    }
}
