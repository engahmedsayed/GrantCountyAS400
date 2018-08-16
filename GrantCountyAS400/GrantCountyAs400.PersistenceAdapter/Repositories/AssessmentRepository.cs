using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class AssessmentRepository : IAssessmentRepository
    {
        private readonly GrantCountyDbContext _context;

        public AssessmentRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Assessment> GetAll(decimal parcelNumber, string taxpayer, string owner, string contractHolder, decimal taxcodeArea,
                                              string taxcodeDesc, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<Assessment> results = new List<Assessment>();

            var query = (from valueMaster in _context.ASMTValueMasterNameView
                         join codeArea in _context.AsmttaxCodeArea on valueMaster.TaxCodeArea equals codeArea.TaxCodeArea
                         where ((parcelNumber <= 0) || valueMaster.ParcelNumber == parcelNumber)
                         && ((taxcodeArea <= 0) || codeArea.TaxCodeArea == taxcodeArea)
                         && (string.IsNullOrEmpty(taxcodeDesc) || codeArea.TaxCodeDesc.ToLower().Contains(taxcodeDesc.Trim().ToLower()))
                         && (string.IsNullOrEmpty(taxpayer) || valueMaster.TaxpayerName.ToLower().Contains(taxpayer.Trim().ToLower()))
                         && (string.IsNullOrEmpty(owner) || valueMaster.TitleOwnerName.ToLower().Contains(owner.Trim().ToLower()))
                         && (string.IsNullOrEmpty(contractHolder) || valueMaster.ContractHolderName.ToLower().Contains(contractHolder.Trim().ToLower()))
                         orderby valueMaster.TaxpayerName
                         select AssessmentMapper.Map(valueMaster, codeArea));

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.TaxPayerName)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.TaxPayerName)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public AssessmentDetails Details(int id)
        {
            var assessmentDetails = (from namesRecord in _context.ASMTValueMasterNameView
                                     join codeArea in _context.AsmttaxCodeArea on namesRecord.TaxCodeArea equals codeArea.TaxCodeArea
                                     join valueMasterRecord in _context.AsmtrealPropertyAssessedValueMaster on namesRecord.Id equals valueMasterRecord.Id
                                     where namesRecord.Id == id
                                     select new { namesRecord, codeArea, valueMasterRecord }).SingleOrDefault();

            if (assessmentDetails != null)
            {
                var landUseCode = _context.AsmtlandUseCodes.SingleOrDefault(t => t.LandUseCode == assessmentDetails.valueMasterRecord.LandUseCode);
                var zoneCode = _context.AsmtzoneDescriptions.SingleOrDefault(t => t.ZoneCode == assessmentDetails.valueMasterRecord.ZoneCode);
                var construction = _context.AsmtnewConstruction.SingleOrDefault(t => t.ParcelNumber == assessmentDetails.valueMasterRecord.ParcelNumber &&
                                                                                    t.TaxYear == 2010);
                var citizenHistory = _context.AsmtseniorCitizenHistory.SingleOrDefault(t => t.ParcelNumber == assessmentDetails.valueMasterRecord.ParcelNumber &&
                                                                                            t.TaxYear == 2010);

                return AssessmentMapper.Map(assessmentDetails.namesRecord,
                                            assessmentDetails.codeArea,
                                            assessmentDetails.valueMasterRecord,
                                            landUseCode,
                                            zoneCode,
                                            construction,
                                            citizenHistory);
            }
            else
            {
                return null;
            }
        }
    }
}