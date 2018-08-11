using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtrealPropertyAssociatedPersons
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public string NameCode { get; set; }
        public string Filler01 { get; set; }
        public string Comment { get; set; }
        public string ChangeId { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
