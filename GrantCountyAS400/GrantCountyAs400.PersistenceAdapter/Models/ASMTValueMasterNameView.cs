using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class ASMTValueMasterNameView
    {
        public int Id { get; set; }
        public decimal? ParcelNumber { get; set; }
        public string TaxpayerCode { get; set; }
        public string TitleOwnerCode { get; set; }
        public string ContractHolderCode { get; set; }
        public string TaxpayerName { get; set; }
        public string TitleOwnerName { get; set; }
        public string ContractHolderName { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
