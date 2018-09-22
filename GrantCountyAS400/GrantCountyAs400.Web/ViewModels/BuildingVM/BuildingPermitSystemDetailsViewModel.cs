using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemDetailsViewModel
    {
        public string PermitCode { get; set; }
        public string ProcessedForJurisdiction { get; set; }

        [Display(Name = "Application Date")]
        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; }

        [Display(Name = "App Entry User")]
        public string ApplicationUserId { get; set; }

        [Display(Name = "Business Name")]
        public string ApplicantBusinessName { get; set; }

        public string ApplicantLastName { get; set; }
        public string ApplicantFirstName { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        [Display(Name = "Phone #")]
        public decimal PhoneNumber { get; set; }

        [Display(Name = "Preliminary Parcel #")]
        public decimal PreliminaryParcelNumber { get; set; }

        public decimal AssessorParcelNumber { get; set; }

        [Display(Name = "Additional Project Information")]
        public string AdditionalInformation { get; set; }

        [Display(Name = "Park Info")]
        public string ParkInformation { get; set; }

        [Display(Name = "Application Name")]
        public string ApplicationName { get; set; }

        public string ContractLicenseNumber { get; set; }

        [Display(Name = "Owner")]
        public string ContractorBusinessName { get; set; }

        public string ArchitectFirmNumber { get; set; }
        public string ArchitectBusinessName { get; set; }
        public string EngineerFirmNumber { get; set; }
        public string EngineerBusinessName { get; set; }

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

        public string PermitDescription { get; set; }

        public string ProcessedForJurisdictionShortDepartmentName { get; set; }
        private BuildingPermitSystemDetailsHeaderViewModel _buildingPermitSystemDetailsHeaderViewModel;

        public BuildingPermitSystemDetailsHeaderViewModel BuildingPermitSystemDetailsHeaderViewModel
        {
            get { return _buildingPermitSystemDetailsHeaderViewModel; }
            set
            {
                if (_buildingPermitSystemDetailsHeaderViewModel == null)
                    _buildingPermitSystemDetailsHeaderViewModel = new BuildingPermitSystemDetailsHeaderViewModel();
            }
        }

        [Display(Name = "For Jurisdiction")]
        public string ForJurisdiction => $"{ProcessedForJurisdiction} - {ProcessedForJurisdictionShortDepartmentName}";

        [Display(Name = "Preliminary Parcel #")]
        public string PreliminaryParcelDisplay => $"{PreliminaryParcelNumber} - {PreliminaryValueMasterName.Description1}";

        public string PreliminaryParcelNameDisplay => $"{PreliminaryValueMasterName.TitleOwnerName} - {PreliminaryValueMasterName.Description2}";

        [Display(Name = "Assessor Parcel #")]
        public string AssessorParcelDisplay => $"{AssessorParcelNumber} - {AssessorValueMasterName.Description1}";

        public string AssessorParcelNameDisplay => $"{AssessorValueMasterName.TitleOwnerName} - {AssessorValueMasterName.Description2}";

        [Display(Name = "Situs Address")]
        public string SitusAddressDisplay => $"{SitusAddress.HouseNumber} - {SitusAddress.StreetDirectionQuadrant} - {SitusAddress.LocationCode}";

        [Display(Name = "City/State/Zipcode")]
        public string CityStateZip => $"{City} / {State} / {ZipCode}";

        [Display(Name = "Applicant Name")]
        public string ApplicantName => $"{ApplicantLastName}, {ApplicantFirstName}";

        [Display(Name = "Permit Type")]
        public string PermitType => $"{PermitCode} - {PermitDescription}";

        [Display(Name = "Result of Enforcement Action?")]
        public string EnforcementActionDisplay => (ResultOfEnforcementAction == "N")
            ? $"{ResultOfEnforcementAction}" : $"{ResultOfEnforcementAction}" + $"{EnforcementDescription}";

        [Display(Name = "Engineer")]
        public string EngineerDisplay => $"{EngineerFirmNumber} {EngineerBusinessName}";

        [Display(Name = "Architect")]
        public string ArchitectDisplay => $"{ArchitectFirmNumber} {ArchitectBusinessName}";

        [Display(Name = "Gen. Contractor")]
        public string ContractorDisplay => $"{ContractLicenseNumber} {ContractorBusinessName}";

        public BuildingValueMasterNameInfoViewModel PreliminaryValueMasterName { get; set; }
        public BuildingValueMasterNameInfoViewModel AssessorValueMasterName { get; set; }
        public BuildingSitusAddressInfoViewModel SitusAddress { get; set; }
        public BuildingPermitSystemApprovalStatusViewModel ApprovalStatus { get; set; }
    }

    public class BuildingValueMasterNameInfoViewModel
    {
        public string TitleOwnerName { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }

    public class BuildingSitusAddressInfoViewModel
    {
        public decimal HouseNumber { get; set; }
        public string StreetDirectionQuadrant { get; set; }
        public string LocationCode { get; set; }
    }

    public class BuildingPermitSystemApprovalStatusViewModel
    {
        [Display(Name = "Planning")]
        public ApprovalStatusViewModel Planning { get; set; }

        [Display(Name = "Health Dept")]
        public ApprovalStatusViewModel Health { get; set; }

        [Display(Name = "Assessor")]
        public ApprovalStatusViewModel Assessor { get; set; }

        [Display(Name = "Public Works")]
        public ApprovalStatusViewModel PublicWroks { get; set; }

        [Display(Name = "City Jurisdiction")]
        public ApprovalStatusViewModel CityJurisdiction { get; set; }

        [Display(Name = "Arch/Engin Stamp")]
        public ApprovalStatusViewModel Architect { get; set; }

        [Display(Name = "Fire Safety Insp")]
        public ApprovalStatusViewModel Fire { get; set; }

        [Display(Name = "Other L&I Permit")]
        public ApprovalStatusViewModel LI { get; set; }

        [Display(Name = "City Utility")]
        public ApprovalStatusViewModel CityUtility { get; set; }

        [Display(Name = "Property Owner")]
        public ApprovalStatusViewModel Owner { get; set; }

        [Display(Name = "Other Special")]
        public ApprovalStatusViewModel OtherSpecial { get; set; }

        public string OtherSpecialDescription { get; set; }

        [Display(Name = "Application Accepted?")]
        public ApprovalStatusViewModel Application { get; }
    }

    public class ApprovalStatusViewModel
    {
        public string Required { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        public string User { get; set; }
    }
}