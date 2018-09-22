using System;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingPermitSystemDetails
    {
        public string JurisdictionCode { get; }
        public string DepartmentCode { get; }
        public decimal ApplicationYear { get; }
        public decimal ApplicationNumber { get; }
        public decimal AddendumNumber { get; }
        public string PermitStatus { get; }
        public string PermitCode { get; }
        public string ProcessedForJurisdiction { get; }
        public DateTime ApplicationDate { get; }
        public string ApplicationUserId { get; }
        public string ApplicantBusinessName { get; }
        public string ApplicantLastName { get; }
        public string ApplicantFirstName { get; }
        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public decimal PhoneNumber { get; }
        public decimal PreliminaryParcelNumber { get; }
        public decimal AssessorParcelNumber { get; }
        public string AdditionalInformation { get; }
        public string ParkInformation { get; }
        public string ApplicationName { get; }
        public string ContractLicenseNumber { get; }
        public string ApplicantProjectDescription { get; }
        public string ResultOfEnforcementAction { get; }
        public string EnforcementDescription { get; }
        public string PlotPlanReceived { get; }
        public string OnlyStructureOnParcel { get; }
        public string OnlyResidenceOnParcel { get; }

        public string PermitDescription { get; }
        public string JurisidictionShortDepartmentName { get; }
        public string DepartmentShortDepartmentName { get; }
        public string ProcessedForJurisdictionShortDepartmentName { get; }

        public string ApplicantName => $"{ApplicantLastName}, {ApplicantFirstName}";
        public BuildingValueMasterNameInfo PreliminaryValueMasterName { get; }
        public BuildingValueMasterNameInfo AssessorValueMasterName { get; }
        public BuildingSitusAddressInfo SitusAddress { get; }

        public string ContractorBusinessName { get; }

        public string ArchitectFirmNumber { get; }
        public string ArchitectBusinessName { get; }

        public string EngineerBusinessName { get; }
        public string EngineerFirmNumber { get; }

        public BuildingPermitSystemDetails(string jurisdictionCode, string departmentCode, decimal applicationYear, decimal applicationNumber, decimal addendumNumber,
            string permitStatus, string permitCode, string processedForJurisdiction, DateTime applicationDate, string applicationUserId, string applicantBusinessName,
            string applicantLastName, string applicantFirstName, string addressLine1, string addressLine2, string city, string state, string zipCode, decimal phoneNumber,
            decimal preliminaryParcelNumber, decimal assessorParcelNumber, string additionalInformation, string parkInformation,
            string contractLicenseNumber, string applicantProjectDescription, string resultOfEnforcementAction, string enforcementDescription, string plotPlanReceived,
            string onlyStructureOnParcel, string onlyResidenceOnParcel,

            string permitDescription, string jurisidictionShortDepartmentName, string departmentShortDepartmentName, string processedForJurisdictionShortDepartmentName,
            BuildingValueMasterNameInfo preliminaryValueMasterName, BuildingValueMasterNameInfo asessorValueMasterName,
            BuildingSitusAddressInfo situsAddress, string contractorBusinessName, string architectFirmNumber, string architectBusinessName,
            string engineerFirmNumber, string engineerBusinessName
            )
        {
            JurisdictionCode = jurisdictionCode;
            DepartmentCode = departmentCode;
            ApplicationYear = applicationYear;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            PermitStatus = permitStatus;
            PermitCode = permitCode;
            ProcessedForJurisdiction = processedForJurisdiction;
            ApplicationDate = applicationDate;
            ApplicationUserId = applicationUserId;
            ApplicantBusinessName = applicantBusinessName;
            ApplicantLastName = applicantLastName;
            ApplicantFirstName = applicantFirstName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
            PreliminaryParcelNumber = preliminaryParcelNumber;
            AssessorParcelNumber = assessorParcelNumber;
            AdditionalInformation = additionalInformation;
            ParkInformation = parkInformation;
            ContractLicenseNumber = contractLicenseNumber;
            ApplicantProjectDescription = applicantProjectDescription;
            ResultOfEnforcementAction = resultOfEnforcementAction;
            EnforcementDescription = enforcementDescription;
            PlotPlanReceived = plotPlanReceived;
            OnlyStructureOnParcel = onlyStructureOnParcel;
            OnlyResidenceOnParcel = onlyResidenceOnParcel;

            PermitDescription = permitDescription;
            JurisidictionShortDepartmentName = jurisidictionShortDepartmentName;
            DepartmentShortDepartmentName = departmentShortDepartmentName;
            ProcessedForJurisdictionShortDepartmentName = processedForJurisdictionShortDepartmentName;

            PreliminaryValueMasterName = preliminaryValueMasterName;
            AssessorValueMasterName = asessorValueMasterName;
            SitusAddress = situsAddress;

            ContractorBusinessName = contractorBusinessName;
            ArchitectFirmNumber = architectFirmNumber;
            ArchitectBusinessName = architectBusinessName;
            EngineerBusinessName = engineerBusinessName;
        }
    }

    public class BuildingValueMasterNameInfo
    {
        public string TitleOwnerName { get; }
        public string Description1 { get; }
        public string Description2 { get; }

        public BuildingValueMasterNameInfo(string titleOwnerName, string description1, string description2)
        {
            TitleOwnerName = titleOwnerName;
            Description1 = description1;
            Description2 = description2;
        }
    }

    public class BuildingSitusAddressInfo
    {
        public decimal HouseNumber { get; set; }
        public string StreetDirectionQuadrant { get; set; }
        public string LocationCode { get; set; }

        public BuildingSitusAddressInfo(decimal houseNumber, string streetDirectionQuadrant, string locationCode)
        {
            HouseNumber = houseNumber;
            StreetDirectionQuadrant = streetDirectionQuadrant;
            LocationCode = locationCode;
        }
    }
}