using System;

namespace GrantCountyAs400.Domain.Assessment
{
    public class ChildParentParcelDetails
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
        public string TaxPayerName { get; }
        public string TitleOwnerName { get; }
        public string TaxStatus { get; set; }
        public string Description1 { get; }
        public string Description2 { get; }
        public string Description3 { get; }
        public string Description4 { get; }
        public string Description5 { get; }

        public ChildParentParcelDetails(int id, string recordCode, decimal parentParcel, decimal childParcel, DateTime? segCombDate, DateTime? effectiveDate,
            string legalDocumentType, string referenceNumber, string taxPayerName, string titleOwnerName, string taxStatus, string description1,
            string description2, string description3, string description4, string description5)
        {
            Id = id;
            ParentParcel = parentParcel;
            ChildParcel = childParcel;
            LegalDocumentType = legalDocumentType;
            SegCombDate = segCombDate;
            EffectiveDate = effectiveDate;
            ReferenceNumber = referenceNumber;
            RecordCode = recordCode;
            TaxPayerName = taxPayerName;
            TitleOwnerName = titleOwnerName;
            TaxStatus = taxStatus;
            Description1 = description1;
            Description2 = description2;
            Description3 = description3;
            Description4 = description4;
            Description5 = description5;
        }
    }
}