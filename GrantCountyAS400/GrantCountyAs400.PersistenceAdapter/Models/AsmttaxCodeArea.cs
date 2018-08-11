using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmttaxCodeArea
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public string TaxCodeDesc { get; set; }
        public string Filler { get; set; }
        public string ExciseAreaCode { get; set; }
        public string TaxDistirct { get; set; }
        public string RevaluationPhase { get; set; }
    }
}
