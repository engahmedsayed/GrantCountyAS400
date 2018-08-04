using System;

namespace GrantCountyAs400.Domain.Assessment
{
    public class ChildParentParcel
    {
        public int Id { get; }
        public string RecordCode { get; }
        public decimal ParentParcel { get; }
        public decimal ChildParcel { get; }
        public DateTime? SegCombDate { get; }
        public DateTime? EffectiveDate { get; }
        public string AssociatedParcelTax { get; }
        public string ReferenceNumber { get; }
        public string LegalDocumentType { get; }

        public ChildParentParcel(int id, string recordCode, decimal parentParcel, decimal childParcel, DateTime? segCombDate, DateTime? effectiveDate,
            string legalDocumentType, string referenceNumber)
        {
            Id = id;
            ParentParcel = parentParcel;
            ChildParcel = childParcel;
            LegalDocumentType = legalDocumentType;
            SegCombDate = segCombDate;
            EffectiveDate = effectiveDate;
            ReferenceNumber = referenceNumber;
            RecordCode = recordCode;
        }
    }
}