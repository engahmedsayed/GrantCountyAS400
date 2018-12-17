using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreasPropertyMasterInfoView
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? ParentParcelNumber { get; set; }
        public string TaxpayerCode { get; set; }
        public string TitleOwnerCode { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public decimal? LandUseCode { get; set; }
        public string TaxpayerName { get; set; }
        public string TitleOwnerName { get; set; }
        public string TaxCodeDesc { get; set; }
        public decimal? ParcelExtension { get; set; }
    }
}
