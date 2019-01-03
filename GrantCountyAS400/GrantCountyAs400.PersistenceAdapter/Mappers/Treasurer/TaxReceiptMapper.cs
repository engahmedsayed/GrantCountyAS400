using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer
{
    internal static class TaxReceiptMapper
    {
        internal static CashReceipt Map(TreascashReceiptsTender receipt)
            => new CashReceipt(receipt.Id, (int)receipt.TranYear.Value, receipt.ReceiptTranNumber.Value, receipt.TaxPayerName.Trim(), receipt.TaxPayerName.Trim(),
                receipt.AddressLine1.Trim(), receipt.AddressLine2.Trim(), receipt.ReceiptDate, receipt.ChangeSerId, receipt.Comments.Trim(), receipt.Comments2.Trim(),
                receipt.PaymentMethod.Trim(), receipt.AmountTendered);

        internal static GeneralReceipt Map(TreastenderGeneralReceipts receipt)
            => new GeneralReceipt(receipt.Id, (int)receipt.TranYear.Value, receipt.ReceiptTranNumber.Value, receipt.Description, receipt.FundNumber, receipt.BarsNumber,
                receipt.Element, receipt.Object, receipt.Function, receipt.TaxAmount, receipt.TranDate);

        internal static AffadavitReceipt Map(TreastenderAffadavits receipt)
            => new AffadavitReceipt(receipt.Id, (int)receipt.TranYear.Value, receipt.ReceiptTranNumber.Value, receipt.NewOwnerBuyer, receipt.PreviousOwnerSeller,
                receipt.TotalPaid, receipt.ReceiptTran, receipt.AffidavitDate, receipt.ParcelNumber);

        internal static TaxPaymentReceipt Map(TreasallPropertyTaxReceivableTransactions transaction)
            => new TaxPaymentReceipt(transaction.Id, transaction.ParcelNumber.Value, transaction.ParcelExtension, (int)transaction.TaxYear.Value, transaction.TranDate,
                transaction.TaxAmount, transaction.ReceiptTranNumber);
    }
}