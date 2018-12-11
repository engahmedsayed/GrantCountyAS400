using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Treasurer
{
    public class TaxReceipt
    {
        public decimal ReceiptNumber { get; }
        public DateTime? ReceiptDate { get; }

        public TaxReceipt(decimal receiptNumber, DateTime? receiptDate)
        {
            ReceiptNumber = receiptNumber;
            ReceiptDate = receiptDate;
        }

        public override bool Equals(object obj)
        {
            var receipt = obj as TaxReceipt;
            return receipt != null &&
                   ReceiptNumber == receipt.ReceiptNumber &&
                   EqualityComparer<DateTime?>.Default.Equals(ReceiptDate, receipt.ReceiptDate);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ReceiptNumber, ReceiptDate);
        }
    }
}