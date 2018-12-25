using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Application Date")]
        public DateTime? ApplicationDate { get; set; }

        [Display(Name = "Issue Date")]
        public DateTime? PermitIssueDate { get; set; }

        [Display(Name ="Assessor Parcel Number")]
        public int AssessorParcelNumber { get; set; }

        [Display(Name = "#")]
        public decimal? ApplicationNumber { get; set; }

        [Display(Name ="App #")]
        public string ApplicationNumberDisplay { get { return ApplicationYear + (ApplicationNumber.HasValue? "-" + ApplicationNumber:""); } }

        [Display(Name = "Business Name")]
        public string ApplicantBusinessName { get; set; }

        [Display(Name = "Type")]
        public string PermitCode { get; set; }

        [Display(Name = "Status")]
        public string PermitStatus { get; set; }

        [Display(Name = "Year")]
        public decimal? ApplicationYear { get; set; }

        [Display(Name = "Permit #")]
        public decimal? PermitNumber { get; set; }

        [Display(Name = "Permit #")]
        public string PermitNumberDisplay { get { return (PermitYear.HasValue && PermitYear.Value!=0 ? PermitYear.Value.ToString() : "") + "-" + (PermitNumber.HasValue && PermitNumber.Value!=0?PermitNumber.Value.ToString():""); } }

        [Display(Name ="Permit Year")]
        public decimal? PermitYear { get; set; }

        [Display(Name = "Application Name")]
        public string ApplicationName { get; set; }

        public string BuildingApprovalRequired { get; set; }
        public string BuildingApprovalDate { get; set; }

        public string FireMarchalRequired { get; set; }
        public string FireMarshalDate { get; set; }

        public string PlanningApprovalRequired { get; set; }
        public string PlanningApprovalDate { get; set; }

        public string HealthApprovalRequired { get; set; }
        public string HealthApprovalDate { get; set; }

        public string AssessorApprovalRequired { get; set; }
        public string AssessorApprovalDate { get; set; }

        public string PublicWorkApprovalRequired { get; set; }
        public string PublicWorkApprovalDate { get; set; }

        public string CityJurisdictionApprovalDate { get; set; }

        public string CityUtilityApprovalDate { get; set; }

        [Display(Name = "Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name = "Project Description")]
        public string ProjectDescription { get; set; }

        [Display(Name = "Contractor Name")]
        public string ContractorBusinessName { get; set; }

        [Display(Name = "Res. of Enf. action")]
        public string ResultOfEnforcementAction { get; set; }

    }
}