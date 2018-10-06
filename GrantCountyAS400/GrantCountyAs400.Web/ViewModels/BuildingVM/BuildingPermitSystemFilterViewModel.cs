using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemFilterViewModel
    {
        [Display(Name = "Application Year")]
        public int? ApplicationYear { get; set; }

        [Display(Name = "Application Number")]
        public decimal? ApplicationNumber { get; set; }

        [Display(Name = "Permit Number")]
        public decimal? PermitNumber { get; set; }

        [Display(Name = "Applicant Business Name")]
        public string ApplicantBusinessName { get; set; }

        [Display(Name = "Applicant Last Name")]
        public string ApplicantLastName { get; set; }

        [Display(Name = "Applicant First Name")]
        public string ApplicantFirstName { get; set; }

        [Display(Name = "Preliminary Parcel Number")]
        public decimal? PreliminaryParcelNumber { get; set; }

        [Display(Name = "Assessor Parcel Number")]
        public decimal? AssessorParcelNumber { get; set; }

        [Display(Name = "Jurisdiction Code")]
        public string JurisdictionCode { get; set; }
    }
}