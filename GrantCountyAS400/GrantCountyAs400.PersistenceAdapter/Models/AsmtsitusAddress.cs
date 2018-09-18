using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtsitusAddress
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? ParcelNumber { get; set; }
        public string LocationCode { get; set; }
        public string StreetName { get; set; }
        public decimal? HouseNumber { get; set; }
        public string HouseNumberExtension { get; set; }
        public string StreetDirectionQuadrant { get; set; }
        public string Filler01 { get; set; }
    }
}
