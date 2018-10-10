using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class BuildingConditionMapper
    {
        internal static BuildingCondition Map(BldgapplicationConditions condition)
            => new BuildingCondition(
                condition.Id, condition.JurisdictionCode, condition.DepartmentCode, condition.ApplicationYear.Value, condition.ApplicationNumber.Value,
                condition.AddendumNumber.Value, condition.ConditionDepartmentCode, condition.ConditionSequence.Value, condition.ConditionLine1.Trim(),
                condition.ConditionLine2.Trim(), condition.ConditionLine3.Trim(), condition.ConditionLine4.Trim(), condition.ConditionLine5.Trim(),
                condition.ConditionLine6.Trim(), condition.EntryDate, condition.EnteredByUser, condition.DateRemoved, condition.RemovedByUser,
                condition.RemoveAuthorizedBy, condition.RemoveAuthorizedDate, condition.ReasonRemoved);
    }
}