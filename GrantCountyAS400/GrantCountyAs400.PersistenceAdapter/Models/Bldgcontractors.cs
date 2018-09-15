using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class Bldgcontractors
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string ContractLicenseNumber { get; set; }
        public string ContractorBusinessName { get; set; }
        public string ContractorSearchName { get; set; }
        public string MailingAddress { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public decimal? PhoneNumber { get; set; }
        public decimal? PhoneExtensionNumber { get; set; }
        public decimal? PhoneNumber2 { get; set; }
        public decimal? FaxNumber { get; set; }
        public string ContactName { get; set; }
        public string InternetAddress { get; set; }
        public DateTime? DateLastChanged { get; set; }
        public string UserId { get; set; }
    }
}
