using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasrealPropertyHistoricValues
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? TaxYear { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public string SeniorCitizenCode { get; set; }
        public decimal? LandUseCode { get; set; }
        public decimal? UnimprovedLandValue { get; set; }
        public decimal? ImprovedLandValue { get; set; }
        public decimal? BuildingValue { get; set; }
        public decimal? TimberlandValue { get; set; }
        public decimal? FMunimprovedLandValue { get; set; }
        public decimal? FMimprovedLandValue { get; set; }
        public decimal? FMtimberValue { get; set; }
        public decimal? UnimprovedLandAcres { get; set; }
        public decimal? ImprovedLandAcres { get; set; }
        public decimal? TimberAcres { get; set; }
        public decimal? FirePatrolAcres { get; set; }
        public decimal? UndividedInterestPercent { get; set; }
        public string SubsidiaryParcelCode { get; set; }
        public string Filler { get; set; }
        public string RevaluationPhase { get; set; }
        public string ProcessStatusCode { get; set; }
        public string ChangeReasonCode { get; set; }
        public string ChangeId { get; set; }
        public decimal? MobileHomeValue { get; set; }
        public decimal? FMbuildingValue { get; set; }
        public decimal? CUunimprovedLandValue { get; set; }
        public decimal? CUimprovedLandValue { get; set; }
        public decimal? CUtimberlandValue { get; set; }
        public string SourceOfTaxablevalues { get; set; }
        public string TaxStatus { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
