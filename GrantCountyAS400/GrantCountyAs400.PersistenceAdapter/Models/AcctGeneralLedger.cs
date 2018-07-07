using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctGeneralLedger
    {
        public int Id { get; set; }
        public decimal? FiscalYear { get; set; }
        public string Fund { get; set; }
        public string Department { get; set; }
        public string Program { get; set; }
        public string Project { get; set; }
        public string Base { get; set; }
        public string AccountType { get; set; }
        public string RecordType { get; set; }
        public string RecordStatus { get; set; }
        public string ClosedAcct { get; set; }
        public decimal? BeginBudget { get; set; }
        public decimal? CurrentBudget { get; set; }
        public decimal? PendingEncumbrance { get; set; }
        public decimal? CurrentEncumbrance { get; set; }
        public decimal? PendingAction { get; set; }
        public decimal? CurrentAction { get; set; }
        public decimal? NetBalance { get; set; }
    }
}
