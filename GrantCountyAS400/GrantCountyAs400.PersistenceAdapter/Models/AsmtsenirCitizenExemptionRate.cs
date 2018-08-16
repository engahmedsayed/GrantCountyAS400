using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtsenirCitizenExemptionRate
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? TaxYear { get; set; }
        public string SeniorCitizenCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal? ExcLevyExemptPercent { get; set; }
        public decimal? RegLevyExemptPercent { get; set; }
        public decimal? RegLevyMinExemptAv { get; set; }
        public decimal? RegLevyMaxExemptAv { get; set; }
        public decimal? MaximumIncome { get; set; }
    }
}
