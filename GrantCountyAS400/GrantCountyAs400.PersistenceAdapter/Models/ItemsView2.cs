using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AccountChartOfAccountsView
    {
        public decimal FiscalYear { get; set; }
        public string AcctCategory { get; set; }
        public string AcctNumber { get; set; }
        public string AcctDescription { get; set; }
        public int Id { get; set; }
        public string AccountNumberFixed { get; set; }
    }
}
