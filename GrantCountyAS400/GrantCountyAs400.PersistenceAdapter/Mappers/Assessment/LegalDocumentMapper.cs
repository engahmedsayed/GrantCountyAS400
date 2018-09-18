using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class LegalDocumentMapper
    {
        internal static LegalDocument Map(AsmtlegalDocuments legalDocument, AsmtsalesAndExciseTaxData exciseTaxData) =>
            new LegalDocument(legalDocument.Id, legalDocument.ParcelNumber.Value, legalDocument.LegalInstrumentDate, legalDocument.LegalDocumentType,
                legalDocument.PreviousOwnerSeller, legalDocument.Volume.Value, legalDocument.Page.Value, legalDocument.AffidavitNumber.Value,
                legalDocument.AffidavitNumberExtension, exciseTaxData?.RPsalesAmount, exciseTaxData?.PPsalesAmount);

        internal static RealPropertyLegalDocument Map(AsmtrealPropertyAssessedValueMaster valueMaster,
                                                      ASMTValueMasterNameView namesRecord,
                                                      AsmttaxCodeArea codeArea,
                                                      AsmtlandUseCodes landUserCode,
                                                      List<LegalDocument> legalDocuments) =>
            new RealPropertyLegalDocument(valueMaster.ParcelNumber.Value, namesRecord.TaxpayerCode, namesRecord.TaxpayerName?.Trim(), namesRecord.TitleOwnerCode,
                namesRecord.TitleOwnerName?.Trim(), namesRecord.ContractHolderCode, namesRecord.ContractHolderName?.Trim(), valueMaster.LoanNumber,
                valueMaster.BuildingValue.Value, valueMaster.ImprovedLandValue.Value, valueMaster.LandUseCode.Value, valueMaster.TaxYear.Value, codeArea.TaxCodeArea.Value,
                codeArea.TaxCodeDesc.Trim(), landUserCode?.UseCodeShortDesc, legalDocuments);

        internal static LegalDocumentDetails Map(AsmtrealPropertyAssessedValueMaster valueMaster,
                                                      ASMTValueMasterNameView namesRecord,
                                                      AsmtlegalDocuments legalDocument,
                                                      AsmttaxCodeArea codeArea,
                                                      AsmtlandUseCodes landUserCode,
                                                      AsmtsalesAndExciseTaxData exciseTaxData,
                                                      AsmtinstrumentType instrumentType,
                                                      AsmtsalesRejectionReasonCodes rejectionReasonCode
                                                      ) =>
            new LegalDocumentDetails(valueMaster.ParcelNumber.Value, namesRecord.TaxpayerCode, namesRecord.TaxpayerName?.Trim(), namesRecord.TitleOwnerCode,
                namesRecord.TitleOwnerName?.Trim(), namesRecord.ContractHolderCode, namesRecord.ContractHolderName?.Trim(), valueMaster.LoanNumber,
                valueMaster.BuildingValue.Value, valueMaster.LandUseCode.Value, valueMaster.UnimprovedLandValue.Value, valueMaster.ImprovedLandValue.Value,
                legalDocument.LegalInstrumentDate, legalDocument.LegalDocumentType,
                legalDocument.PreviousOwnerSeller, legalDocument.Volume.Value, legalDocument.Page.Value, legalDocument.AffidavitNumber.Value,
                legalDocument.AffidavitNumberExtension, legalDocument.AuditorFileNumber.Value, legalDocument.Comment, legalDocument.ChangeId, legalDocument.ChangeDate.Value,
                legalDocument.AssocateParcelNumber.Value, legalDocument.ProbateNumber.Value, exciseTaxData?.RPsalesAmount, exciseTaxData?.PPsalesAmount,
                exciseTaxData?.MultipleParcelSale, exciseTaxData?.SaleRejectionCode, exciseTaxData?.Comment, exciseTaxData?.PersPropParcel, exciseTaxData?.IncorporatedArea,
                exciseTaxData?.AssessedValue, exciseTaxData?.TaxYear, exciseTaxData?.SaleDate, codeArea.TaxCodeArea.Value, codeArea.TaxCodeDesc.Trim(),
                landUserCode?.UseCodeShortDesc, instrumentType?.InstrumentTypeDescription, rejectionReasonCode?.Comment);
    }
}