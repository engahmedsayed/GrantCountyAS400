using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class ValuationAndFeesMapper
    {
        internal static ValuationAndFees Map(List<ValuationAndFeesRecord> valuationAndFeesClass,string feeCode=null)
        {
            ValuationAndFees result = new ValuationAndFees(valuationAndFeesClass.Sum(t => t?.Appf?.ExtendedAmount),
              valuationAndFeesClass.Select(t => t.Appv).FirstOrDefault()?.ExtendedValue,
              GetFeesAmount(valuationAndFeesClass, "bldg"),
              GetFeesAmount(valuationAndFeesClass, "plrvw"),
              GetFeesAmount(valuationAndFeesClass, "plmb"),
              GetFeesAmount(valuationAndFeesClass, "mech"),
              GetFeesAmount(valuationAndFeesClass, "grad"),
              GetFeesAmount(valuationAndFeesClass, "demo"),
              GetFeesAmount(valuationAndFeesClass, "bidfe"),
              GetFeesAmount(valuationAndFeesClass, "bidpr"),
              GetFeesAmount(valuationAndFeesClass, "stbcd"),
              GetFeesAmount(valuationAndFeesClass, "fire"),
              GetFeesAmount(valuationAndFeesClass, "othrb"), 
              valuationAndFeesClass.Select(t => t.Appf).Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?
              .Select(t=>t.SequenceNumber)?.ToList(),
              valuationAndFeesClass.Select(t=>t.Appf)
              .Where(t=>t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.FeeDescription)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.BaseFee)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.FeeIncrement)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.MinMaxFlag)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.NumberOfUnits)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.UnitCharge)?.ToList(),
            valuationAndFeesClass.Select(t => t.Appf)
             .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t => t.ExtendedAmount)?.ToList()) ;
            return result;
        }

        private static decimal? GetFeesAmount(List<ValuationAndFeesRecord> valuationAndFeesClass, string feeCode)
            => valuationAndFeesClass.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode?.Trim().ToLower() == feeCode)?.ExtendedAmount;
    }
}