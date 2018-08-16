using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtnameChangeHistory
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public string NameType { get; set; }
        public DateTime? NameChangeDate { get; set; }
        public string NameCode { get; set; }
        public string NameChangeReason { get; set; }
        public string NameChangeId { get; set; }
    }
}
