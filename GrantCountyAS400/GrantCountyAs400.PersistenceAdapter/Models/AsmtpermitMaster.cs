using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtpermitMaster
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public decimal? ParcelNumber { get; set; }
        public DateTime? PermitIssuedDate { get; set; }
        public string PermitNumberString { get; set; }
        public string JurisdictionCode { get; set; }
        public string PermitStatus { get; set; }
        public decimal? PermitYear { get; set; }
        public decimal? PermitNumber { get; set; }
        public decimal? PermitAddendum { get; set; }
        public string PermitCode { get; set; }
        public string Comments { get; set; }
        public string NewOrDemo { get; set; }
        public decimal? EstimatedValue { get; set; }
        public decimal? PercentComplete { get; set; }
        public string CheckedBy { get; set; }
        public decimal? CheckedYearMonth { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string UserId { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string EntryProgram { get; set; }
    }
}
