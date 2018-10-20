using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.Domain.Treasurer.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class TreasurerMasterRepository : ITreasurerMasterRepository
    {
        private readonly GrantCountyDbContext _context;

        public TreasurerMasterRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<TreasurerMaster> GetAll(
            decimal parcelNumber,
            out int resultCount,
            int pageNumber = 1,
            int pageSize = 50)
        {
            List<TreasurerMaster> results = new List<TreasurerMaster>();

            var query = (from treasurerProperty in _context.TreasallPropertyMaster
                         join valueMaster in _context.ASMTValueMasterNameView
                         on new { treasurerProperty.TaxpayerCode, treasurerProperty.ParcelNumber } equals new { valueMaster.TaxpayerCode, valueMaster.ParcelNumber }
                         where ((parcelNumber <= 0) || valueMaster.ParcelNumber == parcelNumber)
                         select TreasurerMasterMapper.Map(treasurerProperty, valueMaster));

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