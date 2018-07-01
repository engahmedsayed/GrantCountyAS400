using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctEmployeeMiscDeductions
    {
        public decimal? MiscYear { get; set; }
        public decimal? MiscGroup { get; set; }
        public decimal? EmployeeNumber { get; set; }
        public decimal? MiscCount { get; set; }
        public string MiscCode { get; set; }
        public decimal? MiscDeduction { get; set; }
        public decimal? MiscBenefit { get; set; }
        public decimal? MiscTaxLimit { get; set; }
        public string Section145 { get; set; }
        public int Id { get; set; }
    }
}
