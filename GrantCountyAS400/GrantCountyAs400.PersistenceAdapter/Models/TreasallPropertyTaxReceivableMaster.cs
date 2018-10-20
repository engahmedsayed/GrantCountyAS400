using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasallPropertyTaxReceivableMaster
    {
        public int Id { get; set; }
        public string RecCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? ParcelExtension { get; set; }
        public decimal? TaxYear { get; set; }
        public string Filler { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? NetSupplementsLessCancels { get; set; }
        public decimal? TaxPaid { get; set; }
        public decimal? Fpamount { get; set; }
        public decimal? Fpsupplement { get; set; }
        public decimal? Fppaid { get; set; }
        public decimal? Lpamount { get; set; }
        public decimal? Lppaid { get; set; }
        public decimal? InterestPaid { get; set; }
        public string LienIndicators { get; set; }
        public decimal? AssessedValue { get; set; }
        public decimal? UseCode { get; set; }
        public decimal? FpfeeAmount { get; set; }
        public decimal? FpfeePaid { get; set; }
        public string TaxCode { get; set; }
        public string SrCitCode { get; set; }
        public decimal? FilingPenalty { get; set; }
        public decimal? SpecialAssessments { get; set; }
        public string TaxpayerCode { get; set; }
    }
}
