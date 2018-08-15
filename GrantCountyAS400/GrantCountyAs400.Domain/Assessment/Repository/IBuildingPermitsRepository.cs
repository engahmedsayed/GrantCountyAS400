using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IBuildingPermitsRepository
    {
        List<BuildingPermitsMain> GetBuldingPermitsMain(out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}
