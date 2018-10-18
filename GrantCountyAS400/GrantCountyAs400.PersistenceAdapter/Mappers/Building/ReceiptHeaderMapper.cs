using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class ReceiptHeaderMapper
    {
        internal static ReceiptHeader Map(BldgapplcationReceiptHeader receipt,
                                          List<(BldgfeeDistributionCategories receiptCategory, BldgapplcationReceiptDetail receiptDetail)> receiptInfo)
            => new ReceiptHeader(
                receipt.Id, receipt.JurisdictionCode, receipt.DepartmentCode, receipt.ApplicationYear.Value, receipt.ApplicationNumber.Value, receipt.AddendumNumber,
                receipt.ReceiptNumber, receipt.ReceiptType, receipt.ReceiptName, receipt.ReceiptDate, receipt.CheckAmount, receipt.CashAmount, receipt.OtherAmount,
                receipt.PaidByCheckNumber, receipt.ChangeAmount, receipt.ReceiptComment, receipt.UserId, receipt.ChangeDate, receipt.ChangeTime,
                receiptInfo.Select(Map));

        internal static ApplicationReceiptInfo Map((BldgfeeDistributionCategories ReceiptCategory, BldgapplcationReceiptDetail ReceiptDetail) receiptInfo)
        => new ApplicationReceiptInfo(
            receiptInfo.ReceiptCategory.FeeDistributionDescription,
            receiptInfo.ReceiptDetail.FeeDistributionCategory,
            receiptInfo.ReceiptDetail.Amount);
    }
}