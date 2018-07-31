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

        public IEnumerable<LegalDescription> GetAll(decimal parcelNumber, string taxpayer, string owner, string contractHolder,
                                                    out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<LegalDescription> results = new List<LegalDescription>();

            var query = from legal in _context.AsmtfullLegalDescription
                        join valueMaster in _context.ASMTValueMasterNameView on legal.ParcelNumber equals valueMaster.ParcelNumber
                        where ((parcelNumber <= 0) || legal.ParcelNumber == parcelNumber)
                        && (string.IsNullOrEmpty(taxpayer) || valueMaster.TaxpayerName.ToLower().Contains(taxpayer.Trim().ToLower()))
                        && (string.IsNullOrEmpty(owner) || valueMaster.TitleOwnerName.ToLower().Contains(owner.Trim().ToLower()))
                        && (string.IsNullOrEmpty(contractHolder) || valueMaster.ContractHolderName.ToLower().Contains(contractHolder.Trim().ToLower()))
                        select LegalDescriptionMapper.Map(legal, valueMaster);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ParcelNumber)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ParcelNumber)
                               .ToList();
                resultCount = results.Count();
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