using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingPermitSystemDetails
    {
        public string ApplicantLastName { get; }
        public string ApplicantFirstName { get; }

        public IEnumerable<string> Notes { get; set; }
        public string PermitCode { get; }
        public string ProcessedForJurisdiction { get; }
        public DateTime ApplicationDate { get; }
        public string ApplicationUserId { get; }
        public string ApplicantBusinessName { get; }

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

        public string PermitDescription { get; }

        public string ProcessedForJurisdictionShortDepartmentName { get; }

        public BuildingPermitSystemBasicInfo BasicInfo { get; }
        public BuildingPermitSystemApplicantDetails ApplicantDetails { get; }
        public BuildingValueMasterNameInfo PreliminaryValueMasterName { get; }
        public BuildingValueMasterNameInfo AssessorValueMasterName { get; }
        public BuildingSitusAddressInfo SitusAddress { get; }
        public BuildingPermitSystemApprovalStatusInfo ApprovalStatus { get; }

        public PlanningApproval PlanningApproval { get; private set; }

        public AssessorApproval AssessorApproval { get; private set; }

        public PublicWorkApproval PublicWorkApproval { get;private set; }

        public HealthApproval HealthApproval { get; private set; }

        public CityApproval CityApproval { get; private set; }

        public void SetPlanningApproval(PlanningApproval planningApproval)
        {
            PlanningApproval = planningApproval;
        }

        public void SetAssessorApproval(AssessorApproval assessorApproval)
        {
            AssessorApproval = assessorApproval;
        }

        public void SetPublicWorkApproval(PublicWorkApproval publicWorkApproval)
        {
            PublicWorkApproval = publicWorkApproval;
        }

        public void SetHealthApproval(HealthApproval healthApproval)
        {
            HealthApproval = healthApproval;
        }

        public void SetCityApproval(CityApproval cityApproval)
        {
            CityApproval = cityApproval;
        }

        public BuildingPermitSystemDetails(string applicantLastName, string applicantFirstName, string permitCode, string processedForJurisdiction, DateTime applicationDate,
            string applicationUserId, string applicantBusinessName, string addressLine1, string addressLine2, string city, string state, string zipCode, decimal phoneNumber,
            decimal preliminaryParcelNumber, decimal assessorParcelNumber, string additionalInformation, string parkInformation, string permitDescription,
            string processedForJurisdictionShortDepartmentName, BuildingPermitSystemBasicInfo basicInfo, BuildingPermitSystemApplicantDetails applicantDetails,
            BuildingValueMasterNameInfo preliminaryValueMasterName, BuildingValueMasterNameInfo asessorValueMasterName, BuildingSitusAddressInfo situsAddress,
            BuildingPermitSystemApprovalStatusInfo approvalStatus)
        {
            ApplicantLastName = applicantLastName;
            ApplicantFirstName = applicantFirstName;
            PermitCode = permitCode;
            ProcessedForJurisdiction = processedForJurisdiction;
            ApplicationDate = applicationDate;
            ApplicationUserId = applicationUserId;
            ApplicantBusinessName = applicantBusinessName;
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

            PermitDescription = permitDescription;
            ProcessedForJurisdictionShortDepartmentName = processedForJurisdictionShortDepartmentName;

            BasicInfo = basicInfo;
            ApplicantDetails = applicantDetails;
            PreliminaryValueMasterName = preliminaryValueMasterName;
            AssessorValueMasterName = asessorValueMasterName;
            SitusAddress = situsAddress;
            ApprovalStatus = approvalStatus;
            
        }

    }

    public class BuildingPermitSystemBasicInfo
    {
        public string JurisdictionCode { get; }
        public string JurisidictionShortDepartmentName { get; }
        public decimal ApplicationYear { get; }
        public decimal ApplicationNumber { get; }
        public string DepartmentCode { get; }
        public string DepartmentShortDepartmentName { get; }
        public decimal AddendumNumber { get; }
        public string PermitStatus { get; }

        public decimal? PermitYear { get; }

        public decimal? PermitNumber { get; }

        public decimal? StateClassCode { get; }



        public BuildingPermitSystemBasicInfo(string jurisdictionCode, string departmentCode, decimal applicationYear, decimal applicationNumber, decimal addendumNumber,
            string permitStatus, string jurisidictionShortDepartmentName, string departmentShortDepartmentName, decimal?permitYear,decimal?permitNumber, decimal?stateClassCode)
        {
            JurisdictionCode = jurisdictionCode;
            DepartmentCode = departmentCode;
            ApplicationYear = applicationYear;
            ApplicationNumber = applicationNumber;
            PermitYear = permitYear;
            PermitNumber = permitNumber;
            StateClassCode = stateClassCode;
            AddendumNumber = addendumNumber;
            PermitStatus = permitStatus;
            JurisidictionShortDepartmentName = jurisidictionShortDepartmentName;
            DepartmentShortDepartmentName = departmentShortDepartmentName;
        }
    }

    public class BuildingPermitSystemApplicantDetails
    {
        public string ContractLicenseNumber { get; }
        public string ContractorBusinessName { get; }
        public string ApplicantProjectDescription { get; }

        public string AdditionalProjectInformation { get;}
        public string ResultOfEnforcementAction { get; }
        public string EnforcementDescription { get; }
        public string PlotPlanReceived { get; }
        public string OnlyStructureOnParcel { get; }
        public string OnlyResidenceOnParcel { get; }
        public string ArchitectFirmNumber { get; }
        public string ArchitectBusinessName { get; }
        public string EngineerBusinessName { get; }
        public string EngineerFirmNumber { get; }

        public BuildingPermitSystemApplicantDetails(string contractLicenseNumber,string additionalProjectInformation, string applicantProjectDescription, string resultOfEnforcementAction,
            string enforcementDescription, string plotPlanReceived, string onlyStructureOnParcel, string onlyResidenceOnParcel, string contractorBusinessName,
            string architectFirmNumber, string architectBusinessName, string engineerFirmNumber, string engineerBusinessName)
        {
            ContractLicenseNumber = contractLicenseNumber;
            ApplicantProjectDescription = applicantProjectDescription;
            AdditionalProjectInformation = additionalProjectInformation;
            ResultOfEnforcementAction = resultOfEnforcementAction;
            EnforcementDescription = enforcementDescription;
            PlotPlanReceived = plotPlanReceived;
            OnlyStructureOnParcel = onlyStructureOnParcel;
            OnlyResidenceOnParcel = onlyResidenceOnParcel;
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
        public decimal HouseNumber { get; }
        public string StreetDirectionQuadrant { get; }
        public string LocationCode { get; }
        public string StreetName { get; }
        public string LocationCityCode { get; }

        public BuildingSitusAddressInfo(decimal houseNumber, string streetDirectionQuadrant, string locationCode, string streetName, string locationCityCode)
        {
            HouseNumber = houseNumber;
            StreetDirectionQuadrant = streetDirectionQuadrant;
            LocationCode = locationCode;
            StreetName = streetName;
            LocationCityCode = locationCityCode;
        }
    }

    public class BuildingPermitSystemApprovalStatusInfo
    {
        public ApprovalStatusInfo Planning { get; }
        public ApprovalStatusInfo Health { get; }
        public ApprovalStatusInfo Assessor { get; }
        public ApprovalStatusInfo PublicWroks { get; }
        public ApprovalStatusInfo CityJurisdiction { get; }
        public ApprovalStatusInfo Architect { get; }
        public ApprovalStatusInfo Fire { get; }
        public ApprovalStatusInfo LI { get; }
        public ApprovalStatusInfo CityUtility { get; }
        public ApprovalStatusInfo Owner { get; }
        public ApprovalStatusInfo OtherSpecial { get; }
        public ApprovalStatusInfo Application { get; }
        public string OtherSpecialDescription { get; }

        public BuildingPermitSystemApprovalStatusInfo(
            ApprovalStatusInfo planning, ApprovalStatusInfo health, ApprovalStatusInfo assessor, ApprovalStatusInfo publicWroks, ApprovalStatusInfo cityJurisdiction,
            ApprovalStatusInfo architect, ApprovalStatusInfo fire, ApprovalStatusInfo li, ApprovalStatusInfo cityUtility, ApprovalStatusInfo owner,
            ApprovalStatusInfo otherSpecial, ApprovalStatusInfo application, string otherSpecialDescription)
        {
            Planning = planning;
            Health = health;
            Assessor = assessor;
            PublicWroks = publicWroks;
            CityJurisdiction = cityJurisdiction;
            Architect = architect;
            Fire = fire;
            LI = li;
            CityUtility = cityUtility;
            Owner = owner;
            OtherSpecial = otherSpecial;
            Application = application;
            OtherSpecialDescription = otherSpecialDescription;
        }
    }

    public class ApprovalStatusInfo
    {
        public string Required { get; }
        public DateTime? Date { get; }
        public string User { get; }

        public ApprovalStatusInfo(string required, DateTime? date, string user)
        {
            Required = required;
            Date = date;
            User = user;
        }
    }

    public class PlanningApproval
    {
        public string ApplicantProjectDescription{ get; }

        public string ZoneCode { get; }

        public decimal? FrontPropertySetback{ get; }

        public decimal? SideFlankingSetback { get;}

        public decimal? SidePropertySetback { get;}

        public decimal? BackPropertySetback { get; }

        public string FloodZone { get; }
        public string FloodZoneMapNumber { get;}
        public string LUPermitRequired { get;}

        public string Comments { get; }

        public string ApprovedBy { get;}

        public string UserID { get; }

        public DateTime? ChangeDate { get; }

        public PlanningApproval(string applicantProjectDescription, string zoneCode, decimal? frontPropertySetback,
                                decimal? sideFlankingSetback, decimal? sidePropertySetback, decimal? backPropertySetback,
                                string floodZone, string floodZoneMapNumber, string lUPermitRequired, string comments,
                                string approvedBy, string userID, DateTime? changeDate)
        {
            ApplicantProjectDescription = applicantProjectDescription;
            ZoneCode = zoneCode;
            FrontPropertySetback = frontPropertySetback;
            SideFlankingSetback = sideFlankingSetback;
            SidePropertySetback = sidePropertySetback;
            BackPropertySetback = backPropertySetback;
            FloodZone = floodZone;
            FloodZoneMapNumber = floodZoneMapNumber;
            LUPermitRequired = lUPermitRequired;
            Comments = comments;
            ApprovedBy = approvedBy;
            UserID = userID;
            ChangeDate = changeDate;
        }
    }

    public class AssessorApproval
    {
        public string ApplicantProjectDescription { get; }

        public string Comments { get; }
        public string ApprovedBy { get; }

        public string UserID { get; }

        public DateTime? ChangeDate { get; }

        public decimal? AssessorParcelNumber { get; }

        public string Name { get;}

        public string Description1 { get;}

        public string Description2 { get; }

        public AssessorApproval(string applicantProjectDescription, string comments, string approvedBy, string userID,
            DateTime? changeDate, decimal? assessorParcelNumber, string name, string description1, string description2)
        {
            ApplicantProjectDescription = applicantProjectDescription;
            Comments = comments;
            ApprovedBy = approvedBy;
            UserID = userID;
            ChangeDate = changeDate;
            AssessorParcelNumber = assessorParcelNumber;
            Name = name;
            Description1 = description1;
            Description2 = description2;
        }

    }

    public class PublicWorkApproval
    {
        public string ApplicantProjectDescription { get; }

        public string Comments { get; }
        public string ApprovedBy { get; }

        public string UserID { get; }

        public DateTime? ChangeDate { get; }



        public PublicWorkApproval(string applicantProjectDescription, string comments, string approvedBy, string userID,
            DateTime? changeDate)
        {
            ApplicantProjectDescription = applicantProjectDescription;
            Comments = comments;
            ApprovedBy = approvedBy;
            UserID = userID;
            ChangeDate = changeDate;
        }

    }

    public class HealthApproval
    {
        public string ApplicantProjectDescription { get; }

        public string Comments { get; }
        public string ApprovedBy { get; }

        public string UserID { get; }

        public DateTime? ChangeDate { get; }



        public HealthApproval(string applicantProjectDescription, string comments, string approvedBy, string userID,
            DateTime? changeDate)
        {
            ApplicantProjectDescription = applicantProjectDescription;
            Comments = comments;
            ApprovedBy = approvedBy;
            UserID = userID;
            ChangeDate = changeDate;
        }

    }

    public class CityApproval
    {
        public string ApplicantProjectDescription { get; }
        public string JurisdictionCode { get; }
        public string ShortDepartmentName { get;}
        public string ZoniongApproval { get;}
        public string UtilitiesApproval { get;}
        public string Comments { get; }
        public string ApprovedBy { get; }
        public string UserID { get; }
        public DateTime? ChangeDate { get; }
        public string CityCode { get; }

        public CityApproval(string applicantProjectDescription, string jurisdictionCode, string shortDepartmentName,
                            string zoniongApproval, string utilitiesApproval, string comments, string approvedBy,
                            string userID, DateTime? changeDate, string cityCode)
        {
            ApplicantProjectDescription = applicantProjectDescription;
            JurisdictionCode = jurisdictionCode;
            ShortDepartmentName = shortDepartmentName;
            ZoniongApproval = zoniongApproval;
            UtilitiesApproval = utilitiesApproval;
            Comments = comments;
            ApprovedBy = approvedBy;
            UserID = userID;
            ChangeDate = changeDate;
            CityCode = cityCode;
        }
    }
}