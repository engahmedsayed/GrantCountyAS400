using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.GeneralLedgerVM
{
    public class GeneralLedgerMonthDetailsViewModel
    {
        public decimal? JENumber { get; set; }

        public decimal? Line { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public DateTime? TransactionDate { get; set; }

        public string Status { get; set; }

        public string Source { get; set; }

        public string Notation1 { get; set; }

        public string Kind { get; set; }

        public decimal? Amount { get; set; }
    }
}
