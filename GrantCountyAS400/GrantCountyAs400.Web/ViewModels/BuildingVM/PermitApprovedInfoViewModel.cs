using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class PermitApprovedInfoViewModel
    {
        public string ApprovalBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateApproved { get; set; }

        public string ApprovedUserId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ApprovedChangeDate { get; set; }
    }
}