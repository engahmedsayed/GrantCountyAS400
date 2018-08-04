using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtparentChildRelationshipsNew
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? FromParcel { get; set; }
        public decimal? ToParcel { get; set; }
        public DateTime? SegCombDate { get; set; }
        public string RelationshipParcel { get; set; }
        public string ReferenceNumber { get; set; }
        public string LegalDocumentType { get; set; }
    }
}
