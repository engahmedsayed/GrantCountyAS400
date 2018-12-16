using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Treasurer
{
    public class TaxReceiptDetails
    {
        public decimal TransactionNumber { get; }
        public IEnumerable<CashReceipt> CashReceipts { get; }
        public IEnumerable<GeneralReceipt> GeneralReceipts { get; }
        public IEnumerable<AffadavitReceipt> AffadavitReceipts { get; }
        public IEnumerable<PropertyTaxReceivableTransaction> PropertyReceipts { get; }

        public TaxReceiptDetails(
            decimal transactionNumber, IEnumerable<CashReceipt> cashReceipts, IEnumerable<GeneralReceipt> generalReceipts, IEnumerable<AffadavitReceipt> affadavitReceipts,
            IEnumerable<PropertyTaxReceivableTransaction> propertyReceipts)
        {
            TransactionNumber = transactionNumber;
            CashReceipts = cashReceipts;
            GeneralReceipts = generalReceipts;
            AffadavitReceipts = affadavitReceipts;
            PropertyReceipts = propertyReceipts;
        }
    }

    // => TREASCashReceiptsTender

    public class CashReceipt
    {
        public int Id { get; }
        public int TransactionYear { get; }
        public decimal ReceiptNumber { get; }
        public string TaxpayerCode { get; }
        public string TaxPayerName { get; }
        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public DateTime? ReceiptDate { get; }
        public string ChangeSerId { get; }
        public string Comments { get; }
        public string Comments2 { get; }
        public string PaymentMethod { get; }
        public decimal? AmountTendered { get; }

        public CashReceipt(
            int id, int transactionYear, decimal receiptNumber, string taxpayerCode, string taxPayerName, string addressLine1, string addressLine2,
            DateTime? receiptDate, string changeSerId, string comments, string comments2, string paymentMethod, decimal? amountTendered)
        {
            Id = id;
            TransactionYear = transactionYear;
            ReceiptNumber = receiptNumber;
            TaxpayerCode = taxpayerCode;
            TaxPayerName = taxPayerName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            ReceiptDate = receiptDate;
            ChangeSerId = changeSerId;
            Comments = comments;
            Comments2 = comments2;
            PaymentMethod = paymentMethod;
            AmountTendered = amountTendered;
        }
    }

    // => TREASTenderGeneralReceipts

    public class GeneralReceipt
    {
        public int Id { get; }
        public int TransactionYear { get; }
        public decimal ReceiptNumber { get; }
        public string Description { get; }
        public decimal? FundNumber { get; }
        public decimal? BarsNumber { get; }
        public decimal? Element { get; }
        public decimal? Object { get; }
        public decimal? Function { get; }
        public decimal? TaxAmount { get; }

        public GeneralReceipt(
            int id, int transactionYear, decimal receiptNumber, string description, decimal? fundNumber, decimal? barsNumber, decimal? element, decimal? @object,
            decimal? function, decimal? taxAmount)
        {
            Id = id;
            TransactionYear = transactionYear;
            ReceiptNumber = receiptNumber;
            Description = description;
            FundNumber = fundNumber;
            BarsNumber = barsNumber;
            Element = element;
            Object = @object;
            Function = function;
            TaxAmount = taxAmount;
        }
    }

    // => TREASTenderAffadavits
    public class AffadavitReceipt
    {
        public int Id { get; }
        public int TransactionYear { get; }
        public decimal ReceiptNumber { get; }
        public string NewOwnerBuyer { get; }
        public string PreviousOwnerSeller { get; }
        public decimal? TotalPaid { get; }
        public decimal? AffadavitNumber { get; }

        public AffadavitReceipt(
            int id, int transactionYear, decimal receiptNumber, string newOwnerBuyer, string previousOwnerSeller, decimal? totalPaid, decimal? affadavitNumber)
        {
            Id = id;
            TransactionYear = transactionYear;
            ReceiptNumber = receiptNumber;
            NewOwnerBuyer = newOwnerBuyer;
            PreviousOwnerSeller = previousOwnerSeller;
            TotalPaid = totalPaid;
            AffadavitNumber = affadavitNumber;
        }
    }
}