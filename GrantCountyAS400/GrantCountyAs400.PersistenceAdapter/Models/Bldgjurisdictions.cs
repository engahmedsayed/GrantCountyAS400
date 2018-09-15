using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class Bldgjurisdictions
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string DepartmentCode { get; set; }
        public string ShortDepartmentName { get; set; }
        public string LongDepartmentName { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string UserId { get; set; }
    }
}
