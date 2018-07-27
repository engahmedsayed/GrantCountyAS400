using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Accounting
{
    public class GeneralLedger
    {
        public string AccountNumber { get; }

        public string AccountName { get;  }

        public string Fund { get; }

        public string Department { get;}

        public string Program { get; }

        public string Project { get; }

        public decimal? FiscalYear { get; }

        public string Kind { get; }

        public string Base { get; set; }
        public string Type { get; }

        public string Status { get;}

        public GeneralLedger(string accountNumber, string accountName, string kind, string type, string status,string @base,
                             string fund,string department, string program, string project,decimal? fiscalYear)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.Kind = kind;
            this.Type = type;
            this.Status = status;
            this.Base = @base;
            this.Fund = fund;
            this.Department = department;
            this.Program = program;
            this.Project = project;
            this.FiscalYear = fiscalYear;
        }
    }
}
