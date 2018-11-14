using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class ValuationFeeDetails
    {
        public decimal? ExtendedValue { get; }

        public decimal? SquareFeet { get; }

        public List<ValuationFeeDetailsItem> Items { get;}

        public ValuationFeeDetails(decimal? extendedValue, decimal? squareFeet, List<ValuationFeeDetailsItem> items)
        {
            ExtendedValue = extendedValue;
            SquareFeet = squareFeet;
            Items = items;
        }
    }

    public class ValuationFeeDetailsItem
    {
        public decimal? SequenceNumber { get; }

        public string ComponentDescription { get;}

        public string OccupantType { get;}

        public decimal? NumberOfOccupants { get;}

        public decimal? TableNumberSectLineSeq { get;}

        public decimal? SquareFeet { get;}

        public string SectionDescription { get;}

        public string ConstructionTypeDescription { get;}

        public decimal? Cost { get; }

        public decimal? ExtendedValue { get;  }

        public ValuationFeeDetailsItem(decimal? sequenceNumber, string componentDescription, string occupantType, decimal? numberOfOccupants,
                                       decimal? tableNumberSectLineSeq, decimal? squareFeet, string sectionDescription, string constructionTypeDescription,
                                       decimal? cost, decimal? extendedValue)
        {
            SequenceNumber = sequenceNumber;
            ComponentDescription = componentDescription;
            OccupantType = occupantType;
            NumberOfOccupants = numberOfOccupants;
            TableNumberSectLineSeq = tableNumberSectLineSeq;
            SquareFeet = squareFeet;
            SectionDescription = sectionDescription;
            ConstructionTypeDescription = constructionTypeDescription;
            Cost = cost;
            ExtendedValue = extendedValue;
        }
    }
}
