using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Accounting
{
   public class GeneralLedgerDetailItem
    {
        public decimal? Month { get;private set; }

        public decimal? Year { get; private set; }

        public string Base { get; private set; }

        public decimal? Budget { get; private set; }
        public decimal? Encumbrance { get;private set; }

        public decimal? Action { get; private set; }

        public decimal? PendingEncumbrance { get; set; }

        public string Fund { get; set; }

        public string Department { get; set; }

        public string Program { get; set; }

        public string Project { get; set; }

        public GeneralLedgerDetailItem(decimal? month,decimal? year,decimal? budget,decimal? encumbrance,decimal? pendingEncumbrance,decimal? action,string fund,string department,string program,string project,string @base)
        {
            Month = month;
            Year = year;
            Budget = budget;
            Encumbrance = encumbrance;
            Action = action;
            PendingEncumbrance = pendingEncumbrance;
            Fund = fund;
            Department = department;
            Program = program;
            Project = project;
            Base = @base;
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
