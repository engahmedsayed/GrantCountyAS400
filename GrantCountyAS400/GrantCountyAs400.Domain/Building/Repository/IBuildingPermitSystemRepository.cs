﻿using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Building.Repository
{
    public interface IBuildingPermitSystemRepository
    {
        List<BuildingPermitSystem> GetAll(decimal? applicationNumber, int? applicationYear, string departmentCode, string jurisdictionCode,
                                          out int resultCount, int pageNumber = 1, int pageSize = 50);
        BuildingPermitSystemDetails Details(int id);
        DemolitionPermit GetDemolitionPermitByBuildingPermitSystemId(int id);
        OtherPermitDetail GetOtherPermitDetailByBuildingPermitSystemId(int id);
        MechanicalPermitDetail GetMechanicalPermitDetailByBuildingPermitSystemId(int id);
        StructurePermitDetail GetStructurePermitDetailByBuildingPermitSystemId(int id);
        GradingExcavationPermitDetail GetGradingExcavationPermitDetail(int id);
        ManufactureModularPermit GetManufactureModularPermitByBuildingPermitSystemId(int id);
    }
}