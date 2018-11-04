using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class ValuationAndFees
    {
        public decimal? ExtendedAmountTotal { get; }

        public List<decimal?> NumberOfUnits { get;}
        public List<decimal?> SequenceNumber { get; }

        public List<decimal?> UnitCharge { get; }

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

        public List<string> Description { get; }

        public List<decimal?> BaseFee { get; }

        public List<decimal?> FeeIncrement { get; }

        public List<string> MinMaxFlag { get; }
        public List<decimal?> ExtendedAmount { get;}

        public ValuationAndFees(decimal? extendedAmountTotal, decimal? extendedValue, decimal? assignStructNanNodFees,
                                decimal? assignPlanReviewFee, decimal? assignPlumbingFees, decimal? assignMechanicalFees,
                                decimal? assignGradingFees, decimal? assignDemolitionFees, decimal? assignBidPermitFee, 
                                decimal? assignBidPlanReview, decimal? assignBidBuildingCodeFee, decimal? assignFireMarshalFees, 
                                decimal? assignOtherFees,List<decimal?> sequenceNumber,List<string> description,List<decimal?> baseFee,
                                List<decimal?> feeIncrement,List<string> minMaxFlag,List<decimal?> numberOfUnits,List<decimal?> unitCharge,List<decimal?> extendedAmount)
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
            SequenceNumber = sequenceNumber;
            Description = description;
            BaseFee = baseFee;
            FeeIncrement = feeIncrement;
            MinMaxFlag = minMaxFlag;
            NumberOfUnits = numberOfUnits;
            UnitCharge = unitCharge;
            ExtendedAmount = extendedAmount;

        }
    }
}
