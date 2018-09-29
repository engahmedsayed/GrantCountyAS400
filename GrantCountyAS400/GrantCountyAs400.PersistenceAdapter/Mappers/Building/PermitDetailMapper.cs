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
                permit.FireMarshalSetback.Value, bldgfire.LongFireDistrictName, (bldgCondition != null), (bldgInspection != null),
                new PermitApprovedInfo(permit.BldgDeptApprovalBy, permit.BldgDeptDateApproved, permit.BldgDeptApprovedUserId, permit.BldgDeptApprovedChangeDate),
                new PermitApprovedInfo(permit.FireMarshalApprovalBy, permit.FireMarshalDateApproved, permit.FireMarshalApprovedUserId, permit.FireMarshalApprovedChangeDate));

        internal static OtherPermitDetail Map(BldgotherPermitDetail othd, BldgfireDistrictCodes fdst,
                                              BldgapplicationConditions apcn, BldgapplicationInspections apin,
                                              BldgapplicationValues appv) =>
            new OtherPermitDetail(othd.OfficeProjectDescription, othd.FireDistrictCode, fdst.LongFireDistrictName, othd.AdditionalFireFlowRequired,
                othd.AmountOffireFlowRequired, othd.BldgDeptSetback, othd.FireMarshalSetback,
                new PermitApprovedInfo(othd.BldgDeptApprovedBy, othd.BldgDeptDateApproved, othd.BldgDeptApprovedUserId, othd.BldgDeptApprovedChangeDate),
                new PermitApprovedInfo(othd.FireMarshalApprovedBy, othd.FireMarshalDateApproved, othd.FireMarshalApprovedUserId, othd.FireMarshalApprovedChangeDate),
                (apcn != null ? true : false), (apin != null ? true : false), appv?.ExtendedValue);

        internal static MechanicalPermitDetail Map(BldgpermitApplicationMaster bldg, BldgapplicationConditions apcnConditionRecord,
                                   BldgapplicationInspections apinConditionRecord, BldgmechanicalPermitDetail mecd,
                                   BldgfireDistrictCodes fdst) =>
            new MechanicalPermitDetail(mecd.OfficeProjectDescription, mecd.Nrecreceived, mecd.FireDistrictCode, fdst?.LongFireDistrictName,
                mecd.BldgDeptSetback, mecd.FireMarshalSetback, apcnConditionRecord == null, apinConditionRecord == null,
                new PermitApprovedInfo(mecd.BldgDeptApprovedBy, mecd.BldgDeptDateApproved, mecd.BldgDeptApprovedUserId, mecd.BldgDeptApprovedChangeDate),
                new PermitApprovedInfo(mecd.FireMarshalApprovedBy, mecd.FireMarshalDateApproved, mecd.FireMarshalApprovedUserId, mecd.FireMarshalApprovedChangeDate));

        internal static StructurePermitDetail Map(BldgpermitApplicationMaster bldg, BldgapplicationConditions apcnConditionRecord,
                                                  BldgapplicationInspections apinConditionRecord,
                                                  BldgstructureBuildingPermitDetail strd, BldgfireDistrictCodes fdst, BldgapplicationValues appv) =>
            new StructurePermitDetail(strd.OfficeProjectDescription, strd.ResAgCommOther, strd.NumberOfBedrooms,
                                      strd.NumberOfBathrooms, strd.NumberOfUnits, strd.Heated, strd.HeatSourceDescription,
                                      strd.PrescriptiveReviewDone, strd.WattsunRunReviewDone, strd.Nrecreceived, strd.PlansAnalystReviewDone,
                                      strd.PlansAnalystReviewDescription, strd.SprinklerSystemRequired, strd.SprinklerSystemDescription,
                                      strd.AlarmSystemRequired, strd.AlarmSystemDescription, strd.SpecialInspectionRequired,
                                      strd.SpecialInspectionDescription, strd.PermitIncludePlumbing, strd.PermitIncludeMechanical,
                                      strd.FireDistrictCode, fdst.ShortFireDistrictName, strd.FireFlowAlreadyProvided, strd.AdditionalFireFlowRequired,
                                      strd.AmountOfFireFlowRequired, strd.BldgDeptSetback, strd.FireMarshalSetback, apcnConditionRecord == null,
                                       apinConditionRecord == null, appv?.ExtendedValue, new PermitApprovedInfo(strd.BldgDeptApprovedBy,
                                                                                                                strd.BldgDepDateApproved,
                                                                                                                strd.BldgDeptApprovedUserId,
                                                                                                                strd.BldgDeptApprovedChangeDate),
                                        new PermitApprovedInfo(strd.FireMarshalApprovedBy, strd.FireMarshalDateApproved, strd.FireMarshalApprovedUserId,
                                                               strd.FireMarshalApprovedChangeDate));

        internal static GradingExcavationPermitDetail Map(BldgpermitApplicationMaster bldg, BldgfireDistrictCodes fdst,
                                                          BldgapplicationConditions apcnConditionRecord,
                                                          BldgapplicationInspections apinConditionRecord,
                                                          BldggradingExcavatingPermitDetail grdd) =>
             new GradingExcavationPermitDetail(bldg.ApplicantProjectDescription, grdd.OfficeProjectDescription, grdd.CubicYardsOfFill,
                                               grdd.PercentOfSlope, grdd.SoilErosionControlRequired, grdd.DustAndTrackControlReceived,
                                               grdd.DustAndTrackReceivedDate, grdd.EngineeringReceived, grdd.EngineeringReceivedDate,
                                               grdd.FireDistrictCode, fdst.ShortFireDistrictName, grdd.FireFlowAlreadyProvided,
                                               grdd.AdditionalFireFlowRequired, grdd.AmountOfFireFlowRequired, grdd.BldgDeptSetback,
                                               grdd.FireMarshalSetback, apcnConditionRecord == null, apinConditionRecord == null,
                                               new PermitApprovedInfo(grdd.BldgDeptApprovedBy, grdd.BldgDeptDateApproved,
                                                                      grdd.BldgDeptApprovedUserId, grdd.BldgDeptApprovedChangeDate),
                                               new PermitApprovedInfo(grdd.FireMarshalApprovedBy, grdd.FireMarshalDateApproved, grdd.FireMarshalApprovedUserId,
                                                               grdd.FireMarshalApprovedChangeDate));

    }
}