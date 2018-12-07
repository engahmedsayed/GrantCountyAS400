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

        public int? PermitYear { get;private set; }
        public DateTime? FromDate { get; private set; }
        public DateTime? ToDate { get; private set; } 
        public decimal? PreliminaryParcelNumber { get; private set; }
        public decimal? AssessorParcelNumber { get; private set; }
        public decimal? StateClassCode { get; private set; }

        public string OfficeProjectDescription { get; private set; }

        public string ProjectDescription { get; private set; }
        public string ContractorBusinessName { get; private set; }
        public string EnforcementActionDesc { get; private set; }

        public string CityJurisdictionApproval { get;private set; }

        public string CityUtilityApproval { get;private set; }
        public BuildingSearchCriteria(decimal? applicationNumber, int? applicationYear, decimal? permitNumber, string applicantBusinessName, string applicantLastName, 
                                      string applicantFirstName,int?permitYear, decimal? preliminaryParcelNumber, decimal? assessorParcelNumber, decimal? stateClassCode, 
                                      string officeProjectDescription, string projectDescription,string contractorBusinessName,string enforcementActionDesc,
                                      string cityJurisdictionApproval,string cityUtilityApproval,DateTime? fromDate,DateTime? toDate)
        {
            ApplicationNumber = applicationNumber;
            ApplicationYear = applicationYear;
            PermitNumber = permitNumber;
            ApplicantBusinessName = applicantBusinessName;
            ApplicantLastName = applicantLastName;
            ApplicantFirstName = applicantFirstName;
            PreliminaryParcelNumber = preliminaryParcelNumber;
            AssessorParcelNumber = assessorParcelNumber;
            StateClassCode = stateClassCode;
            OfficeProjectDescription = officeProjectDescription;
            ProjectDescription = projectDescription;
            ContractorBusinessName = contractorBusinessName;
            EnforcementActionDesc = enforcementActionDesc;
            CityJurisdictionApproval = cityJurisdictionApproval;
            CityUtilityApproval = cityUtilityApproval;
            FromDate = fromDate;
            ToDate = toDate;
            PermitYear = permitYear;
        }
    }
}
