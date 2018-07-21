using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Accounting
{
   public class GeneralLedgerDetailItem
    {
        public decimal? Month { get;private set; }

        public decimal? Year { get; private set; }

        public decimal? Budget { get; private set; }
        public decimal? Encumbrance { get;private set; }

        public decimal? Action { get; private set; }

        public GeneralLedgerDetailItem(decimal? month,decimal? year,decimal? budget,decimal? encumbrance,decimal? action)
        {
            Month = month;
            Year = year;
            Budget = budget;
            Encumbrance = encumbrance;
            Action = action;
        }
    }

    public class GeneralLedgerDetail
    {
        public List<GeneralLedgerDetailItem> GeneralLedgers { get; private set; }

        public string FirstCurrentExpense { get; private set; }

        public string SecondCurrentExpense { get; private set; }

        public GeneralLedgerDetail(List<GeneralLedgerDetailItem> generalLedgers,string firstCurrentExpense,string secondCurrentExpense)
        {
            GeneralLedgers = generalLedgers;
            FirstCurrentExpense = firstCurrentExpense;
            SecondCurrentExpense = secondCurrentExpense;
        }
    }
}
