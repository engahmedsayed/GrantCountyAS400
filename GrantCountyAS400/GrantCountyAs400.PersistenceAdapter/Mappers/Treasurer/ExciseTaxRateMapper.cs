using GrantCountyAs400.Domain.Treasurer;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Treasurer
{
    internal static class ExciseTaxRateMapper
    {
        internal static ExciseTaxRate Map(TreasexciseTaxRate source)
            => new ExciseTaxRate(source.Id, source.RecordTypeStateLocal, source.AreaCode, source.EffectiveCode, source.Description, source.ExciseTaxRate,
                source.PenaltyRate, source.PenaltyRate2, source.PenaltyRate3, source.InterestRate, source.InterestMethod, source.ChangeUserId, source.ChangeDate,
                source.AdministrativeFeePercent);
    }
}