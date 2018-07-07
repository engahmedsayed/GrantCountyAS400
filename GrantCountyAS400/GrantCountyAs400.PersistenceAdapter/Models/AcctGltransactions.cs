using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctGltransactions
    {
        public int Id { get; set; }
        public decimal Year { get; set; }
        public decimal Month { get; set; }
        public decimal? Jenumber { get; set; }
        public decimal? Line { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public decimal? FiscalYear { get; set; }
        public string Fund { get; set; }
        public string Department { get; set; }
        public string Program { get; set; }
        public string Project { get; set; }
        public string Base { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Kind { get; set; }
        public decimal? Amount { get; set; }
        public string Source { get; set; }
        public string Notation1 { get; set; }
        public string Notation2 { get; set; }
        public string Notation3 { get; set; }
        public string Notation4 { get; set; }
    }
}
