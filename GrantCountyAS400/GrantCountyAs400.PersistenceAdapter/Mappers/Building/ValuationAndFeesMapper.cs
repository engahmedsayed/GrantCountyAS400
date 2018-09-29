using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;
using GrantCountyAs400.PersistenceAdapter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class ValuationAndFeesMapper
    {
        internal static ValuationAndFees Map(List<ValuationAndFeesClass> valuationAndFeesClass)
        {
            ValuationAndFees result = new ValuationAndFees(valuationAndFeesClass.Sum(t => t?.Appf?.ExtendedAmount),
              valuationAndFeesClass?.Select(t=>t.Appv).FirstOrDefault()?.ExtendedValue,
              valuationAndFeesClass?.Select(t=>t.Appf).FirstOrDefault(t=>t.FeeCode.Trim().ToLower() == "bldg")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "plrvw")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "plmb")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "mech")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "bidfe")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "bidpr")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "stbcd")?.ExtendedAmount,
              valuationAndFeesClass?.Select(t => t.Appf).FirstOrDefault(t => t.FeeCode.Trim().ToLower() == "othrb")?.ExtendedAmount);
            return result;
        }
            
    }
}
