using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building.Repository
{
    public interface IBuildingModuleRepository
    {
        List<BuildingModuleMain> GetBuildingModuleMain(decimal? applicationNumber,int? applicationYear,string departmentCode,
                                                       string jurisdictionCode,out int resultCount, int pageNumber = 1,
                                                       int pageSize = 50);
    }
}
