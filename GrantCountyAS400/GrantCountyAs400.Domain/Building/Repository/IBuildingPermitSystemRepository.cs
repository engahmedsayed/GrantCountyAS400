using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Building.Repository
{
    public interface IBuildingPermitSystemRepository
    {
        List<BuildingPermitSystem> GetAll(decimal? applicationNumber, int? applicationYear, string departmentCode, string jurisdictionCode,
                                          out int resultCount, int pageNumber = 1, int pageSize = 50);

        BuildingPermitSystemDetails Details(int id);

        DemolitionPermit GetDemolitionPermitByBuildingPermitSystemId(int id);
    }
}