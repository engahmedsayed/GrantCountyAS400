using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class BuildingPermitsRepository : IBuildingPermitsRepository
    {
        private readonly GrantCountyDbContext _context;
        public BuildingPermitsRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<BuildingPermitsMain> GetBuldingPermitsMain(out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingPermitsMain> results = new List<BuildingPermitsMain>();
            var query = from RPAV in _context.AsmtrealPropertyAssessedValueMaster
                        join NNAME in _context.AsmtmasterNameAddress
                        on RPAV.TaxpayerCode equals NNAME.NameCode
                        select BuildingPermitsMapper.Map(RPAV, NNAME);

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

        public BuildingPermits GetParcelBuildingPermits(decimal parcelNumber, string ownerCode)
        {
            throw new NotImplementedException();
        }
    }
}
