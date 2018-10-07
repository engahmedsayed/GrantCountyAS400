using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class BuildingPermitSystemMapper
    {
        internal static BuildingPermitSystem Map(BldgpermitApplicationMaster appm) =>
            new BuildingPermitSystem(appm.Id, appm.ApplicationDate, appm.ApplicationNumber, appm.AddendumNumber, appm.PermitCode,
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "A" ? "Applica" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "D" ? "VoidApp" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "E" ? "ExpApp" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "W" ? "Working" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "V" ? "VoidPer" : appm.PermitStatus.ToUpper() == "U" ? "ExpPer" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "F" ? "Final" :
                                  !string.IsNullOrWhiteSpace(appm.PermitStatus) && appm.PermitStatus.ToUpper() == "C" ? "Closed" : "",
                                  appm.ApplicationYear, appm.PermitNumber, appm.ApplicantLastName + ", " + appm.ApplicantFirstName,
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
                                  appm.CityUtilityApprovalDate != null ? "A" : "");

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
                                                        BldgplanningApproval plap) =>
            new BuildingPermitSystemDetails(bldgpermit.ApplicantLastName, bldgpermit.ApplicantFirstName, bldgpermit.PermitCode.Trim(), bldgpermit.ProcessedForJurisdiction,
                bldgpermit.ApplicationDate.Value, bldgpermit.ApplicationUserId, bldgpermit.ApplicantBusinessName, bldgpermit.AddressLine1, bldgpermit.AddressLine2,
                bldgpermit.City, bldgpermit.State, bldgpermit.ZipCode, bldgpermit.PhoneNumber.Value, bldgpermit.PreliminaryParcelNumber.Value,
                bldgpermit.AssessorParcelNumber.Value, bldgpermit.AdditionalInformation, bldgpermit.ParkInformation, perm.PermitDescription, processedJuri.ShortDepartmentName,
                MapToBasicInfo(bldgpermit, juri, dept), MapToApplicantDetails(bldgpermit, mdia, mdiaBusinessEngineer, bldgContractor), Map(preliminaryValueMaster),
                Map(assessorValueMaster), Map(situs, cityCode), MapToApprovalStatus(bldgpermit), MapToPlanningApproval(plap, bldgpermit));

        private static BuildingPermitSystemBasicInfo MapToBasicInfo(BldgpermitApplicationMaster bldgpermit,
                                                                    Bldgjurisdictions juri,
                                                                    Bldgdepartments dept) =>
            new BuildingPermitSystemBasicInfo(bldgpermit.JurisdictionCode, bldgpermit.DepartmentCode, bldgpermit.ApplicationYear.Value, bldgpermit.ApplicationNumber.Value,
                bldgpermit.AddendumNumber.Value, bldgpermit.PermitStatus, juri.ShortDepartmentName, dept.ShortDepartmentName);

        private static BuildingPermitSystemApplicantDetails MapToApplicantDetails(BldgpermitApplicationMaster bldgpermit,
                                                                                  BldgmobileHomeDealersInstallersArchitects mdia,
                                                                                  BldgmobileHomeDealersInstallersArchitects mdiaBusinessEngineer,
                                                                                  Bldgcontractors bldgContractor) =>
            new BuildingPermitSystemApplicantDetails(bldgpermit.ContractLicenseNumber,
                bldgpermit.ApplicantProjectDescription, bldgpermit.ResultOfEnforcementAction, bldgpermit.EnforcementDescription, bldgpermit.PlotPlanReceived,
                bldgpermit.OnlyStructureOnParcel, bldgpermit.OnlyResidenceOnParcel, bldgContractor.ContractorBusinessName,
                bldgpermit.ArchitectFirmNumber, mdia?.BusinessName, bldgpermit.EngineerFirmNumber, mdiaBusinessEngineer?.BusinessName);

        private static BuildingValueMasterNameInfo Map(ASMTValueMasterNameView valueMaster) =>
            new BuildingValueMasterNameInfo(valueMaster.TitleOwnerName, valueMaster.Description1.Trim(), valueMaster.Description2.Trim());

        private static BuildingSitusAddressInfo Map(AsmtsitusAddress situs, AsmtcityCodeFile cityCode) =>
            (situs == null) ?
            null :
            new BuildingSitusAddressInfo(situs.HouseNumber.Value, situs.StreetDirectionQuadrant, situs.LocationCode, situs.StreetName, cityCode?.LocationCityCode);

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

        private static PlanningApproval MapToPlanningApproval(BldgplanningApproval plap, BldgpermitApplicationMaster appm) =>
            (plap == null) ?
            null :
            new PlanningApproval(appm.ApplicantProjectDescription, plap.ZoneCode, plap.FrontPropertySetback, plap.SideFlankingSetback,
                                 plap.SidePropertySetback, plap.BackPropertySetback, plap.FloodZone, plap.FloodZoneMapNumber,
                                 plap.LUpermitRequired, plap.Comments, plap.ApprovedBy, plap.UserId, plap.ChangeDate);
    }
}