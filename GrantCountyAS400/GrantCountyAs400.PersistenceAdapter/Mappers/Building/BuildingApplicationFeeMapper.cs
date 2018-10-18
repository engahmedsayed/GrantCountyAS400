using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class BuildingApplicationFeeMapper
    {
        internal static BuildingApplicationFee Map(BldgapplicationFees fee)
            => new BuildingApplicationFee(fee.Id, fee.JurisdictionCode, fee.DepartmentCode, fee.ApplicationYear.Value, fee.ApplicationNumber.Value,
                fee.AddendumNumber, fee.FeeCode, fee.SequenceNumber, fee.NumberOfUnits, fee.UnitCharge, fee.ExtendedAmount, fee.FeeDescription, fee.MinMaxFlag,
                fee.FeeDistributionCategory, fee.FeeIncrement, fee.BaseFee, fee.ChargeByValue);
    }
}