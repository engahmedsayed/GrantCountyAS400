using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Building;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class BuildingPermitSystemRepository : IBuildingPermitSystemRepository
    {
        private readonly GrantCountyDbContext _context;

        public BuildingPermitSystemRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public BuildingPermitSystemDetail Details(int id)
        {
            var query = (from appm in _context.BldgpermitApplicationMaster
                         where appm.Id == id
                         select appm).FirstOrDefault();
            BuildingPermitSystemDetail result = new BuildingPermitSystemDetail(query.JurisdictionCode, query.DepartmentCode,
                                                                               query.ApplicationYear, query.AddendumNumber,
                                                                               query.PermitStatus, query.ApplicantLastName + "," + query.ApplicantFirstName,
                                                                               query.ContractLicenseNumber, query.ApplicantProjectDescription,
                                                                               query.AdditionalInformation, query.ResultOfEnforcementAction,
                                                                               query.EnforcementDescription, query.PlotPlanReceived,
                                                                               query.OnlyStructureOnParcel, query.OnlyResidenceOnParcel);
            return result;
        }

        public List<BuildingPermitSystem> GetAll(decimal? applicationNumber, int? applicationYear,
                                                              string departmentCode, string jurisdictionCode, out int resultCount,
                                                              int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingPermitSystem> results = new List<BuildingPermitSystem>();
            var query = from appm in _context.BldgpermitApplicationMaster
                        where (appm.ApplicationNumber == applicationNumber || applicationNumber == null)
                        && (appm.ApplicationYear == applicationYear || applicationYear == null)
                        && (appm.DepartmentCode == departmentCode || string.IsNullOrWhiteSpace(departmentCode))
                        && (appm.JurisdictionCode == jurisdictionCode || string.IsNullOrWhiteSpace(jurisdictionCode))
                        select BuildingPermitSystemMapper.Map(appm);
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