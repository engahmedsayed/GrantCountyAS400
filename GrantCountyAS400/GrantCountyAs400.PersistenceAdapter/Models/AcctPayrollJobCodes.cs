using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctPayrollJobCodes
    {
        public decimal? Group { get; set; }
        public string JobCode { get; set; }
        public string JobTitle { get; set; }
        public string Prjtabfrom { get; set; }
        public string Prjgrdfrom { get; set; }
        public string Prjtabto { get; set; }
        public string Prjgrdto { get; set; }
        public string Category { get; set; }
        public string Experience { get; set; }
        public decimal? Prjcmt { get; set; }
        public int Id { get; set; }
    }
}
