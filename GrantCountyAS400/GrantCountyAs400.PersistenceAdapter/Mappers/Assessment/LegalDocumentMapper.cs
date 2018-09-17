using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class LegalDocumentMapper
    {
        internal static LegalDocument Map(AsmtlegalDocuments legalDocument) =>
            new LegalDocument(legalDocument.Id, legalDocument.ParcelNumber.Value, legalDocument.LegalInstrumentDate, legalDocument.LegalDocumentType,
                legalDocument.PreviousOwnerSeller, legalDocument.Volume.Value, legalDocument.Page.Value, legalDocument.AffidavitNumber.Value,
                legalDocument.AffidavitNumberExtension);

        internal static RealPropertyLegalDocument Map(AsmtrealPropertyAssessedValueMaster valueMaster,
                                                      ASMTValueMasterNameView namesRecord,
                                                      AsmttaxCodeArea codeArea,
                                                      AsmtlandUseCodes landUserCode,
                                                      AsmtsalesAndExciseTaxData exciseTaxData,
                                                      List<AsmtlegalDocuments> legalDocuments) =>
            new RealPropertyLegalDocument(valueMaster.ParcelNumber.Value, namesRecord.TaxpayerCode, namesRecord.TaxpayerName?.Trim(), namesRecord.TitleOwnerCode,
                namesRecord.TitleOwnerName?.Trim(), namesRecord.ContractHolderCode, namesRecord.ContractHolderName?.Trim(), valueMaster.LoanNumber,
                valueMaster.BuildingValue.Value, valueMaster.ImprovedLandValue.Value, valueMaster.LandUseCode.Value, valueMaster.TaxYear.Value, codeArea.TaxCodeArea.Value,
                codeArea.TaxCodeDesc.Trim(), landUserCode?.UseCodeShortDesc, exciseTaxData.AssessedValue.Value,
                exciseTaxData.RPsalesAmount.Value, exciseTaxData.PPsalesAmount.Value, legalDocuments.Select(Map));

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
                legalDocument.AssocateParcelNumber.Value, legalDocument.ProbateNumber.Value,

                exciseTaxData.RPsalesAmount.Value, exciseTaxData.PPsalesAmount.Value, exciseTaxData.MultipleParcelSale, exciseTaxData.SaleRejectionCode.Value,
                exciseTaxData.Comment, exciseTaxData.PersPropParcel.Value, exciseTaxData.IncorporatedArea, exciseTaxData.AssessedValue.Value, exciseTaxData.TaxYear.Value,
                exciseTaxData.SaleDate,

                codeArea.TaxCodeArea.Value, codeArea.TaxCodeDesc.Trim(), landUserCode?.UseCodeShortDesc,
                instrumentType.InstrumentTypeDescription, rejectionReasonCode.Comment);
    }
}