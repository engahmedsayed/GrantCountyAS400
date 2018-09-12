using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtinstrumentType
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public string InstrumentCode { get; set; }
        public string InstrumentTypeDescription { get; set; }
        public decimal? Account1 { get; set; }
        public decimal? FeeAccount1 { get; set; }
        public decimal? Account2 { get; set; }
        public decimal? FeeAccount2 { get; set; }
        public decimal? Account3 { get; set; }
        public decimal? FeeAccount3 { get; set; }
        public decimal? Account4 { get; set; }
        public decimal? FeeAccount4 { get; set; }
        public string Satisfaction { get; set; }
        public string IndexingException { get; set; }
        public string Filler01 { get; set; }
    }
}
