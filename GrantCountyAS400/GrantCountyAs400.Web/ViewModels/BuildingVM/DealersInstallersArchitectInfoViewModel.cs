using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class DealersInstallersArchitectInfoViewModel
    {
        public string BusinessName { get; set; }
        public string LicenseNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? LicenseExpireDate { get; set; }

        public decimal PhoneNumber { get; set; }
    }
}