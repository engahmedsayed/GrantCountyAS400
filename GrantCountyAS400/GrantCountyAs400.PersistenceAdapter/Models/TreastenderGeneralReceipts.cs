using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreastenderGeneralReceipts
    {
        public int Id { get; set; }
        public string RecCode { get; set; }
        public decimal? TranYear { get; set; }
        public decimal? ReceiptTranNumber { get; set; }
        public string RcptExt { get; set; }
        public decimal? ReceiptTran { get; set; }
        public string RcptExt1 { get; set; }
        public decimal? SequenceNumber { get; set; }
        public decimal? TaxAmount { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal? BarsNumber { get; set; }
        public decimal? Element { get; set; }
        public decimal? Object { get; set; }
        public decimal? Function { get; set; }
        public decimal? FundNumber { get; set; }
        public string ProjActGrant { get; set; }
    }
}
