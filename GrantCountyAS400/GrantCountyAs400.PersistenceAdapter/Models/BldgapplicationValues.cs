using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgapplicationValues
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public decimal? SequenceNumber { get; set; }
        public string ComponentDescription { get; set; }
        public string OccupantType { get; set; }
        public decimal? NumberOfOccupants { get; set; }
        public decimal? TableNumberSectLineSeq { get; set; }
        public decimal? SquareFeet { get; set; }
        public string SectionDescription { get; set; }
        public string ConstructionTypeDescription { get; set; }
        public string ConstructionTypeShortDescription { get; set; }
        public decimal? Cost { get; set; }
        public decimal? ExtendedValue { get; set; }
    }
}
