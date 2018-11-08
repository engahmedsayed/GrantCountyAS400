using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class LegalDocumentRepository : ILegalDocumentRepository
    {
        private readonly GrantCountyDbContext _context;

        public LegalDocumentRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public RealPropertyLegalDocument GetByParcelNumber(decimal parcelNumber)
        {
            var realproperty = (from namesRecord in _context.ASMTValueMasterNameView
                                join valueMasterRecord in _context.AsmtrealPropertyAssessedValueMaster on namesRecord.Id equals valueMasterRecord.Id
                                join codeArea in _context.AsmttaxCodeArea on namesRecord.TaxCodeArea equals codeArea.TaxCodeArea
                                join landUseCode in _context.AsmtlandUseCodes on valueMasterRecord.LandUseCode equals landUseCode.LandUseCode
                                where namesRecord.ParcelNumber == parcelNumber
                                select new { namesRecord, codeArea, valueMasterRecord, landUseCode }).SingleOrDefault();

            if (realproperty != null)
            {
                var legalDocs = (from legalDocument in _context.AsmtlegalDocuments
                                 join exciseTaxData in _context.AsmtsalesAndExciseTaxData
                                 on new
                                 {
                                     legalDocument.ParcelNumber,
                                     legalDocument.AffidavitNumber,
                                     legalDocument.AffidavitNumberExtension,
                                     legalDocument.LegalDocumentType,
                                 }
                                 equals new
                                 {
                                     exciseTaxData.ParcelNumber,
                                     exciseTaxData.AffidavitNumber,
                                     exciseTaxData.AffidavitNumberExtension,
                                     exciseTaxData.LegalDocumentType,
                                 }
                                 where legalDocument.ParcelNumber == parcelNumber
                                    && legalDocument.RecordCode != "*" && exciseTaxData.RecordCode != "*"
                                 orderby legalDocument.LegalInstrumentDate
                                 select LegalDocumentMapper.Map(legalDocument, exciseTaxData)).ToList();
                return LegalDocumentMapper.Map(realproperty.valueMasterRecord,
                                               realproperty.namesRecord,
                                               realproperty.codeArea,
                                               realproperty.landUseCode,
                                               legalDocs);
            }

            return null;
        }

        public LegalDocumentDetails Details(int legalDocumentId)
        {
            var query = (from legalDocument in _context.AsmtlegalDocuments
                         join namesRecord in _context.ASMTValueMasterNameView on legalDocument.ParcelNumber equals namesRecord.ParcelNumber
                         join valueMasterRecord in _context.AsmtrealPropertyAssessedValueMaster on namesRecord.Id equals valueMasterRecord.Id
                         join codeArea in _context.AsmttaxCodeArea on namesRecord.TaxCodeArea equals codeArea.TaxCodeArea
                         join landUseCode in _context.AsmtlandUseCodes on valueMasterRecord.LandUseCode equals landUseCode.LandUseCode
                         join exciseTaxData in _context.AsmtsalesAndExciseTaxData
                         on new
                         {
                             legalDocument.ParcelNumber,
                             legalDocument.AffidavitNumber,
                             legalDocument.AffidavitNumberExtension,
                             legalDocument.LegalDocumentType,
                         }
                         equals new
                         {
                             exciseTaxData.ParcelNumber,
                             exciseTaxData.AffidavitNumber,
                             exciseTaxData.AffidavitNumberExtension,
                             exciseTaxData.LegalDocumentType,
                         }
                         join rejection in _context.AsmtsalesRejectionReasonCodes on exciseTaxData.SaleRejectionCode equals rejection.SaleRejectionCode
                         into rejectionJoin
                         from defaultRejection in rejectionJoin.DefaultIfEmpty()
                         join instrument in _context.AsmtinstrumentType on legalDocument.LegalDocumentType equals instrument.InstrumentCode
                         into instrumentJoin
                         from defaultInstrument in instrumentJoin.DefaultIfEmpty()
                         where legalDocument.Id == legalDocumentId
                         select new { namesRecord, codeArea, valueMasterRecord, landUseCode, exciseTaxData, legalDocument, defaultInstrument, defaultRejection }).SingleOrDefault();

            if (query != null)
            {
                return LegalDocumentMapper.Map(query.valueMasterRecord,
                                               query.namesRecord,
                                               query.legalDocument,
                                               query.codeArea,
                                               query.landUseCode,
                                               query.exciseTaxData,
                                               query.defaultInstrument,
                                               query.defaultRejection);
            }

            return null;
        }
    }
}