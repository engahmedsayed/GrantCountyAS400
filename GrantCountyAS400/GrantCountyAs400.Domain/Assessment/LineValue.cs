using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment
{
    public class LineValue
    {
        public string AsmtrealPropertyAssociatedPersonsNameCode { get; }

        public string AsmtmasterNameAddressNameCode { get; }

        public string Comment { get; }

        public LineValue(string asmtrealPropertyAssociatedPersonsNameCode, string asmtmasterNameAddressNameCode, string comment)
        {
            AsmtrealPropertyAssociatedPersonsNameCode = asmtrealPropertyAssociatedPersonsNameCode;
            AsmtmasterNameAddressNameCode = asmtmasterNameAddressNameCode;
            Comment = comment;
        }
    }
}
