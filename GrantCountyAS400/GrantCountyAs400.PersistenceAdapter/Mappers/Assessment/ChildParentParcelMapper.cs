using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class ChildParentParcelMapper
    {
        internal static ChildParentParcel Map(AsmtparentChildRelationshipsChanged record) =>
            new ChildParentParcel(record.Id, record.RecordCode, record.ParentParcel.Value, record.ChildParcel.Value, record.SegCombDate,
                record.EffectiveDate, record.LegalDocumentType, record.ReferenceNumber);

        internal static ChildParentParcelDetails Map(AsmtparentChildRelationshipsChanged record, ASMTValueMasterNameView namesRecord,
                                                     AsmtrealPropertyAssessedValueMaster masterRecord) =>
           new ChildParentParcelDetails(record.Id, record.RecordCode, record.ParentParcel.Value, record.ChildParcel.Value, record.SegCombDate,
               record.EffectiveDate, record.LegalDocumentType, record.ReferenceNumber, namesRecord.TaxpayerName.Trim(), namesRecord.TitleOwnerName.Trim(),
               masterRecord.TaxStatus, masterRecord.Description1.Trim(), masterRecord.Description2.Trim(), masterRecord.Description3.Trim(),
               masterRecord.Description4.Trim(), masterRecord.Description5.Trim());
    }
}