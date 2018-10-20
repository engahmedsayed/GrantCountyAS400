using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasallPropertyTaxReceivableTransactions
    {
        public int Id { get; set; }
        public string RecCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? ParcelExtension { get; set; }
        public decimal? TaxYear { get; set; }
        public DateTime? TranDate { get; set; }
        public string Filler01 { get; set; }
        public string RcptExt { get; set; }
        public string TranTypeCd { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? FPamount { get; set; }
        public decimal? LPamount { get; set; }
        public decimal? InterestPaid { get; set; }
        public string TaxCode { get; set; }
        public string SrCitCd { get; set; }
        public string ChgReasonCd { get; set; }
        public decimal? ChangedAssessedValue { get; set; }
        public decimal? FpfeeAmount { get; set; }
        public string Filler02 { get; set; }
        public string ChangeUserId { get; set; }
        public decimal? ReceiptTranNumber { get; set; }
    }
}
