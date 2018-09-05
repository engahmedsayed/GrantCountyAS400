using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class RealPropertyMapper
    {
        internal static RealProperty Map(ASMTValueMasterNameView namesRecord, AsmttaxCodeArea codeArea) =>
            new RealProperty(namesRecord.Id, namesRecord.ParcelNumber.Value, namesRecord.TaxpayerName?.Trim(), namesRecord.TitleOwnerName?.Trim(),
                                 namesRecord.ContractHolderName?.Trim(), codeArea.TaxCodeArea.Value, codeArea.TaxCodeDesc.Trim());

        internal static RealPropertyDetails Map(ASMTValueMasterNameView namesRecord,
                                              AsmttaxCodeArea codeArea,
                                              AsmtrealPropertyAssessedValueMaster valueMaster,
                                              AsmtlandUseCodes landUserCode,
                                              AsmtzoneDescriptions zoneCode,
                                              AsmtnewConstruction construction,
                                              AsmtseniorCitizenHistory citizenHistory) =>
            new RealPropertyDetails(namesRecord.ParcelNumber.Value, namesRecord.TaxpayerCode, namesRecord.TaxpayerName?.Trim(),
                namesRecord.TitleOwnerCode, namesRecord.TitleOwnerName?.Trim(), namesRecord.ContractHolderCode, namesRecord.ContractHolderName?.Trim(),
                valueMaster.TaxYear.Value, valueMaster.NameChangeDate, valueMaster.NameChangeId, valueMaster.NameChangeReason, valueMaster.LoanNumber,
                valueMaster.PlatCode, valueMaster.PlatCodeType, valueMaster.BlockNumber, valueMaster.LotNumber, valueMaster.UnitNumber,
                valueMaster.DockNumber, valueMaster.Description1, valueMaster.Description2, valueMaster.Description3, valueMaster.Description4,
                valueMaster.Description5, codeArea.TaxCodeArea.Value, codeArea.TaxCodeDesc.Trim(), valueMaster.LandUseCode.Value,
                valueMaster.ChangeDate.Value, valueMaster.ChangeId, valueMaster.ChangeReasonCode, landUserCode?.UseCodeShortDesc, valueMaster.ZoneCode,
                zoneCode?.ZoneCodeDesc, valueMaster.TaxStatus, valueMaster.RevalutionPhase, valueMaster.UnimprovedLandAcres.Value,
                valueMaster.ImprovedLandAcers.Value, valueMaster.TimberAcers.Value, valueMaster.UnimprovedLandValue.Value,
                valueMaster.ImprovedLandValue.Value, valueMaster.TimberlandValue.Value, valueMaster.BuildingValue.Value,
                valueMaster.FmbuildingValue.Value, valueMaster.FmunimprovedLandValue.Value, valueMaster.FmimprovedLandValue.Value,
                valueMaster.FmtimberValue.Value, (construction == null) ? (decimal?)null : construction.NewConstructionBuildingAv, valueMaster.AssocMhparcel.Value,
                valueMaster.AffidavitAssessmentYear.Value, valueMaster.AffidavitTaxYear.Value, valueMaster.OpenspaceApplicationNum.Value,
                valueMaster.OpenSpaceAgreementNum.Value, valueMaster.UndividedInterestPercent.Value, valueMaster.MobileHomeValue.Value,
                citizenHistory?.SeniorCitizenCode, valueMaster.SubsidiaryParcelCode);
    }
}