using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtfullLegalDescription
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? SequenceNumber { get; set; }
        public string Descrtiption { get; set; }
        public string Filler { get; set; }
    }
}
