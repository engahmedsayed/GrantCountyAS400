﻿using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Building.Repository
{
    public interface IBuildingPermitSystemRepository
    {
        List<BuildingPermitSystem> GetAll(BuildingSearchCriteria searchCriteria, out int resultCount, int pageNumber = 1, int pageSize = 50);
        BuildingPermitSystem Get(int id);
        BuildingPermitSystemDetails Details(int id);

        ValuationFeeDetails GetValuationDetails(int id);

        BuildingPermitSystemBasicInfo GetBasicInfo(int id);
        DemolitionPermit GetDemolitionPermitByBuildingPermitSystemId(int id);
        OtherPermitDetail GetOtherPermitDetailByBuildingPermitSystemId(int id);
        MechanicalPermitDetail GetMechanicalPermitDetailByBuildingPermitSystemId(int id);
        StructurePermitDetail GetStructurePermitDetailByBuildingPermitSystemId(int id);
        GradingExcavationPermitDetail GetGradingExcavationPermitDetail(int id);
        ManufactureModularPermit GetManufactureModularPermitByBuildingPermitSystemId(int id);
        PlumbingPermit GetPlumbingPermitByBuildingPermitSystemId(int id);
        ValuationAndFees GetValuationAndFees(int id, decimal? applictionYear, decimal? applicationNumber, string feeCode = null);
        IEnumerable<BuildingInspection> GetInspectionsByBuildingPermitSystemId(int id);
        IEnumerable<BuildingCondition> GetConditionsByBuildingPermitSystemId(int id);
        (IEnumerable<ReceiptHeader> ReceiptHeaders, IEnumerable<BuildingApplicationFee> BuildingApplicationFees) GetReceiptHeadersAndFeesByBuildingPermitSystemId(int id);
    }
}