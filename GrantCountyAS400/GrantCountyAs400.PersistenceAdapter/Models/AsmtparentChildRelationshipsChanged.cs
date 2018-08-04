using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtparentChildRelationshipsChanged
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParentParcel { get; set; }
        public decimal? ChildParcel { get; set; }
        public DateTime? SegCombDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string AssociatedParcelTax { get; set; }
        public string ReferenceNumber { get; set; }
        public string LegalDocumentType { get; set; }
    }
}
