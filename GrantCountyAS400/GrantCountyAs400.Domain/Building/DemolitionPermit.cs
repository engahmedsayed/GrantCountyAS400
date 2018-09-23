using System;

namespace GrantCountyAs400.Domain.Building
{
    public class DemolitionPermit
    {
        public string ApplicantProjectDescription { get; }
        public string OfficeProjectDescription { get; }
        public decimal SquareFeet { get; }
        public string Dimensions { get; }
        public string BuildingDescription { get; }
        public string RequiredHandoutsProvided { get; }
        public DateTime? DateProvided { get; }
        public string ToWhomProvided { get; }
        public string FireDistrictCode { get; }
        public decimal BldgDeptSetback { get; }
        public decimal FireMarshalSetback { get; }

        public string LongFireDistrictName { get; }
        public bool HasBuildingApplicationCondition { get; }
        public bool HasBuildingApplicationInspection { get; }
        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public DemolitionPermit(string applicantProjectDescription, string officeProjectDescription, decimal squareFeet, string dimensions, string buildingDescription,
            string requiredHandoutsProvided, DateTime? dateProvided, string toWhomProvided, string fireDistrictCode, decimal bldgDeptSetback, decimal fireMarshalSetback,
            string longFireDistrictName, bool hasBuildingApplicationCondition, bool hasBuildingApplicationInspection, PermitApprovedInfo bldgDept,
            PermitApprovedInfo fireMarshal)
        {
            ApplicantProjectDescription = applicantProjectDescription;
            OfficeProjectDescription = officeProjectDescription;
            SquareFeet = squareFeet;
            Dimensions = dimensions;
            BuildingDescription = buildingDescription;
            RequiredHandoutsProvided = requiredHandoutsProvided;
            DateProvided = dateProvided;
            ToWhomProvided = toWhomProvided;
            FireDistrictCode = fireDistrictCode;
            BldgDeptSetback = bldgDeptSetback;
            FireMarshalSetback = fireMarshalSetback;
            LongFireDistrictName = longFireDistrictName;
            HasBuildingApplicationCondition = hasBuildingApplicationCondition;
            HasBuildingApplicationInspection = hasBuildingApplicationInspection;
            BldgDept = bldgDept;
            FireMarshal = fireMarshal;
        }
    }
}