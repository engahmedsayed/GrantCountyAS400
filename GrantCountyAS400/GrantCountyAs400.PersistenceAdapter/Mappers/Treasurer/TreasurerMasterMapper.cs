using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer
{
    internal static class TreasurerMasterMapper
    {
        internal static TreasurerMaster Map(TreasPropertyMasterInfoView treasurerProperty)
        => new TreasurerMaster(
                treasurerProperty.Id, treasurerProperty.ParcelNumber, treasurerProperty.ParentParcelNumber, treasurerProperty.TaxpayerCode, treasurerProperty.TitleOwnerCode,
                treasurerProperty.TaxCodeArea, treasurerProperty.LandUseCode, treasurerProperty.TaxpayerName);
    }
}