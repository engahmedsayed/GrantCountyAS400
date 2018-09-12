using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtlegalDocuments
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public DateTime? LegalInstrumentDate { get; set; }
        public decimal? SeqNumber { get; set; }
        public decimal? AuditorFileNumber { get; set; }
        public string Filler01 { get; set; }
        public string LegalDocumentType { get; set; }
        public decimal? ProbateNumber { get; set; }
        public string Comment { get; set; }
        public string PreviousOwnerSeller { get; set; }
        public string ChangeId { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Page { get; set; }
        public string PageExtension { get; set; }
        public decimal? AssocateParcelNumber { get; set; }
        public DateTime? ChangeDate { get; set; }
        public decimal? AffidavitNumber { get; set; }
        public string AffidavitNumberExtension { get; set; }
    }
}
