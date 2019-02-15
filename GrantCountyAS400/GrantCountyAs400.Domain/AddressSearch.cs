using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain
{
   public class AddressSearch
    {
        public decimal? ParcelNumber { get;}

        public decimal? HouseNumber { get; }

        public string HouseNumberExtension { get; }

        public string StreetDirectionQuadrant { get;}

        public string StreetName { get; }

        public string LocationCityCode { get;  }

        public AddressSearch(decimal? parcelNumber,decimal? houseNumber, string houseNumberExtension, string streetDirectionQuadrant, 
                             string streetName, string locationCityCode)
        {
            ParcelNumber = parcelNumber;
            HouseNumber = houseNumber;
            HouseNumberExtension = houseNumberExtension;
            StreetDirectionQuadrant = streetDirectionQuadrant;
            StreetName = streetName;
            LocationCityCode = locationCityCode;
        }
    }
}
