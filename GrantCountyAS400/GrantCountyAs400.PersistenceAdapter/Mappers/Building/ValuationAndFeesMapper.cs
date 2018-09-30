using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class ValuationAndFeesMapper
    {
        internal static ValuationAndFees Map(List<ValuationAndFeesRecord> valuationAndFeesClass)
        {
            ValuationAndFees result = new ValuationAndFees(valuationAndFeesClass.Sum(t => t?.Appf?.ExtendedAmount),
              valuationAndFeesClass.Select(t => t.Appv).FirstOrDefault()?.ExtendedValue,
              GetFeesAmount(valuationAndFeesClass, "bldg"),
              GetFeesAmount(valuationAndFeesClass, "plrvw"),
              GetFeesAmount(valuationAndFeesClass, "plmb"),
              GetFeesAmount(valuationAndFeesClass, "mech"),
              GetFeesAmount(valuationAndFeesClass, "bidfe"),
              GetFeesAmount(valuationAndFeesClass, "bidpr"),
              GetFeesAmount(valuationAndFeesClass, "stbcd"),
              GetFeesAmount(valuationAndFeesClass, "othrb"));
            return result;
        }

        private static decimal? GetFeesAmount(List<ValuationAndFeesRecord> valuationAndFeesClass, string feeCode)
            => valuationAndFeesClass.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == feeCode)?.ExtendedAmount;
    }
}