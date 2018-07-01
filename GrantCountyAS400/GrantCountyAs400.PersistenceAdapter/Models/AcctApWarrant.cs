using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctApWarrant
    {
        public decimal WarrantNumber { get; set; }
        public decimal? CheckNumber { get; set; }
        public string Ponumber { get; set; }
        public string Invoice { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? FiscalYear { get; set; }
        public string Fund { get; set; }
        public string Department { get; set; }
        public string Program { get; set; }
        public string Project { get; set; }
        public string Base { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string Vendor { get; set; }
        public string VendorType { get; set; }
        public string Combine { get; set; }
        public DateTime? WarrantDate { get; set; }
        public string Description { get; set; }
        public string FillType { get; set; }
        public string PayType { get; set; }
        public string Bank { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ReceiveStatus { get; set; }
        public string User { get; set; }
        public int Id { get; set; }
    }
}
