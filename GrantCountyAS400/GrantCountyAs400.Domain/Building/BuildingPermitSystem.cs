﻿using System;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingPermitSystem
    {
        public BuildingPermitSystem(int id,DateTime? permitIssueDate,DateTime?applicationDate,decimal? assessorParcelNumber,string businessName, decimal? applicationNumber, decimal? addendumNumber, string permitCode, string permitStatus, decimal? applicationYear,
                                  decimal? permitNumber,decimal?permitYear, string applicationName, string buildingApprovalRequired, string buildingApprovalDate, string fireMarchalRequired,
                                  string fireMarshalDate, string planningApprovalRequired, string planningApprovalDate, string healthApprovalRequired, string healthApprovalDate,
                                  string assessorApprovalRequired, string assessorApprovalDate, string publicWorkApprovalRequired, string publicWorkApprovalDate,
                                  string cityJurisdictionApprovalRequired, string cityJurisdictionApprovalDate, string cityUtilityApprovalRequired, string cityUtilityApprovalDate,
                                  string officeProjectDescription,string projectDescription,string contractorBusinessName,string resultOfEnforcementAction)
        {
            PermitIssueDate = permitIssueDate;
            ApplicationDate = applicationDate;
            ApplicantBusinessName = businessName;
            AssessorParcelNumber = assessorParcelNumber;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            PermitCode = permitCode;
            PermitStatus = permitStatus;
            ApplicationYear = applicationYear;
            PermitNumber = permitNumber;
            PermitYear = permitYear;
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
            ID = id;
            OfficeProjectDescription = officeProjectDescription;
            ProjectDescription = projectDescription;
            ContractorBusinessName = contractorBusinessName;
            ResultOfEnforcementAction = resultOfEnforcementAction;
        }

        public int ID { get; }
        public DateTime? PermitIssueDate { get; }
        public DateTime? ApplicationDate { get;}

        public decimal? AssessorParcelNumber { get; }
        public string ApplicantBusinessName { get; }
        public string ResultOfEnforcementAction { get; }
        public string ContractorBusinessName { get; }
        public decimal? ApplicationNumber { get; }
        public decimal? AddendumNumber { get; }
        public string PermitCode { get; }
        public string PermitStatus { get; }
        public decimal? ApplicationYear { get; }
        public decimal? PermitYear { get; }
        public decimal? PermitNumber { get; }
        public string ApplicationName { get; }
        public string BuildingApprovalRequired { get; }
        public string BuildingApprovalDate { get; }

        public string FireMarchalRequired { get; }
        public string FireMarshalDate { get; }

        public string PlanningApprovalRequired { get; }
        public string PlanningApprovalDate { get; }

        public string HealthApprovalRequired { get; }
        public string HealthApprovalDate { get; }

        public string AssessorApprovalRequired { get; }
        public string AssessorApprovalDate { get; }

        public string PublicWorkApprovalRequired { get; }
        public string PublicWorkApprovalDate { get; }

        public string CityJurisdictionApprovalRequired { get; }
        public string CityJurisdictionApprovalDate { get; }
        public string CityUtilityApprovalRequired { get; }
        public string CityUtilityApprovalDate { get; }

        public string OfficeProjectDescription { get; private set; }

        public string ProjectDescription { get; private set; }
    }
}