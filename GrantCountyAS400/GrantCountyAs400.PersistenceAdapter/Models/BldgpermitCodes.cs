using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgpermitCodes
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string PermitCode { get; set; }
        public string PermitSearchCode { get; set; }
        public string ShortPermitName { get; set; }
        public string PermitDescription { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string UserId { get; set; }
    }
}
