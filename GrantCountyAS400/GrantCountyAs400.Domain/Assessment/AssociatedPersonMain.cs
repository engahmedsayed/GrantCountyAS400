using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment
{
    public class AssociatedPersonMain
    {
        public decimal? ParcelNumber { get; }

        public string NameCode { get;  }

        public string Comment { get; }

        public AssociatedPersonMain(decimal? parcelNumber, string nameCode, string comment)
        {
            ParcelNumber = parcelNumber;
            NameCode = nameCode;
            Comment = comment;
        }
    }
}
