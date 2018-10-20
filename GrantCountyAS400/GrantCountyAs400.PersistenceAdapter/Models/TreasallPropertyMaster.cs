using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasallPropertyMaster
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? ParentParcelNumber { get; set; }
        public string TaxpayerCode { get; set; }
        public string TitleOwnerCode { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public decimal? LandUseCode { get; set; }
    }
}
