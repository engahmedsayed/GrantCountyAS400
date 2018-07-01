using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctPersonnel
    {
        public decimal? Group { get; set; }
        public string Name { get; set; }
        public string SpouseName { get; set; }
        public decimal? Status { get; set; }
        public decimal? Ssnumber { get; set; }
        public decimal? Phone { get; set; }
        public decimal? Prime { get; set; }
        public decimal? PersonNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? TotalJobs { get; set; }
        public string BloodType { get; set; }
        public string Sex { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime? LicenseExpDate { get; set; }
        public string Race { get; set; }
        public string Prbenefic { get; set; }
        public DateTime? Prlsthist { get; set; }
        public string Prflsa { get; set; }
        public decimal? UpdateFlag { get; set; }
        public decimal? Prupdcnt { get; set; }
        public decimal? Prupdlast { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public decimal? ZipCode { get; set; }
        public decimal? AddressFlag { get; set; }
        public string EmergencyContact { get; set; }
        public decimal? EmergencyContactPhone { get; set; }
        public string EmergencyContactAddress1 { get; set; }
        public string EmergencyContactAddress2 { get; set; }
        public string EmergencyContactState { get; set; }
        public decimal? EmergencyContactZip { get; set; }
        public decimal? PersMarriedStatus { get; set; }
        public decimal? PersMarriedStatusDep { get; set; }
        public string StateMarriedStatus { get; set; }
        public decimal? StateMarriedStatusDep { get; set; }
        public string FedMarriedStatus { get; set; }
        public decimal? FedMarriedStatusDependents { get; set; }
        public string MaritalStatus { get; set; }
        public string Prstfield { get; set; }
        public string MilitaryBranch { get; set; }
        public string MilitaryDischargeType { get; set; }
        public string Prmilstats { get; set; }
        public DateTime? MilitaryDischargeDate { get; set; }
        public string Predfield { get; set; }
        public string Predlevel { get; set; }
        public DateTime? Predlstdt { get; set; }
        public string Predhs { get; set; }
        public int Id { get; set; }
    }
}
