using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Treasurer
{
    public class TaxPaymentReceipt
    {
        public int Id { get; }
        public decimal ParcelNumber { get; }
        public decimal? ParcelExtension { get; }
        public int TaxYear { get; }
        public DateTime? TransactionDate { get; }
        public decimal? TaxAmount { get; }
        public decimal? ReceiptTranNumber { get; }

        public TaxPaymentReceipt(
            int id, decimal parcelNumber, decimal? parcelExtension, int taxYear, DateTime? transactionDate, decimal? taxAmount, decimal? receiptTranNumber)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            ParcelExtension = parcelExtension;
            TaxYear = taxYear;
            TransactionDate = transactionDate;
            TaxAmount = taxAmount;
            ReceiptTranNumber = receiptTranNumber;
        }
    }
}
