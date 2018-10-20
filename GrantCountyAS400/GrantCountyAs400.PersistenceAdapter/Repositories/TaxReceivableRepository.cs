using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class TaxReceivableRepository : ITaxReceivableRepository
    {
        private readonly GrantCountyDbContext _context;

        public TaxReceivableRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<TaxReceivable> GetAll(
            decimal parcelNumber,
            out int resultCount,
            int pageNumber = 1,
            int pageSize = 50)
        {
            List<TaxReceivable> results = new List<TaxReceivable>();

            var query = (from treasurerProperty in _context.TreasPropertyMasterInfoView
                         where ((parcelNumber <= 0) || treasurerProperty.ParcelNumber == parcelNumber)
                         select TaxReceivableMapper.Map(treasurerProperty));

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.TaxpayerName)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.TaxpayerName)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }
    }
}