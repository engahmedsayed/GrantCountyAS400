using System;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingSearchCriteria
    {
        public decimal? ApplicationNumber { get; }
        public int? ApplicationYear { get; }
        public decimal? PermitNumber { get; }
        public string ApplicantBusinessName { get; }
        public string ApplicantLastName { get; }
        public string ApplicantFirstName { get; }

        public int? PermitYear { get; }
        public DateTime? FromDate { get; }
        public DateTime? ToDate { get; }
        public decimal? PreliminaryParcelNumber { get; }
        public decimal? AssessorParcelNumber { get; }
        public decimal? StateClassCode { get; }

        public string OfficeProjectDescription { get; }

        public string ProjectDescription { get; }
        public string ContractorBusinessName { get; }
        public string EnforcementActionDesc { get; }

        public string CityApproval { get; }

        public BuildingSearchCriteria(
            decimal? applicationNumber, int? applicationYear, decimal? permitNumber, string applicantBusinessName, string applicantLastName, string applicantFirstName,
            int? permitYear, decimal? preliminaryParcelNumber, decimal? assessorParcelNumber, decimal? stateClassCode, string officeProjectDescription,
            string projectDescription, string contractorBusinessName, string enforcementActionDesc, string cityApproval, DateTime? fromDate, DateTime? toDate)
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
            CityApproval = cityApproval;
            FromDate = fromDate;
            ToDate = toDate;
            PermitYear = permitYear;
        }
    }
}