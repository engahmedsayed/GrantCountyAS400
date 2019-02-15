using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AddressSearch
{
    public class AddressSearchFilterViewModel
    {
        [Display(Name = "Parcel")]
        public decimal ParcelNumber { get; set; }

        [Display(Name ="Street Name")]
        public string StreetName { get; set; }

        [Display(Name = "House Number")]
        public decimal HouseNumber { get; set; }
    }
}
