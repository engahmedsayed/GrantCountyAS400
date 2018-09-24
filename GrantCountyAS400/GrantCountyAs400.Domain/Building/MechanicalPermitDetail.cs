using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class MechanicalPermitDetail
    {        
        public string OfficeProjectDescription { get;   }

        public string NrecReceived { get;   }

        public string FireDistrictCode { get;   }

        public string LongFireDistrictName { get;   }
        
        public string FireDistrictDisplay => FireDistrictCode + LongFireDistrictName;

        public decimal? BldgDeptSetbacks { get;   }

        
        public decimal? FireMarshallSetback { get;   }

        public bool IsConditionExistInApcn { get;   }

        public bool IsConditionExistInApin { get;   }

        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public MechanicalPermitDetail(string officeProjectDescription, string nrecReceived, string fireDistrictCode,
                                      string longFireDistrictName, decimal? bldgDeptSetbacks, decimal? fireMarshallSetback,
                                      bool isConditionExistInApcn, bool isConditionExistInApin, PermitApprovedInfo bldgDept,
                                      PermitApprovedInfo fireMarshal)
        {
            OfficeProjectDescription = officeProjectDescription;
            NrecReceived = nrecReceived;
            FireDistrictCode = fireDistrictCode;
            LongFireDistrictName = longFireDistrictName;
            BldgDeptSetbacks = bldgDeptSetbacks;
            FireMarshallSetback = fireMarshallSetback;
            IsConditionExistInApcn = isConditionExistInApcn;
            IsConditionExistInApin = isConditionExistInApin;
            BldgDept = bldgDept;
            FireMarshal = fireMarshal;
        }
    }
}
