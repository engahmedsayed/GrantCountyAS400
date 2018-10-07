using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class BuildingInspectionMapper
    {
        internal static BuildingInspection Map(BldgapplicationInspections inspection)
            => new BuildingInspection(
                inspection.Id, inspection.JurisdictionCode, inspection.DepartmentCode, inspection.ApplicationYear.Value, inspection.ApplicationNumber.Value,
                inspection.AddendumNumber.Value, inspection.InspectionDepartmentCode, inspection.SequenceNumber.Value, inspection.InspectionLine1.Trim(),
                inspection.InspectionLine2.Trim(), inspection.InspectionLine3.Trim(), inspection.InspectionLine4.Trim(), inspection.InspectionLine5.Trim(),
                inspection.InspectionLine6.Trim(), inspection.EntryDate, inspection.EnteredByUser, inspection.DateRemoved, inspection.RemovedByUser,
                inspection.RemoveAuthorizedBy, inspection.RemoveAuthorizedDate, inspection.ReasonRemoved, inspection.DateInspectionEntered, inspection.InspectionEnteredByUser,
                inspection.InspectedBy, inspection.InspectionDate);
    }
}