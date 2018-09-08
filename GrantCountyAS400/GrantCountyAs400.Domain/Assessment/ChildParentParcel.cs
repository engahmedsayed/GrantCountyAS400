using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment
{
    public class ParentParcel
    {
        public decimal ParcelNumber { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerName { get; }
        public IEnumerable<ChildParcel> Children { get; }

        public ParentParcel(decimal parentParcel, string taxPayerName, string titleOwnerName)
        {
            ParcelNumber = parentParcel;
            TaxPayerName = taxPayerName;
            TitleOwnerName = titleOwnerName;
        }

        public ParentParcel(decimal parentParcel, string taxPayerName, string titleOwnerName, IEnumerable<ChildParcel> children)
            : this(parentParcel, taxPayerName, titleOwnerName)
        {
            Children = children;
        }
    }

    public class ChildParcel
    {
        public int Id { get; }
        public decimal ParentParcelNumber { get; }
        public decimal ParcelNumber { get; }
        public string RecordCode { get; }
        public DateTime? SegCombDate { get; }
        public DateTime? EffectiveDate { get; }
        public string ReferenceNumber { get; }
        public string LegalDocumentType { get; }

        public ChildParcel(int id, decimal parentParcel, decimal childParcel, string recordCode, DateTime? segCombDate, DateTime? effectiveDate,
            string referenceNumber, string legalDocumentType)
        {
            Id = id;
            ParentParcelNumber = parentParcel;
            ParcelNumber = childParcel;
            LegalDocumentType = legalDocumentType;
            SegCombDate = segCombDate;
            EffectiveDate = effectiveDate;
            ReferenceNumber = referenceNumber;
            RecordCode = recordCode;
        }
    }
}