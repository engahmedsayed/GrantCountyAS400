using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IBuildingPermitsRepository
    {
        List<BuildingPermitsMain> GetBuldingPermitsMain(decimal? parcelNumber,out int resultCount, int pageNumber = 1, int pageSize = 50);

        HistoricValuesMain GetHistoricValues(decimal? parcelNumber, string taxPayerCode, out int resultCount, int pageNumber = 1, int pageSize = 50);

        BuildingPermits GetParcelBuildingPermits(decimal parcelNumber, string ownerCode);
    }
}
