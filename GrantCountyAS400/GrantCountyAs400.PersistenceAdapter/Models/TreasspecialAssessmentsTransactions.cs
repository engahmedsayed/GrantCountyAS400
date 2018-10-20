using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasspecialAssessmentsTransactions
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? DistrictClass { get; set; }
        public decimal? DistrictSequenceNumber { get; set; }
        public decimal? TaxYear { get; set; }
        public DateTime? TranactionDate { get; set; }
        public string Filler01 { get; set; }
        public string ReceiptExtension { get; set; }
        public string TransactionType { get; set; }
        public decimal? AssessmentPaid { get; set; }
        public decimal? PenaltyPaid { get; set; }
        public decimal? InterestPaid { get; set; }
        public decimal? FeePaid { get; set; }
        public string ChangeReasonCode { get; set; }
        public decimal? ChangeBasisAmount { get; set; }
        public string ChangeId { get; set; }
        public decimal? ReceiptTransactionNumber { get; set; }
    }
}
