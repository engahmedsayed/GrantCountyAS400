using System;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingInspection
    {
        public int Id { get; }
        public string JurisdictionCode { get; }
        public string DepartmentCode { get; }
        public decimal ApplicationYear { get; }
        public decimal ApplicationNumber { get; }
        public decimal AddendumNumber { get; }
        public string InspectionDepartmentCode { get; }
        public decimal SequenceNumber { get; }
        public string InspectionLine1 { get; }
        public string InspectionLine2 { get; }
        public string InspectionLine3 { get; }
        public string InspectionLine4 { get; }
        public string InspectionLine5 { get; }
        public string InspectionLine6 { get; }
        public DateTime? EntryDate { get; }
        public string EnteredByUser { get; }
        public DateTime? DateRemoved { get; }
        public string RemovedByUser { get; }
        public string RemoveAuthorizedBy { get; }
        public DateTime? RemoveAuthorizedDate { get; }
        public string ReasonRemoved { get; }
        public DateTime? DateInspectionEntered { get; }
        public string InspectionEnteredByUser { get; }
        public string InspectedBy { get; }
        public DateTime? InspectionDate { get; }

        public BuildingInspection(int id, string jurisdictionCode, string departmentCode, decimal applicationYear, decimal applicationNumber, decimal addendumNumber,
                                  string inspectionDepartmentCode, decimal sequenceNumber, string inspectionLine1, string inspectionLine2, string inspectionLine3,
                                  string inspectionLine4, string inspectionLine5, string inspectionLine6, DateTime? entryDate, string enteredByUser,
                                  DateTime? dateRemoved, string removedByUser, string removeAuthorizedBy, DateTime? removeAuthorizedDate, string reasonRemoved,
                                  DateTime? dateInspectionEntered, string inspectionEnteredByUser, string inspectedBy, DateTime? inspectionDate)
        {
            Id = id;
            JurisdictionCode = jurisdictionCode;
            DepartmentCode = departmentCode;
            ApplicationYear = applicationYear;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            InspectionDepartmentCode = inspectionDepartmentCode;
            SequenceNumber = sequenceNumber;
            InspectionLine1 = inspectionLine1;
            InspectionLine2 = inspectionLine2;
            InspectionLine3 = inspectionLine3;
            InspectionLine4 = inspectionLine4;
            InspectionLine5 = inspectionLine5;
            InspectionLine6 = inspectionLine6;
            EntryDate = entryDate;
            EnteredByUser = enteredByUser;
            DateRemoved = dateRemoved;
            RemovedByUser = removedByUser;
            RemoveAuthorizedBy = removeAuthorizedBy;
            RemoveAuthorizedDate = removeAuthorizedDate;
            ReasonRemoved = reasonRemoved;
            DateInspectionEntered = dateInspectionEntered;
            InspectionEnteredByUser = inspectionEnteredByUser;
            InspectedBy = inspectedBy;
            InspectionDate = inspectionDate;
        }
    }
}