using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingModuleMain
    {
        public BuildingModuleMain(DateTime? applicationDate, decimal? applicationNumber, decimal? addendumNumber, string permitCode, string permitStatus, decimal? applicationYear,
                                  decimal? permitNumber, string applicationName, string buildingApprovalRequired, string buildingApprovalDate, string fireMarchalRequired,
                                  string fireMarshalDate, string planningApprovalRequired, string planningApprovalDate, string healthApprovalRequired, string healthApprovalDate,
                                  string assessorApprovalRequired, string assessorApprovalDate, string publicWorkApprovalRequired, string publicWorkApprovalDate,
                                  string cityJurisdictionApprovalRequired, string cityJurisdictionApprovalDate, string cityUtilityApprovalRequired, string cityUtilityApprovalDate)
        {
            ApplicationDate = applicationDate;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            PermitCode = permitCode;
            PermitStatus = permitStatus;
            ApplicationYear = applicationYear;
            PermitNumber = permitNumber;
            ApplicationName = applicationName;
            BuildingApprovalRequired = buildingApprovalRequired;
            BuildingApprovalDate = buildingApprovalDate;
            FireMarchalRequired = fireMarchalRequired;
            FireMarshalDate = fireMarshalDate;
            PlanningApprovalRequired = planningApprovalRequired;
            PlanningApprovalDate = planningApprovalDate;
            HealthApprovalRequired = healthApprovalRequired;
            HealthApprovalDate = healthApprovalDate;
            AssessorApprovalRequired = assessorApprovalRequired;
            AssessorApprovalDate = assessorApprovalDate;
            PublicWorkApprovalRequired = publicWorkApprovalRequired;
            PublicWorkApprovalDate = publicWorkApprovalDate;
            CityJurisdictionApprovalRequired = cityJurisdictionApprovalRequired;
            CityJurisdictionApprovalDate = cityJurisdictionApprovalDate;
            CityUtilityApprovalRequired = cityUtilityApprovalRequired;
            CityUtilityApprovalDate = cityUtilityApprovalDate;
        }

        public DateTime? ApplicationDate { get; private set; }
        public decimal? ApplicationNumber { get; private set; }
        public decimal? AddendumNumber { get; private set; }
        public string PermitCode { get; private set; }
        public string PermitStatus { get; private set; }
        public decimal? ApplicationYear { get; private set; }
        public decimal? PermitNumber { get; private set; }
        public string ApplicationName { get; private set; }
        public string BuildingApprovalRequired { get;private set; }
        public string BuildingApprovalDate { get; private set; }

        public string FireMarchalRequired { get; private set; }
        public string FireMarshalDate { get; private set; }

        public string PlanningApprovalRequired { get; private set; }
        public string PlanningApprovalDate { get; private set; }

        public string HealthApprovalRequired { get; private set; }
        public string HealthApprovalDate { get; private set; }

        public string AssessorApprovalRequired { get; private set; }
        public string AssessorApprovalDate { get; private set; }

        public string PublicWorkApprovalRequired { get; private set; }
        public string PublicWorkApprovalDate { get; private set; }

        public string CityJurisdictionApprovalRequired { get; private set; }
        public string CityJurisdictionApprovalDate { get; private set; }
        public string CityUtilityApprovalRequired { get; private set; }
        public string CityUtilityApprovalDate { get; private set; }


    }
}
