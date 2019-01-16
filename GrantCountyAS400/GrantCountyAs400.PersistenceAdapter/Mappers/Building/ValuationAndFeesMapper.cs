using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.PersistenceAdapter.Models;
using GrantCountyAs400.PersistenceAdapter.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Building
{
    internal static class ValuationAndFeesMapper
    {
        internal static ValuationAndFees Map(List<ValuationAndFeesRecord> valuationAndFeesClass,string feeCode=null)
        {
            ValuationAndFees result = new ValuationAndFees(valuationAndFeesClass.Select(t=>t?.Appf)?.Distinct().Sum(t => t?.ExtendedAmount),
                valuationAndFeesClass.Select(t => t.BldgDistributionCategories)
              .Select(t => t.FeeDistributionDescription)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appv).Distinct()?.Sum(t => t?.ExtendedValue),
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
              valuationAndFeesClass.Select(t => t.Appf)?.Distinct().Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?
              .Select(t=>t.SequenceNumber)?.ToList(),
              valuationAndFeesClass.Select(t=>t.Appf)?.Distinct()
              .Where(t=>t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.FeeDescription)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)?.Distinct()
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.BaseFee)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)?.Distinct()
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.FeeIncrement)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)?.Distinct()
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.MinMaxFlag)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)?.Distinct()
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.NumberOfUnits)?.ToList(),
              valuationAndFeesClass.Select(t => t.Appf)?.Distinct()
              .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t=>t.UnitCharge)?.ToList(),
            valuationAndFeesClass.Select(t => t.Appf)?.Distinct()
             .Where(t => t.FeeCode.Trim().ToLower() == (feeCode == null ? "grad" : feeCode))?.Select(t => t.ExtendedAmount)?.ToList(), 
            valuationAndFeesClass.Select(t=>t.Bldg)?.Sum(t=>t?.AssignedValue),valuationAndFeesClass.Select(t=>t.Bldg)?.FirstOrDefault()?.StateClassCode,
            valuationAndFeesClass.Select(t=>t.Bldg)?.FirstOrDefault(t=>t!=null && t.ProjectedExpireDate.HasValue)?.ProjectedExpireDate,
            valuationAndFeesClass.Select(t => t.Bldg)?.FirstOrDefault(t =>t!=null && t.ActualExpireDate.HasValue)?.ActualExpireDate,
            valuationAndFeesClass.Select(t => t.Bldg)?.FirstOrDefault(t =>t!=null && !string.IsNullOrWhiteSpace(t.ExpiredByUser))?.ExpiredByUser) ;
            return result;
        }

        internal static ValuationFeeDetails Map(List<BldgapplicationValues> bldgvalues)
        {
            List<ValuationFeeDetailsItem> items = new List<ValuationFeeDetailsItem>();
            for (int i = 0; i < bldgvalues?.Count; i++)
            {
                items.Add(new ValuationFeeDetailsItem(bldgvalues[i]?.SequenceNumber, bldgvalues[i]?.ComponentDescription, bldgvalues[i]?.OccupantType, bldgvalues[i]?.NumberOfOccupants,
                                                      bldgvalues[i]?.TableNumberSectLineSeq, bldgvalues[i]?.SquareFeet,
                                                      bldgvalues[i]?.SectionDescription, bldgvalues[i]?.ConstructionTypeDescription, bldgvalues[i]?.Cost, bldgvalues[i]?.ExtendedValue));
            }
            return new ValuationFeeDetails(bldgvalues?.Sum(t => t?.ExtendedValue), bldgvalues?.Sum(t => t?.SquareFeet), items);
        }
           

        private static decimal? GetFeesAmount(List<ValuationAndFeesRecord> valuationAndFeesClass, string feeCode)
            => valuationAndFeesClass.Select(t => t.Appf).Where(t => t.FeeCode?.Trim().ToLower() == feeCode)?.Distinct().Sum(t=>t?.ExtendedAmount);
    }
}