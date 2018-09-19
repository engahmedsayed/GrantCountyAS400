using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgmobileHomeDealersInstallersArchitects
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string BusinessCode { get; set; }
        public string MobileHomeDealer { get; set; }
        public string CertifiedInstaller { get; set; }
        public string Architects { get; set; }
        public string Engineers { get; set; }
        public string OtherCode1 { get; set; }
        public string OtherCode2 { get; set; }
        public string OtherCode3 { get; set; }
        public string BusinessName { get; set; }
        public string BusinessSearchName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public decimal? PhoneNumber { get; set; }
        public decimal? PhoneExtensionNumber { get; set; }
        public decimal? PhoneNumber2 { get; set; }
        public decimal? FaxNumber { get; set; }
        public string ContactName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime? LicenseExpireDate { get; set; }
        public string InternetAddress { get; set; }
        public DateTime? DateLastChanged { get; set; }
        public string UserId { get; set; }
    }
}
