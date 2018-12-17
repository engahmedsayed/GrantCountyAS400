using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Treasurer
{
    public class TaxReceipt
    {
        public decimal ReceiptNumber { get; }
        public DateTime? ReceiptDate { get; }
        public decimal? AffidavitNumber { get; }

        public TaxReceipt(decimal receiptNumber, DateTime? receiptDate, decimal? affidavitNumber)
        {
            ReceiptNumber = receiptNumber;
            ReceiptDate = receiptDate;
            AffidavitNumber = affidavitNumber;
        }

        public override bool Equals(object obj)
        {
            var receipt = obj as TaxReceipt;
            return receipt != null &&
                   ReceiptNumber == receipt.ReceiptNumber &&
                   EqualityComparer<DateTime?>.Default.Equals(ReceiptDate, receipt.ReceiptDate) &&
                   EqualityComparer<decimal?>.Default.Equals(AffidavitNumber, receipt.AffidavitNumber);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ReceiptNumber, ReceiptDate, AffidavitNumber);
        }
    }
}