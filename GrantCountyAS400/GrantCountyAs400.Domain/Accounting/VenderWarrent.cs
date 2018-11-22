using System;

namespace GrantCountyAs400.Domain.Accounting
{
    public class VenderWarrent
    {
        public int Id { get; }
        public string Vendor { get;  }
        public decimal WarrantNumber { get;  }
        public decimal? CheckNumber { get;  }
        public DateTime? WarrantDate { get;  }
        public string Status { get;  }
        public string Ponumber { get;  }
        public string Fund { get;  }
        public string Department { get;  }
        public string Program { get;  }
        public string Project { get;  }
        public string Base { get;  }
        public string Invoice { get;  }
        public string Description { get;  }
        public string FillType { get;  }
        public decimal? FiscalYear { get;  }
        public decimal? Amount { get;  }
        public DateTime? PayDate { get;  }
        public string Combine { get;  }
        public DateTime? InvoiceDate { get; }
        public string Name { get;  }

        public VenderWarrent(
            int id, string vendor, decimal warrantNumber, decimal? checkNumber, DateTime? warrantDate, string status, string ponumber, string fund, string department,
            string program, string project, string @base, string invoice, string description, string fillType, decimal? fiscalYear, decimal? amount, DateTime? payDate,
            string combine, DateTime? invoiceDate, string name)
        {
            Id = id;
            Vendor = vendor;
            WarrantNumber = warrantNumber;
            CheckNumber = checkNumber;
            WarrantDate = warrantDate;
            Status = status;
            Ponumber = ponumber;
            Fund = fund;
            Department = department;
            Program = program;
            Project = project;
            Base = @base;
            Invoice = invoice;
            Description = description;
            FillType = fillType;
            FiscalYear = fiscalYear;
            Amount = amount;
            PayDate = payDate;
            Combine = combine;
            InvoiceDate = invoiceDate;
            Name = name;
        }
    }
}