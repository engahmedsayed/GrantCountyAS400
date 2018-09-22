using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemApplicantDetailsViewModel
    {
        [Display(Name = "Application Name")]
        public string ApplicationName { get; set; }

        public string ContractLicenseNumber { get; set; }

        [Display(Name = "Owner")]
        public string ContractorBusinessName { get; set; }

        [Display(Name = "Gen. Contractor")]
        public string ContractorDisplay => $"{ContractLicenseNumber} {ContractorBusinessName}";

        public string ArchitectFirmNumber { get; set; }
        public string ArchitectBusinessName { get; set; }

        [Display(Name = "Architect")]
        public string ArchitectDisplay => $"{ArchitectFirmNumber} {ArchitectBusinessName}";

        public string EngineerFirmNumber { get; set; }
        public string EngineerBusinessName { get; set; }

        [Display(Name = "Engineer")]
        public string EngineerDisplay => $"{EngineerFirmNumber} {EngineerBusinessName}";

        [Display(Name = "Application Project Description")]
        public string ApplicantProjectDescription { get; set; }
        
        [Display(Name = "Result Of Enforcement Action?")]
        public string ResultOfEnforcementAction { get; set; }

        public string EnforcementDescription { get; set; }

        [Display(Name = "Plot Plan received")]
        public string PlotPlanReceived { get; set; }

        [Display(Name = "Only Structure On Parcel?")]
        public string OnlyStructureOnParcel { get; set; }

        [Display(Name = "Only Residence On Parcel?")]
        public string OnlyResidenceOnParcel { get; set; }

        [Display(Name = "Result of Enforcement Action?")]
        public string EnforcementActionDisplay => (ResultOfEnforcementAction == "N")
            ? $"{ResultOfEnforcementAction}" : $"{ResultOfEnforcementAction}" + $"{EnforcementDescription}";
    }
}