using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Building
{
    public class ReceiptHeader
    {
        public int Id { get; }
        public string JurisdictionCode { get; }
        public string DepartmentCode { get; }
        public decimal ApplicationYear { get; }
        public decimal ApplicationNumber { get; }
        public decimal? AddendumNumber { get; }
        public decimal? ReceiptNumber { get; }
        public string ReceiptType { get; }
        public string ReceiptName { get; }
        public DateTime? ReceiptDate { get; }
        public decimal? CheckAmount { get; }
        public decimal? CashAmount { get; }
        public decimal? OtherAmount { get; }
        public string PaidByCheckNumber { get; }
        public decimal? ChangeAmount { get; }
        public string ReceiptComment { get; }
        public string UserId { get; }
        public DateTime? ChangeDate { get; }
        public decimal? ChangeTime { get; }
        public IEnumerable<ApplicationReceiptInfo> ReceiptInfos { get; set; }

        public ReceiptHeader(int id, string jurisdictionCode, string departmentCode, decimal applicationYear, decimal applicationNumber, decimal? addendumNumber,
            decimal? receiptNumber, string receiptType, string receiptName, DateTime? receiptDate, decimal? checkAmount, decimal? cashAmount, decimal? otherAmount,
            string paidByCheckNumber, decimal? changeAmount, string receiptComment, string userId, DateTime? changeDate, decimal? changeTime,
            IEnumerable<ApplicationReceiptInfo> receiptInfos)
        {
            Id = id;
            JurisdictionCode = jurisdictionCode;
            DepartmentCode = departmentCode;
            ApplicationYear = applicationYear;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            ReceiptNumber = receiptNumber;
            ReceiptType = receiptType;
            ReceiptName = receiptName;
            ReceiptDate = receiptDate;
            CheckAmount = checkAmount;
            CashAmount = cashAmount;
            OtherAmount = otherAmount;
            PaidByCheckNumber = paidByCheckNumber;
            ChangeAmount = changeAmount;
            ReceiptComment = receiptComment;
            UserId = userId;
            ChangeDate = changeDate;
            ChangeTime = changeTime;
            ReceiptInfos = receiptInfos;
        }
    }

    public class ApplicationReceiptInfo
    {
        public string FeeDistributionDescription { get; }
        public decimal? FeeDistributionCategory { get; }
        public decimal? Amount { get; }

        public ApplicationReceiptInfo(string feeDistributionDescription, decimal? feeDistributionCategory, decimal? amount)
        {
            FeeDistributionDescription = feeDistributionDescription;
            FeeDistributionCategory = feeDistributionCategory;
            Amount = amount;
        }
    }
}