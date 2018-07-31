using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class LegalDescriptionMapper
    {
        internal static LegalDescription Map(AsmtfullLegalDescription record, ASMTValueMasterNameView namesRecord) =>
            new LegalDescription(record.Id, record.ParcelNumber.Value, record.Descrtiption, namesRecord.TaxpayerName?.Trim(),
                namesRecord.TitleOwnerName?.Trim(), namesRecord.ContractHolderName?.Trim());

        internal static LegalDescriptionDetails Map(AsmtfullLegalDescription legalRecord, AsmtrealPropertyAssessedValueMaster masterRecord) =>
            new LegalDescriptionDetails(legalRecord.Id, legalRecord.ParcelNumber.Value, legalRecord.Descrtiption,
                masterRecord.Description1, masterRecord.Description2, masterRecord.Description3, masterRecord.Description4,
                masterRecord.Description5, masterRecord.TaxStatus, masterRecord.ChangeId, masterRecord.ChangeDate.Value);
    }
}