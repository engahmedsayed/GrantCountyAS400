using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgapplicationNotes
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public decimal? SequenceNumber { get; set; }
        public string Note { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string UserId { get; set; }
    }
}
