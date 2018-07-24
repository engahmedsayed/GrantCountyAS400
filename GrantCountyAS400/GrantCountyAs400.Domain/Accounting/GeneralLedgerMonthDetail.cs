using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Accounting
{
    public class GeneralLedgerMonthDetail
    {
        public decimal? JENumber { get;private set; }

        public decimal? Line { get; private set; }

        public int Month { get; private set; }

        public int Year { get; private set; }

        public DateTime? TransactionDate { get; private set; }

        public string Status { get;private set; }

        public string Source { get;private set; }

        public string Notation1 { get; private set; }

        public string Kind { get;private set; }

        public decimal? Amount { get;private set; }

        public GeneralLedgerMonthDetail(decimal? jENumber, decimal? line, int month, int year, DateTime? transactionDate, string status, string source, string notation1, string kind, decimal? amount)
        {
            JENumber = jENumber;
            Line = line;
            Month = month;
            Year = year;
            TransactionDate = transactionDate;
            Status = status;
            Source = source;
            Notation1 = notation1;
            Kind = kind;
            Amount = amount;
        }
    }
}
