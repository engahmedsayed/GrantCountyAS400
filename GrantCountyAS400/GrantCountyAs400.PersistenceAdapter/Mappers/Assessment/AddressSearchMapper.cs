using GrantCountyAs400.Domain;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class AddressSearchMapper
    {
        internal static AddressSearch Map(AsmtsitusAddress asmtSitusAddress, AsmtcityCodeFile asmtCityCodeFile)
            =>
            new AddressSearch(asmtSitusAddress.ParcelNumber,asmtSitusAddress.HouseNumber, asmtSitusAddress.HouseNumberExtension,
                              asmtSitusAddress.StreetDirectionQuadrant, asmtSitusAddress.StreetName, 
                              asmtCityCodeFile.LocationCityCode);
    }
}
