using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgpermitsConditionsUserAuthority
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string ValidUserId { get; set; }
        public string PermitDepartment { get; set; }
        public string HomeDepartment { get; set; }
        public string AuthorityToAddConditions { get; set; }
        public string AuthorityToRemoveConditions { get; set; }
        public string AuthorityToAddInspection { get; set; }
        public string AuthorityToRemoveInspection { get; set; }
        public string AuthorityToAddChangeApps { get; set; }
        public string AuthorityToApproveApps { get; set; }
        public string AuthorityToUpdateNotes { get; set; }
        public string AuthorityToAddValuations { get; set; }
        public string AuthorityToAddFees { get; set; }
        public string AuthorityToAddPermitDetail { get; set; }
        public string AuthorityToIssueReceipt { get; set; }
        public string AuthorityToIssuePermit { get; set; }
        public string AssignAssessorParcel { get; set; }
        public string RepresentAssessors { get; set; }
        public string RepresentBuildingDepartment { get; set; }
        public string RepresentCityDepartment { get; set; }
        public string RepresentFireDepartment { get; set; }
        public string RepresentHealthDepartment { get; set; }
        public string RepresentPlanningDepartment { get; set; }
        public string RepresentPublicWorksDepartment { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeUserId { get; set; }
        public string UserName { get; set; }
        public string UserJob { get; set; }
        public string AuthorityToChangeAppsStatus { get; set; }
        public string AuthorityToChangePrmtStatus { get; set; }
    }
}
