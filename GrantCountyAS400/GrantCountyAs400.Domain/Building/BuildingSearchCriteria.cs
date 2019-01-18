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

        public DateTime? ApplicationDateFrom { get; }
        
        public DateTime? ApplicationDateTo { get; }

        public decimal? AssessorParcelFrom { get;}

        public decimal? AssessorParcelTo { get; }
        public decimal? PreliminaryParcelNumber { get; }
        public decimal? StateClassCode { get; }

        public string OfficeProjectDescription { get; }

        public string ProjectDescription { get; }
        public string ContractorBusinessName { get; }
        public string EnforcementAction { get; }

        public string CityApproval { get; }

        public BuildingSearchCriteria(
            decimal? applicationNumber, int? applicationYear, decimal? permitNumber, string applicantBusinessName, string applicantLastName, string applicantFirstName,
            int? permitYear, decimal? preliminaryParcelNumber,  decimal? stateClassCode, string officeProjectDescription,
            string projectDescription, string contractorBusinessName, string enforcementAction, string cityApproval, DateTime? fromDate, DateTime? toDate,
            DateTime? applicationDateFrom,DateTime? applicationDateTo,decimal? assessorParcelFrom, decimal? assessorParcelTo)
        {
            ApplicationNumber = applicationNumber;
            ApplicationYear = applicationYear;
            PermitNumber = permitNumber;
            ApplicantBusinessName = applicantBusinessName;
            ApplicantLastName = applicantLastName;
            ApplicantFirstName = applicantFirstName;
            PreliminaryParcelNumber = preliminaryParcelNumber;
            StateClassCode = stateClassCode;
            OfficeProjectDescription = officeProjectDescription;
            ProjectDescription = projectDescription;
            ContractorBusinessName = contractorBusinessName;
            EnforcementAction = enforcementAction;
            CityApproval = cityApproval;
            FromDate = fromDate;
            ToDate = toDate;
            ApplicationDateFrom = applicationDateFrom;
            ApplicationDateTo = applicationDateTo;
            PermitYear = permitYear;
            AssessorParcelFrom = assessorParcelFrom;
            AssessorParcelTo = assessorParcelTo;
        }
    }
}