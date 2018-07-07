using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctGlperiodAmounts
    {
        public int Id { get; set; }
        public decimal? FiscalYear { get; set; }
        public string Fund { get; set; }
        public string Department { get; set; }
        public string Program { get; set; }
        public string Project { get; set; }
        public string Base { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
        public decimal? Budget { get; set; }
        public decimal? PendingEncumbrance { get; set; }
        public decimal? Encumbrance { get; set; }
        public decimal? Glppenact { get; set; }
        public decimal? Action { get; set; }
    }
}
