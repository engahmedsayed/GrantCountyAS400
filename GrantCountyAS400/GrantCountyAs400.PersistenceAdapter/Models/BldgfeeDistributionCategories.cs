using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgfeeDistributionCategories
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public decimal? FeeDistributionCategory { get; set; }
        public string FeeDistributionDescription { get; set; }
        public string ReportDisplayDescription { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
