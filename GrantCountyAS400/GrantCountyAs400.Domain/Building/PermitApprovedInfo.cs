using System;

namespace GrantCountyAs400.Domain.Building
{
    public class PermitApprovedInfo
    {
        public string ApprovalBy { get; }
        public DateTime? DateApproved { get; }
        public string ApprovedUserId { get; }
        public DateTime? ApprovedChangeDate { get; }

        public PermitApprovedInfo(string approvalBy, DateTime? dateApproved, string approvedUserId, DateTime? approvedChangeDate)
        {
            ApprovalBy = approvalBy;
            DateApproved = dateApproved;
            ApprovedUserId = approvedUserId;
            ApprovedChangeDate = approvedChangeDate;
        }
    }
}