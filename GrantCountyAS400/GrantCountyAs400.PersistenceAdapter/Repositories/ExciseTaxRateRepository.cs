using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.PersistenceAdapter.Extensions;
using GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class ExciseTaxRateRepository : IExciseTaxRateRepository
    {
        private readonly GrantCountyDbContext _context;

        public ExciseTaxRateRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<ExciseTaxRate> GetAll(string description, string recordType, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            var results = new List<ExciseTaxRate>();

            var query = from taxrate in _context.TreasexciseTaxRate
                        where (string.IsNullOrEmpty(description) || taxrate.Description.TrimAndLower() == description.TrimAndLower())
                        && (string.IsNullOrEmpty(recordType) || taxrate.RecordTypeStateLocal.TrimAndLower() == recordType.TrimAndLower())
                        orderby taxrate.RecordTypeStateLocal, taxrate.Description
                        select ExciseTaxRateMapper.Map(taxrate);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();
            }
            else
            {
                results = query.ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public IEnumerable<string> GetAllDescriptions()
        {
            return _context.TreasexciseTaxRate
                           .OrderBy(taxrate => taxrate.Description)
                           .Select(taxrate => taxrate.Description.Trim())
                           .Distinct()
                           .ToList();
        }
    }
}