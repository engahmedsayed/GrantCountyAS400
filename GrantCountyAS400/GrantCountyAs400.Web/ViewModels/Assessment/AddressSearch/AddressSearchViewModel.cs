using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AddressSearch
{
    public class AddressSearchViewModel
    {
        [Display(Name ="Parcel Number")]
        public int? ParcelNumber { get; set; }

        [Display(Name = "House Number")]
        public int? HouseNumber { get; set; }

        [Display(Name = "House Number Extension")]
        public string HouseNumberExtension { get; set; }

        [Display(Name = "Street Direction Quadrant")]
        public string StreetDirectionQuadrant { get; set; }

        [Display(Name = "Street Name")]
        public string StreetName { get; set; }

        [Display(Name = "Location City Code")]
        public string LocationCityCode { get; set; }
    }
}
