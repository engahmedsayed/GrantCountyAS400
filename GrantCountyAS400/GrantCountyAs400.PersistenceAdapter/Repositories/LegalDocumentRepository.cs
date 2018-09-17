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
                                join exciseTaxData in _context.AsmtsalesAndExciseTaxData on valueMasterRecord.ParcelNumber equals exciseTaxData.ParcelNumber
                                where namesRecord.ParcelNumber == parcelNumber
                                && exciseTaxData.RecordCode != "*"
                                select new { namesRecord, codeArea, valueMasterRecord, landUseCode, exciseTaxData }).FirstOrDefault();

            if (realproperty != null)
            {
                var legalDocs = _context.AsmtlegalDocuments.Where(t => t.ParcelNumber.Value == parcelNumber && t.RecordCode != "*")
                                                           .OrderBy(t => t.LegalInstrumentDate)
                                                           .ToList();
                return LegalDocumentMapper.Map(realproperty.valueMasterRecord,
                                               realproperty.namesRecord,
                                               realproperty.codeArea,
                                               realproperty.landUseCode,
                                               realproperty.exciseTaxData,
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
                         on new { legalDocument.ParcelNumber, legalDocument.AffidavitNumber, legalDocument.AffidavitNumberExtension, legalDocument.LegalDocumentType }
                         equals new { exciseTaxData.ParcelNumber, exciseTaxData.AffidavitNumber, exciseTaxData.AffidavitNumberExtension, exciseTaxData.LegalDocumentType }
                         join instrument in _context.AsmtinstrumentType on legalDocument.LegalDocumentType equals instrument.InstrumentCode
                         join rejection in _context.AsmtsalesRejectionReasonCodes on exciseTaxData.SaleRejectionCode equals rejection.SaleRejectionCode
                         where legalDocument.Id == legalDocumentId
                         select new { namesRecord, codeArea, valueMasterRecord, landUseCode, exciseTaxData, legalDocument, instrument, rejection }).SingleOrDefault();

            if (query != null)
            {
                return LegalDocumentMapper.Map(query.valueMasterRecord,
                                               query.namesRecord,
                                               query.legalDocument,
                                               query.codeArea,
                                               query.landUseCode,
                                               query.exciseTaxData,
                                               query.instrument,
                                               query.rejection);
            }

            return null;
        }
    }
}