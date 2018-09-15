using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgapplicationInspections
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string InspectionDepartmentCode { get; set; }
        public decimal? SequenceNumber { get; set; }
        public string InspectionLine1 { get; set; }
        public string InspectionLine2 { get; set; }
        public string InspectionLine3 { get; set; }
        public string InspectionLine4 { get; set; }
        public string InspectionLine5 { get; set; }
        public string InspectionLine6 { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EnteredByUser { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string RemovedByUser { get; set; }
        public string RemoveAuthorizedBy { get; set; }
        public DateTime? RemoveAuthorizedDate { get; set; }
        public string ReasonRemoved { get; set; }
        public DateTime? DateInspectionEntered { get; set; }
        public string InspectionEnteredByUser { get; set; }
        public string InspectedBy { get; set; }
        public DateTime? InspectionDate { get; set; }
    }
}
