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
              valuationAndFeesClass.Select(t => t.Appf)
              .FirstOrDefault(t => t.FeeCode.Trim().ToLower() ==(feeCode==null? "grad":feeCode))?.SequenceNumber,
              valuationAndFeesClass.Select(t=>t.Appf)
              .FirstOrDefault(t=>t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.FeeDescription,
              valuationAndFeesClass.Select(t => t.Appf)
              .FirstOrDefault(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.BaseFee,
              valuationAndFeesClass.Select(t => t.Appf)
              .FirstOrDefault(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.FeeIncrement,
              valuationAndFeesClass.Select(t => t.Appf)
              .FirstOrDefault(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.MinMaxFlag,
              valuationAndFeesClass.Select(t => t.Appf)
              .FirstOrDefault(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.NumberOfUnits,
              valuationAndFeesClass.Select(t => t.Appf)
              .FirstOrDefault(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.UnitCharge) ;
            return result;
        }

        private static decimal? GetFeesAmount(List<ValuationAndFeesRecord> valuationAndFeesClass, string feeCode)
            => valuationAndFeesClass.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode?.Trim().ToLower() == feeCode)?.ExtendedAmount;
    }
}