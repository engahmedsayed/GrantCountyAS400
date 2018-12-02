using GrantCountyAs400.Domain.Building;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrantCountyAs400.Domain.ExportingService
{
    public interface IExportingService
    {
        MemoryStream GetBuildingPermitSystem(BuildingSearchCriteria filter);
    }
}
