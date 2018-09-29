using System;

namespace GrantCountyAs400.Domain.Building
{
    public class DealersInstallersArchitectInfo
    {
        public string BusinessName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime? LicenseExpireDate { get; set; }
        public decimal PhoneNumber { get; set; }

        public DealersInstallersArchitectInfo(string businessName, string licenseNumber, DateTime? licenseExpireDate, decimal phoneNumber)
        {
            BusinessName = businessName;
            LicenseNumber = licenseNumber;
            LicenseExpireDate = licenseExpireDate;
            PhoneNumber = phoneNumber;
        }
    }
}