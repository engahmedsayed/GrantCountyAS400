using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgplanningApproval
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string ZoneCode { get; set; }
        public decimal? FrontPropertySetback { get; set; }
        public decimal? SideFlankingSetback { get; set; }
        public decimal? SidePropertySetback { get; set; }
        public decimal? BackPropertySetback { get; set; }
        public string FloodZone { get; set; }
        public string FloodZoneMapNumber { get; set; }
        public string LUpermitRequired { get; set; }
        public string Comments { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string UserId { get; set; }
    }
}
