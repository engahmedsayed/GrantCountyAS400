using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgapplcationReceiptHeader
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public decimal? ReceiptNumber { get; set; }
        public string ReceiptType { get; set; }
        public string ReceiptName { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal? CheckAmount { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public string PaidByCheckNumber { get; set; }
        public decimal? ChangeAmount { get; set; }
        public string ReceiptComment { get; set; }
        public string UserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public decimal? ChangeTime { get; set; }
    }
}
