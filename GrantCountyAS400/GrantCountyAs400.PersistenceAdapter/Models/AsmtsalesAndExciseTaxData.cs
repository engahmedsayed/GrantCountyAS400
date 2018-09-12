using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtsalesAndExciseTaxData
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? SeqNumber { get; set; }
        public string Filler01 { get; set; }
        public decimal? TaxYear { get; set; }
        public decimal? RPsalesAmount { get; set; }
        public decimal? PPsalesAmount { get; set; }
        public decimal? AssessedValue { get; set; }
        public string Filler02 { get; set; }
        public decimal? Acres { get; set; }
        public string LegalDocumentType { get; set; }
        public string MultipleParcelSale { get; set; }
        public string IncorporatedArea { get; set; }
        public string RevaluationPhase { get; set; }
        public decimal? SaleRejectionCode { get; set; }
        public string Comment { get; set; }
        public decimal? PersPropParcel { get; set; }
        public decimal? LandUseCode { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public decimal? AffidavitNumber { get; set; }
        public string AffidavitNumberExtension { get; set; }
    }
}
