using System;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class BuildingPermitSystemMapper
    {
        internal static BuildingPermitSystem Map(BldgpermitApplicationMaster appm,string officeProjectDesc,string contractorBusinessName) =>
            new BuildingPermitSystem(appm.Id, appm.PermitIssuedDate,appm.ApplicationDate,appm.AssessorParcelNumber,appm.ApplicantBusinessName, appm.ApplicationNumber, appm.AddendumNumber, appm.PermitCode,
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "A" ? "Applica" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "D" ? "VoidApp" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "E" ? "ExpApp" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "W" ? "Working" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "V" ? "VoidPer" : appm.PermitStatus.ToUpper() == "U" ? "ExpPer" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "F" ? "Final" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "C" ? "Closed" : "",
                                  appm.ApplicationYear, appm.PermitNumber,appm.PermitYear, appm.ApplicantLastName + ", " + appm.ApplicantFirstName,
                                  !string.IsNullOrWhiteSpace(appm.BuildingApprovalRequired) &&
                                  appm.BuildingApprovalRequired.ToUpper() == "Y" ? "R" : "", appm.BuildingApprovalDate != null ? "A" : "",
                                  !string.IsNullOrWhiteSpace(appm.FireMarshalApprovalRequired) &&
                                  appm.FireMarshalApprovalRequired.ToUpper() == "Y" ? "R" : "", appm.FireMarshalApprovalDate != null ? "A" : "",
                                  string.IsNullOrWhiteSpace(appm.PlanningApprovalRequired) && appm.PlanningApprovalRequired.ToUpper() == "Y" ? "R" : "",
                                  appm.PlanningApprovalDate != null ? "A" : "", !string.IsNullOrWhiteSpace(appm.HealthApprovalRequired) &&
                                  appm.HealthApprovalRequired.ToUpper() == "Y" ? "R" : "", appm.HealthApprovalRequiredDate != null ? "A" : "",
                                  !string.IsNullOrWhiteSpace(appm.AssessorApprovalRequired) && appm.AssessorApprovalRequired.ToUpper() == "Y" ? "R" : "",
                                  appm.AssessorApprovalDate != null ? "A" : "", !string.IsNullOrWhiteSpace(appm.PublicWroksApprovalRequired) &&
                                  appm.PublicWroksApprovalRequired.ToUpper() == "Y" ? "R" : "", appm.PublicWroksApprovalDate != null ? "A" : "",
                                  !string.IsNullOrWhiteSpace(appm.CityJurisdictionApprovalRequired) &&
                                  appm.CityJurisdictionApprovalRequired.ToUpper() == "Y" ? "R" : "",
                                  appm.CityJurisdictionApprovalDate != null ? "A" : "",
                                  !string.IsNullOrWhiteSpace(appm.CityUtilityApprovalRequired) && appm.CityUtilityApprovalRequired.ToUpper() == "Y" ? "R" : "",
                                  appm.CityUtilityApprovalDate != null ? "A" : "",officeProjectDesc,appm.ApplicantProjectDescription,contractorBusinessName,
                                  appm.ResultOfEnforcementAction);

        internal static BuildingPermitSystemDetails Map(BldgpermitApplicationMaster bldgpermit,
                                                        ASMTValueMasterNameView preliminaryValueMaster,
                                                        ASMTValueMasterNameView assessorValueMaster,
                                                        Bldgjurisdictions juri,
                                                        Bldgjurisdictions processedJuri,
                                                        Bldgdepartments dept,
                                                        BldgpermitCodes perm,
                                                        AsmtsitusAddress situs,
                                                        AsmtcityCodeFile cityCode,
                                                        BldgmobileHomeDealersInstallersArchitects mdia,
                                                        BldgmobileHomeDealersInstallersArchitects mdiaBusinessEngineer,
                                                        Bldgcontractors bldgContractor,
                                                        AsmtrealPropertyAssessedValueMaster rpmas,
                                                        AsmtmasterNameAddress nName,BldgstateClassifications bldgstateClassification) =>
            new BuildingPermitSystemDetails(bldgpermit.ApplicantLastName, bldgpermit.ApplicantFirstName, bldgpermit.PermitCode.Trim(), bldgpermit.ProcessedForJurisdiction,
                bldgpermit.ApplicationDate.Value, bldgpermit.ApplicationUserId, bldgpermit.ApplicantBusinessName, bldgpermit.AddressLine1, bldgpermit.AddressLine2,
                bldgpermit.City, bldgpermit.State, bldgpermit.ZipCode, bldgpermit.PhoneNumber.Value, bldgpermit.PreliminaryParcelNumber.Value,
                bldgpermit.AssessorParcelNumber.Value, bldgpermit.AdditionalInformation, bldgpermit.ParkInformation, perm.PermitDescription, processedJuri.ShortDepartmentName,
                MapToBasicInfo(bldgpermit, juri, dept,bldgstateClassification), MapToApplicantDetails(bldgpermit, mdia, mdiaBusinessEngineer, bldgContractor), Map(preliminaryValueMaster),
                Map(assessorValueMaster), Map(situs, cityCode),
                MapToApprovalStatus(bldgpermit));

        public static BuildingPermitSystemBasicInfo MapToBasicInfo(BldgpermitApplicationMaster bldgpermit,
                                                                    Bldgjurisdictions juri,
                                                                    Bldgdepartments dept,BldgstateClassifications bldgstateClassification) =>
            new BuildingPermitSystemBasicInfo(bldgpermit.JurisdictionCode, bldgpermit.DepartmentCode, bldgpermit.ApplicationYear.Value, bldgpermit.ApplicationNumber.Value,
                bldgpermit.AddendumNumber.Value, bldgpermit.PermitStatus, juri.ShortDepartmentName, dept.ShortDepartmentName,bldgpermit.PermitYear,bldgpermit.PermitNumber,bldgpermit.StateClassCode,
                bldgstateClassification.ClassificationDescription,bldgpermit.PermitIssuedDate);

        private static BuildingPermitSystemApplicantDetails MapToApplicantDetails(BldgpermitApplicationMaster bldgpermit,
                                                                                  BldgmobileHomeDealersInstallersArchitects mdia,
                                                                                  BldgmobileHomeDealersInstallersArchitects mdiaBusinessEngineer,
                                                                                  Bldgcontractors bldgContractor) =>
            new BuildingPermitSystemApplicantDetails(bldgpermit.ContractLicenseNumber,bldgpermit.ProjectInformation,
                bldgpermit.ApplicantProjectDescription, bldgpermit.ResultOfEnforcementAction, bldgpermit.EnforcementDescription, bldgpermit.PlotPlanReceived,
                bldgpermit.OnlyStructureOnParcel, bldgpermit.OnlyResidenceOnParcel, bldgContractor?.ContractorBusinessName,
                bldgpermit.ArchitectFirmNumber, mdia?.BusinessName, bldgpermit.EngineerFirmNumber, mdiaBusinessEngineer?.BusinessName);

        private static BuildingValueMasterNameInfo Map(ASMTValueMasterNameView valueMaster) =>
            new BuildingValueMasterNameInfo(valueMaster?.TitleOwnerName, valueMaster?.Description1.Trim(), valueMaster?.Description2.Trim());

        private static BuildingSitusAddressInfo Map(AsmtsitusAddress situs, AsmtcityCodeFile cityCode) =>
            (situs == null) ?
            null :
            new BuildingSitusAddressInfo(situs.HouseNumber.Value,situs.HouseNumberExtension, situs.StreetDirectionQuadrant, situs.LocationCode, situs.StreetName, cityCode?.LocationCityCode);

        private static BuildingPermitSystemApprovalStatusInfo MapToApprovalStatus(BldgpermitApplicationMaster bldgpermit) =>
            new BuildingPermitSystemApprovalStatusInfo(
                new ApprovalStatusInfo(bldgpermit.PlanningApprovalRequired, bldgpermit.PlanningApprovalDate, bldgpermit.PlanningApprovalUser),
                new ApprovalStatusInfo(bldgpermit.HealthApprovalRequired, bldgpermit.HealthApprovalRequiredDate, bldgpermit.HealthApprovalRequiredUser),
                new ApprovalStatusInfo(bldgpermit.AssessorApprovalRequired, bldgpermit.AssessorApprovalDate, bldgpermit.AssessorApprovalUser),
                new ApprovalStatusInfo(bldgpermit.PublicWroksApprovalRequired, bldgpermit.PublicWroksApprovalDate, bldgpermit.PublicWroksApprovalUser),
                new ApprovalStatusInfo(bldgpermit.CityJurisdictionApprovalRequired, bldgpermit.CityJurisdictionApprovalDate, bldgpermit.CityJurisdictionApprovalUser),
                new ApprovalStatusInfo(bldgpermit.ArchitectApprovalRequired, bldgpermit.ArchitectApprovalDate, bldgpermit.ArchitectApprovalUser),
                new ApprovalStatusInfo(bldgpermit.FireApprovalRequired, bldgpermit.FireApprovalRequiredDate, bldgpermit.FireApprovalRequiredUser),
                new ApprovalStatusInfo(bldgpermit.LIapprovalRequired, bldgpermit.LIapprovalRequiredDate, bldgpermit.LIapprovalRequiredUser),
                new ApprovalStatusInfo(bldgpermit.CityUtilityApprovalRequired, bldgpermit.CityUtilityApprovalDate, bldgpermit.CityUtilityApprovalUser),
                new ApprovalStatusInfo(bldgpermit.OwnerApprovalRequired, bldgpermit.OwnerApprovalRequiredDate, bldgpermit.OwnerApprovalRequiredUser),
                new ApprovalStatusInfo(bldgpermit.OtherSpecialApprovalRequired, bldgpermit.OtherSpecialApprovalRequiredDate, bldgpermit.OtherSpecialApprovalRequiredUser),
                new ApprovalStatusInfo(bldgpermit.ApplicationAccepted, bldgpermit.ApplicationAcceptedDate, bldgpermit.ApplicationAcceptedUserId),
                bldgpermit.OtherSpecialApprovalDescription);

        public static PlanningApproval MapToPlanningApproval(BldgplanningApproval plap, BldgpermitApplicationMaster appm) =>
            new PlanningApproval(appm?.ApplicantProjectDescription, plap?.ZoneCode, plap?.FrontPropertySetback, plap?.SideFlankingSetback,
                                 plap?.SidePropertySetback, plap?.BackPropertySetback, plap?.FloodZone, plap?.FloodZoneMapNumber,
                                 plap?.LUpermitRequired, plap?.Comments, plap?.ApprovedBy, plap?.UserId, plap?.ChangeDate);

        public static AssessorApproval MaptToAssessorApproval(AsmtrealPropertyAssessedValueMaster rpmas, BldgassessorApproval assessorApproval,
                                                        AsmtmasterNameAddress nName, BldgpermitApplicationMaster appm) =>
            new AssessorApproval(appm?.ApplicantProjectDescription, assessorApproval?.Comments, assessorApproval?.ApprovedByAssr,
                                 assessorApproval?.UserIdassr, assessorApproval?.ChangeDate, appm?.AssessorParcelNumber, nName?.Name,
                                 rpmas?.Description1, rpmas?.Description2);

        internal static PublicWorkApproval MapToPublicWorkApproval(BldgpermitApplicationMaster appm,
            BldgpublicWorksApproval publicWorkRecord) =>
            new PublicWorkApproval(appm?.ApplicantProjectDescription, publicWorkRecord?.Comments, publicWorkRecord?.ApprovedBy,
                                 publicWorkRecord?.UserId, publicWorkRecord?.ChangeDate);

        internal static HealthApproval MapToHealthApproval(BldgpermitApplicationMaster appm,
                                        BldghealthApproval healthRecord) =>
            new HealthApproval(appm?.ApplicantProjectDescription, healthRecord?.Comments, healthRecord?.ApprovedBy,
                                 healthRecord?.UserId, healthRecord?.ChangeDate);

        internal static CityApproval MapToCityApproval(
            BldgpermitApplicationMaster appm, BldgcityApproval cityJoinRecord, Bldgjurisdictions jurisdictionRecord)
                => new CityApproval(appm?.ApplicantProjectDescription, cityJoinRecord?.JurisdictionCode, jurisdictionRecord?.ShortDepartmentName,
                    cityJoinRecord?.ZoningApproval, cityJoinRecord?.UtilitiesApproval, cityJoinRecord?.Comments, cityJoinRecord?.ApprovedBy, cityJoinRecord?.UserId,
                    cityJoinRecord?.ChangeDate, cityJoinRecord?.CityCode);


    }
}