using System;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingCondition
    {
        public int Id { get; }
        public string JurisdictionCode { get; }
        public string DepartmentCode { get; }
        public decimal ApplicationYear { get; }
        public decimal ApplicationNumber { get; }
        public decimal AddendumNumber { get; }
        public string ConditionDepartmentCode { get; }
        public decimal? ConditionSequence { get; }
        public string ConditionLine1 { get; }
        public string ConditionLine2 { get; }
        public string ConditionLine3 { get; }
        public string ConditionLine4 { get; }
        public string ConditionLine5 { get; }
        public string ConditionLine6 { get; }
        public DateTime? EntryDate { get; }
        public string EnteredByUser { get; }
        public DateTime? DateRemoved { get; }
        public string RemovedByUser { get; }
        public string RemoveAuthorizedBy { get; }
        public DateTime? RemoveAuthorizedDate { get; }
        public string ReasonRemoved { get; }

        public BuildingCondition(int id, string jurisdictionCode, string departmentCode, decimal applicationYear, decimal applicationNumber, decimal addendumNumber,
            string conditionDepartmentCode, decimal? conditionSequence, string conditionLine1, string conditionLine2, string conditionLine3, string conditionLine4,
            string conditionLine5, string conditionLine6, DateTime? entryDate, string enteredByUser, DateTime? dateRemoved, string removedByUser,
            string removeAuthorizedBy, DateTime? removeAuthorizedDate, string reasonRemoved)
        {
            Id = id;
            JurisdictionCode = jurisdictionCode;
            DepartmentCode = departmentCode;
            ApplicationYear = applicationYear;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            ConditionDepartmentCode = conditionDepartmentCode;
            ConditionSequence = conditionSequence;
            ConditionLine1 = conditionLine1;
            ConditionLine2 = conditionLine2;
            ConditionLine3 = conditionLine3;
            ConditionLine4 = conditionLine4;
            ConditionLine5 = conditionLine5;
            ConditionLine6 = conditionLine6;
            EntryDate = entryDate;
            EnteredByUser = enteredByUser;
            DateRemoved = dateRemoved;
            RemovedByUser = removedByUser;
            RemoveAuthorizedBy = removeAuthorizedBy;
            RemoveAuthorizedDate = removeAuthorizedDate;
            ReasonRemoved = reasonRemoved;
        }
    }
}