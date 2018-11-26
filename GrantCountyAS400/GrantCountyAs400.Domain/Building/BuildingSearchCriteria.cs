using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingSearchCriteria
    {
        public decimal? ApplicationNumber { get; private set; }
        public int? ApplicationYear { get; private set; }
        public decimal? PermitNumber { get; private set; }
        public string ApplicantBusinessName { get; private set; }
        public string ApplicantLastName { get; private set; }
        public string ApplicantFirstName { get; private set; }
        public decimal? PreliminaryParcelNumber { get; private set; }
        public decimal? AssessorParcelNumber { get; private set; }
        public string JurisdictionCode { get; private set; }

        public string OfficeProjectDescription { get; private set; }

        public string ProjectDescription { get; private set; }
        public string ContractorBusinessName { get; private set; }
        public string ResultOfEnforcementAction { get; private set; }

        public string CityJurisdictionApprovalRequired { get;private set; }

        public string CityUtilityApprovalRequired { get;private set; }
        public BuildingSearchCriteria(decimal? applicationNumber, int? applicationYear, decimal? permitNumber, string applicantBusinessName, string applicantLastName, 
                                      string applicantFirstName, decimal? preliminaryParcelNumber, decimal? assessorParcelNumber, string jurisdictionCode, 
                                      string officeProjectDescription, string projectDescription,string contractorBusinessName,string resultOfEnforcementAction,
                                      string cityJurisdictionApprovalRequired,string cityUtilityApprovalRequired)
        {
            ApplicationNumber = applicationNumber;
            ApplicationYear = applicationYear;
            PermitNumber = permitNumber;
            ApplicantBusinessName = applicantBusinessName;
            ApplicantLastName = applicantLastName;
            ApplicantFirstName = applicantFirstName;
            PreliminaryParcelNumber = preliminaryParcelNumber;
            AssessorParcelNumber = assessorParcelNumber;
            JurisdictionCode = jurisdictionCode;
            OfficeProjectDescription = officeProjectDescription;
            ProjectDescription = projectDescription;
            ContractorBusinessName = contractorBusinessName;
            ResultOfEnforcementAction = resultOfEnforcementAction;
            CityJurisdictionApprovalRequired = cityJurisdictionApprovalRequired;
            CityUtilityApprovalRequired = cityUtilityApprovalRequired;
        }
    }
}
