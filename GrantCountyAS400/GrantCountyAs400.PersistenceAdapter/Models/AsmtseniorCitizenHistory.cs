using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtseniorCitizenHistory
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? TaxYear { get; set; }
        public string SeniorCitizenCode { get; set; }
        public decimal? SeniorExcessLevyExemptAv { get; set; }
        public decimal? SrRegularLeveyExcemptAv { get; set; }
        public decimal? SrRegularLeveyExcemptOr { get; set; }
        public string ChangeUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public DateTime? EffectiveDateFrozendAv { get; set; }
        public decimal? TotalAvbeforeSrExempt { get; set; }
        public decimal? TotalMarketValue { get; set; }
        public decimal? TotalFrozenValueTaxYear { get; set; }
        public decimal? NewConstValueBuilding { get; set; }
        public decimal? NewConstValueImporvedLand { get; set; }
        public decimal? NewConstValueUnimporvedLand { get; set; }
        public decimal? NewConstValueTimberLand { get; set; }
        public decimal? AdjustPriorYearFrozenBuilding { get; set; }
        public decimal? AdjustPriorYearFrozenImprovedLand { get; set; }
        public decimal? AdjustPriorYearFrozenUnimprovedLand { get; set; }
        public decimal? AdjustPriorYearFrozenTimberLand { get; set; }
        public decimal? PriorYearFrozenBuilding { get; set; }
        public decimal? PriorYearFrozenImprovedLand { get; set; }
        public decimal? PriorYearFrozenUnimprovedLand { get; set; }
        public decimal? PriorYearFrozenTimberLand { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public decimal? NonSrCitFmbldgValue { get; set; }
        public decimal? NonSrCiFmunimpLndValue { get; set; }
        public decimal? NonSrCitFmimpLndValue { get; set; }
        public decimal? NonSrCitFmtimberLndValue { get; set; }
        public decimal? NonSrCitCuunimpLndValue { get; set; }
        public decimal? NonSrCitCuimpLndValue { get; set; }
        public decimal? NonSrCitCutimberLndValue { get; set; }
    }
}
