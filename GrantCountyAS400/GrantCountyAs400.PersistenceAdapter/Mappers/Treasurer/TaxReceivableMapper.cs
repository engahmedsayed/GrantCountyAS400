using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer
{
    internal static class TaxReceivableMapper
    {
        internal static TaxReceivable Map(TreasPropertyMasterInfoView treasurerProperty)
        => new TaxReceivable(
                treasurerProperty.Id, treasurerProperty.ParcelNumber, treasurerProperty.ParentParcelNumber, treasurerProperty.TaxpayerCode, treasurerProperty.TitleOwnerCode,
                treasurerProperty.TaxCodeArea, treasurerProperty.LandUseCode, treasurerProperty.TaxpayerName.Trim(), treasurerProperty.TitleOwnerName.Trim());
    }
}