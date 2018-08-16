using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtnewConstruction
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? TaxYear { get; set; }
        public string Filler { get; set; }
        public decimal? NewConstructionBuildingAv { get; set; }
        public decimal? NewConstructionLandAv { get; set; }
        public decimal? TaxCode { get; set; }
        public string RevaluationPhase { get; set; }
        public string ChangeId { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
