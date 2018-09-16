using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Building;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class BuildingModuleRepository : IBuildingModuleRepository
    {
        private readonly GrantCountyDbContext _context;

        public BuildingModuleRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<BuildingModuleMain> GetBuildingModuleMain(decimal? applicationNumber, int? applicationYear,
                                                              string departmentCode, string jurisdictionCode, out int resultCount,
                                                              int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingModuleMain> results = new List<BuildingModuleMain>();
            var query = from appm in _context.BldgpermitApplicationMaster
                        where (appm.ApplicationNumber == applicationNumber || applicationNumber == null)
                        &&    (appm.ApplicationYear == applicationYear || applicationYear == null)
                        &&    (appm.DepartmentCode == departmentCode || string.IsNullOrWhiteSpace(departmentCode))
                        &&    (appm.JurisdictionCode == jurisdictionCode || string.IsNullOrWhiteSpace(jurisdictionCode))
                        select BuildingModuleMapper.Map(appm);
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ApplicationDate)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ApplicationDate)
                               .ToList();
                resultCount = results.Count();
            }

            return results;



        }
    }
}
