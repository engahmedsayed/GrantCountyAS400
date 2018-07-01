using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctCategoryCodes
    {
        public int Id { get; set; }
        public string System { get; set; }
        public string Category { get; set; }
        public string CategoryAbbreviation { get; set; }
        public string CategoryDescription { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Cdcmt { get; set; }
    }
}
