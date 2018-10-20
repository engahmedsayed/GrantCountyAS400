using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasspecialAssessmentsTaxReceivableMaster
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? DistrictClass { get; set; }
        public decimal? DistrictSequenceNumber { get; set; }
        public decimal? TaxYear { get; set; }
        public string Filler { get; set; }
        public DateTime? DueDateCymmdd { get; set; }
        public decimal? AssessmentAmount { get; set; }
        public decimal? AssessmentSupplement { get; set; }
        public decimal? AssessmentPaid { get; set; }
        public decimal? PenaltyAmount { get; set; }
        public decimal? PenaltyPaid { get; set; }
        public decimal? InterestPaid { get; set; }
        public decimal? FeeAmount { get; set; }
        public decimal? FeeSupplement { get; set; }
        public decimal? FeePaid { get; set; }
        public decimal? BasisAmount1Units { get; set; }
        public decimal? BasisAmount2 { get; set; }
        public decimal? BasisAmount3 { get; set; }
        public decimal? BasisAmount4 { get; set; }
        public decimal? BasisAmount5 { get; set; }
        public string BillWRPflag { get; set; }
        public string TaxpayerCode { get; set; }
    }
}
