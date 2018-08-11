using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtlandUseCodes
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? LandUseCode { get; set; }
        public string UseCodeDesc { get; set; }
        public string UseCodeShortDesc { get; set; }
        public string AbstractCode { get; set; }
        public string Filler { get; set; }
    }
}
