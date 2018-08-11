using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class LegalDescriptionRepository : ILegalDescriptionRepository
    {
        private readonly GrantCountyDbContext _context;

        public LegalDescriptionRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<RealPropertyWithLegalDescriptions> GetAll(decimal parcelNumber, string taxpayer, string owner, string contractHolder,
                                                                     out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<RealPropertyWithLegalDescriptions> results = new List<RealPropertyWithLegalDescriptions>();

            List<ASMTValueMasterNameView> valueMasterRecords = new List<ASMTValueMasterNameView>();
            var query = (from valueMaster in _context.ASMTValueMasterNameView
                         join legal in _context.AsmtfullLegalDescription on valueMaster.ParcelNumber equals legal.ParcelNumber
                         where ((parcelNumber <= 0) || valueMaster.ParcelNumber == parcelNumber)
                         && (string.IsNullOrEmpty(taxpayer) || valueMaster.TaxpayerName.ToLower().Contains(taxpayer.Trim().ToLower()))
                         && (string.IsNullOrEmpty(owner) || valueMaster.TitleOwnerName.ToLower().Contains(owner.Trim().ToLower()))
                         && (string.IsNullOrEmpty(contractHolder) || valueMaster.ContractHolderName.ToLower().Contains(contractHolder.Trim().ToLower()))
                         orderby valueMaster.TaxpayerName
                         select valueMaster).Distinct();

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                valueMasterRecords = query.Skip((pageNumber - 1) * pageSize)
                                          .Take(pageSize)
                                          .ToList();
            }
            else
            {
                valueMasterRecords = query.ToList();
                resultCount = results.Count();
            }

            var listOfRetrievedParcelNumbers = valueMasterRecords.Select(personnel => personnel.ParcelNumber.Value).ToList();

            var legalRecords = _context.AsmtfullLegalDescription
                                       .Where(legal => listOfRetrievedParcelNumbers.Contains(legal.ParcelNumber.Value))
                                       .Select(LegalDescriptionMapper.Map)
                                       .ToList();

            foreach (var valueMaster in valueMasterRecords)
            {
                results.Add(new RealPropertyWithLegalDescriptions(
                                 valueMaster.ParcelNumber.Value, valueMaster.TaxpayerName?.Trim(), valueMaster.TitleOwnerName?.Trim(),
                                 valueMaster.ContractHolderName?.Trim(), legalRecords.Where(legal => legal.ParcelNumber == valueMaster.ParcelNumber)
                                 ));
            }

            return results;
        }

        public LegalDescriptionDetails Details(int id)
        {
            var legalDescription = (from legalRecord in _context.AsmtfullLegalDescription
                                    join masterRecord in _context.AsmtrealPropertyAssessedValueMaster on legalRecord.ParcelNumber equals masterRecord.ParcelNumber
                                    where legalRecord.Id == id
                                    select LegalDescriptionMapper.Map(legalRecord, masterRecord)
                                   ).SingleOrDefault();

            return legalDescription;
        }
    }
}