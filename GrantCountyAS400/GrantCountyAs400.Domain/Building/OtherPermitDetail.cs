using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class OtherPermitDetail
    {
        public string OfficeProjectDescription { get;}

        public string FireDistrictCode { get;}

        public string FireFlowAlreadyProvided{ get;  }

        public string AdditionalFireFlowRequired { get;}

        public string AmountOFFireFlowRequired { get;  }
        public decimal? BldgDeptSetback { get;}

        public decimal? FireMarshalSetback { get; }

        public string LongFireDistrictName { get; }

        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public bool IsConditionExistInApcn { get; }

        public bool IsConditionExistInApin { get;}

        public decimal? ExtendedValue { get; }

        public OtherPermitDetail(string officeProjectDescription, string fireDistrictCode, string fireFlowAlreadyProvided, 
                                 string additionalFireFlowRequired, string amountOFFireFlowRequired, decimal? bldgDeptSetback,
                                 decimal? fireMarshalSetback,PermitApprovedInfo bldgDept, PermitApprovedInfo fireMarshal,
                                 bool isConditionExistInApcn,bool isConditionExistInApin,decimal? extendedValue)
        {
            OfficeProjectDescription = officeProjectDescription;
            FireDistrictCode = fireDistrictCode;
            FireFlowAlreadyProvided = fireFlowAlreadyProvided;
            AdditionalFireFlowRequired = additionalFireFlowRequired;
            AmountOFFireFlowRequired = amountOFFireFlowRequired;
            BldgDeptSetback = bldgDeptSetback;
            FireMarshalSetback = fireMarshalSetback;
            BldgDept = bldgDept;
            FireMarshal = fireMarshal;
            IsConditionExistInApcn = isConditionExistInApcn;
            IsConditionExistInApin = isConditionExistInApin;
            ExtendedValue = extendedValue;
        }
    }
}
