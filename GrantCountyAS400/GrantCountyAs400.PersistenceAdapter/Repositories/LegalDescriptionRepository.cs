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

        public IEnumerable<LegalDescription> GetAll(decimal parcelNumber, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<LegalDescription> results = new List<LegalDescription>();
            IQueryable<AsmtfullLegalDescription> query = _context.AsmtfullLegalDescription;
            if (parcelNumber > 0)
            {
                query = query.Where(t => t.ParcelNumber == parcelNumber);
            }

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ParcelNumber)
                               .Select(LegalDescriptionMapper.Map)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ParcelNumber)
                               .Select(LegalDescriptionMapper.Map)
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