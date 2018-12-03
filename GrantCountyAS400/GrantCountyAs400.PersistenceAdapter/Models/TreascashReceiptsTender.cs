using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreascashReceiptsTender
    {
        public int Id { get; set; }
        public string RecCode { get; set; }
        public decimal? TranYear { get; set; }
        public decimal? ReceiptTranNumber { get; set; }
        public string RcptExt { get; set; }
        public string RecType { get; set; }
        public string TaxpayerCode { get; set; }
        public string TaxPayerName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public decimal? AmountTendered { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? CashBack { get; set; }
        public string PaymentMethod { get; set; }
        public string AdditionalTender { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ChangeSerId { get; set; }
        public string Comments { get; set; }
        public string Comments2 { get; set; }
        public decimal? SequenceNumber { get; set; }
    }
}
