using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgstateClassifications
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public decimal? StateClassCode { get; set; }
        public string ClassCodeExtension { get; set; }
        public string ClassificationDescription { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
