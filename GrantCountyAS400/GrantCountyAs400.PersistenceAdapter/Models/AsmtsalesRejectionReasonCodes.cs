using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtsalesRejectionReasonCodes
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? SaleRejectionCode { get; set; }
        public string Comment { get; set; }
        public string Filler01 { get; set; }
    }
}
