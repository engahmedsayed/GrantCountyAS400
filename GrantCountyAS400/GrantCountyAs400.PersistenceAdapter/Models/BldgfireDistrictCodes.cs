using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgfireDistrictCodes
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string FireDistrictCode { get; set; }
        public string ShortFireDistrictName { get; set; }
        public string LongFireDistrictName { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string UserId { get; set; }
    }
}
