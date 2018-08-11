using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtzoneDescriptions
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public string ZoneCode { get; set; }
        public string ZoneCodeDesc { get; set; }
        public string ZoneCodeShortDesc { get; set; }
        public string ZoneMinimums { get; set; }
        public string Filler { get; set; }
    }
}
