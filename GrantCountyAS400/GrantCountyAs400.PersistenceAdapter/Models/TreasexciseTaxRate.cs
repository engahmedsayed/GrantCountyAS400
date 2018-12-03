using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasexciseTaxRate
    {
        public int Id { get; set; }
        public string RecordTypeStateLocal { get; set; }
        public string AreaCode { get; set; }
        public decimal? EffectiveCode { get; set; }
        public string Description { get; set; }
        public decimal? ExciseTaxRate { get; set; }
        public decimal? PenaltyRate { get; set; }
        public decimal? PenaltyRate2 { get; set; }
        public decimal? PenaltyRate3 { get; set; }
        public decimal? InterestRate { get; set; }
        public string InterestMethod { get; set; }
        public string ChangeUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public decimal? AdministrativeFeePercent { get; set; }
    }
}
