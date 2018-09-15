using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgapplicationConditions
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string ConditionDepartmentCode { get; set; }
        public decimal? ConditionSequence { get; set; }
        public string ConditionLine1 { get; set; }
        public string ConditionLine2 { get; set; }
        public string ConditionLine3 { get; set; }
        public string ConditionLine4 { get; set; }
        public string ConditionLine5 { get; set; }
        public string ConditionLine6 { get; set; }
        public DateTime? EntryDate { get; set; }
        public string EnteredByUser { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string RemovedByUser { get; set; }
        public string RemoveAuthorizedBy { get; set; }
        public DateTime? RemoveAuthorizedDate { get; set; }
        public string ReasonRemoved { get; set; }
    }
}
