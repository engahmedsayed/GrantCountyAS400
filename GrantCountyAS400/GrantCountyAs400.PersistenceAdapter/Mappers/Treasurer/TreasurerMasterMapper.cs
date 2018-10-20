using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer
{
    internal static class TreasurerMasterMapper
    {
        internal static TreasurerMaster Map(TreasallPropertyMaster propertyMaster, ASMTValueMasterNameView valueMaster)
            => new TreasurerMaster(
                propertyMaster.Id, propertyMaster.ParcelNumber, propertyMaster.ParentParcelNumber, propertyMaster.TaxpayerCode, propertyMaster.TitleOwnerCode,
                propertyMaster.TaxCodeArea, propertyMaster.LandUseCode, valueMaster.TaxpayerName);
    }
}