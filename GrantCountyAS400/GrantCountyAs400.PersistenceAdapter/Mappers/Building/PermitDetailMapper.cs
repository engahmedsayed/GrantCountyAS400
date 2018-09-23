using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class PermitDetailMapper
    {
        internal static DemolitionPermit Map(BldgpermitApplicationMaster bldgpermit,
                                             BldgdemolitionPermitDetail permit,
                                             BldgfireDistrictCodes bldgfire,
                                             BldgapplicationConditions bldgCondition,
                                             BldgapplicationInspections bldgInspection) =>
            new DemolitionPermit(bldgpermit.ApplicantProjectDescription, permit.OfficeProjectDescription, permit.SquareFeet.Value, permit.Dimensions,
                permit.BuildingDescription, permit.RequiredHandoutsProvided, permit.DateProvided, permit.ToWhomProvided, permit.FireDistrictCode, permit.BldgDeptSetback.Value,
                permit.FireMarshalSetback.Value, bldgfire.LongFireDistrictName, (bldgCondition == null), (bldgInspection == null),
                new PermitApprovedInfo(permit.BldgDeptApprovalBy, permit.BldgDeptDateApproved, permit.BldgDeptApprovedUserId, permit.BldgDeptApprovedChangeDate),
                new PermitApprovedInfo(permit.FireMarshalApprovalBy, permit.FireMarshalDateApproved, permit.FireMarshalApprovedUserId, permit.FireMarshalApprovedChangeDate));
    }
}