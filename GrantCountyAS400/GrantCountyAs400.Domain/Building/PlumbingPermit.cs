namespace GrantCountyAs400.Domain.Building
{
    public class PlumbingPermit
    {
        public string OfficeProjectDescription { get; }
        public string FireDistrictCode { get; }
        public decimal BldgDeptSetback { get; }
        public decimal FireMarshalSetback { get; }

        public string LongFireDistrictName { get; }
        public bool HasBuildingApplicationCondition { get; }
        public bool HasBuildingApplicationInspection { get; }
        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public PlumbingPermit(string officeProjectDescription, string fireDistrictCode, decimal bldgDeptSetback, decimal fireMarshalSetback, string longFireDistrictName,
            bool hasBuildingApplicationCondition, bool hasBuildingApplicationInspection, PermitApprovedInfo bldgDept, PermitApprovedInfo fireMarshal)
        {
            OfficeProjectDescription = officeProjectDescription;
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