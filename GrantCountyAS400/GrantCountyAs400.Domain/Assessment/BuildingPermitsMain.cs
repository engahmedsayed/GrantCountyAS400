using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment
{
    public class BuildingPermitsMain
    {
        public decimal? ParcelNumber { get;}

        public string TitleOwnerCode { get;}

        public string OwnerName { get; }

        public BuildingPermitsMain(decimal? parcelNumber, string titleOwnerCode, string ownerName)
        {
            ParcelNumber = parcelNumber;
            TitleOwnerCode = titleOwnerCode;
            OwnerName = ownerName;
        }
    }
}
