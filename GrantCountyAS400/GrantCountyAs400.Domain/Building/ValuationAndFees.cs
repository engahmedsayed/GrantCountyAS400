using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class ValuationAndFees
    {
        public decimal? ExtendedAmountTotal { get; }

        public decimal? ExtendedValue { get;}

        public decimal? AssignStructNanNodFees { get; }

        public decimal? AssignPlanReviewFee { get;}

        public decimal? AssignPlumbingFees { get;}

        public decimal? AssignMechanicalFees { get;}

        public decimal? AssignGradingFees { get; }

        public decimal? AssignDemolitionFees { get;}

        public decimal? AssignBidPermitFee { get;}

        public decimal? AssignBidPlanReview { get;}

        public decimal? AssignBidBuildingCodeFee { get;}

        public decimal? AssignFireMarshalFees { get; }

        public decimal? AssignOtherFees { get;}

        public ValuationAndFees(decimal? extendedAmountTotal, decimal? extendedValue, decimal? assignStructNanNodFees,
                                decimal? assignPlanReviewFee, decimal? assignPlumbingFees, decimal? assignMechanicalFees,
                                decimal? assignGradingFees, decimal? assignDemolitionFees, decimal? assignBidPermitFee, 
                                decimal? assignBidPlanReview, decimal? assignBidBuildingCodeFee, decimal? assignFireMarshalFees, 
                                decimal? assignOtherFees)
        {
            ExtendedAmountTotal = extendedAmountTotal;
            ExtendedValue = extendedValue;
            AssignStructNanNodFees = assignStructNanNodFees;
            AssignPlanReviewFee = assignPlanReviewFee;
            AssignPlumbingFees = assignPlumbingFees;
            AssignMechanicalFees = assignMechanicalFees;
            AssignGradingFees = assignGradingFees;
            AssignDemolitionFees = assignDemolitionFees;
            AssignBidPermitFee = assignBidPermitFee;
            AssignBidPlanReview = assignBidPlanReview;
            AssignBidBuildingCodeFee = assignBidBuildingCodeFee;
            AssignFireMarshalFees = assignFireMarshalFees;
            AssignOtherFees = assignOtherFees;
        }
    }
}
