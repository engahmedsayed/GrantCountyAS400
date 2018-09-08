using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class ChildParentParcelMapper
    {
        internal static ChildParcel Map(AsmtparentChildRelationshipsChanged record) =>
            new ChildParcel(record.Id, record.ParentParcel.Value, record.ChildParcel.Value, record.RecordCode, record.SegCombDate,
                record.EffectiveDate, record.ReferenceNumber, record.LegalDocumentType);

        internal static ChildParcelDetails Map(AsmtparentChildRelationshipsChanged record, ASMTValueMasterNameView namesRecord,
                                               AsmtrealPropertyAssessedValueMaster masterRecord,
                                               IEnumerable<AsmtparentChildRelationshipsChanged> children) =>
           new ChildParcelDetails(record.Id, record.RecordCode, record.ParentParcel.Value, record.ChildParcel.Value, record.SegCombDate,
               record.EffectiveDate, record.LegalDocumentType, record.ReferenceNumber, namesRecord.TaxpayerName.Trim(), namesRecord.TitleOwnerName.Trim(),
               masterRecord.TaxStatus, masterRecord.Description1.Trim(), masterRecord.Description2.Trim(), masterRecord.Description3.Trim(),
               masterRecord.Description4.Trim(), masterRecord.Description5.Trim(), children.Select(Map));
    }
}