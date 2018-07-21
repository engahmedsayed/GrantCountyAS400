using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtmobileHomeParks
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public string MhparkCode { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ContactNameCode { get; set; }
        public string TelephoneNumber { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? SpaceNumber { get; set; }
        public string QualCode { get; set; }
        public string Filler01 { get; set; }
    }
}
