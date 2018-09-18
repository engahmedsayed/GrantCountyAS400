using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class BuildingPermitSystemMapper
    {
        internal static BuildingPermitSystem Map(BldgpermitApplicationMaster appm) =>
            new BuildingPermitSystem(appm.ApplicationDate, appm.ApplicationNumber, appm.AddendumNumber, appm.PermitCode,
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


                
    }
}
