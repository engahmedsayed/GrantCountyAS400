using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class GradingExcavationPermitDetail
    {
        public string ApplicationProjectDescription { get;}

        public string OfficeProjectDescription { get; }

        public decimal? CubicYardsOfFill { get;}

        public decimal? PercentOfSlope { get; }

        public string SoilErosionControlRequired { get;}

        public string DustAndTrackControlReceived { get;}

        public DateTime? DustAndTrackReceivedDate { get;}

        public string EngineeringReceived { get; }

        public DateTime? EngineeringReceivedDate { get; }

        public string FireDistrictCode { get;}

        public string ShortFireDistrictName { get; }

        public string FireFlowAlreadyProvided { get; }

        public string AdditionalFireFlowRequired { get;}

        public string AmountOfFireFlowRequired { get;}

        public decimal? BldgDeptSetback { get; }

        public decimal? FireMarshalSetback { get; }

        public bool IsConditionExistInApcn { get; }

        public bool IsConditionExistInApin { get; }
        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public GradingExcavationPermitDetail(string applicationProjectDescription, string officeProjectDescription,
                                             decimal? cubicYardsOfFill, decimal? percentOfSlope, string soilErosionControlRequired,
                                             string dustAndTrackControlReceived, DateTime? dustAndTrackReceivedDate, 
                                             string engineeringReceived, DateTime? engineeringReceivedDate, 
                                             string fireDistrictCode, string shortFireDistrictName, 
                                             string fireFlowAlreadyProvided, string additionalFireFlowRequired,
                                             string amountOfFireFlowRequired, decimal? bldgDeptSetback, 
                                             decimal? fireMarshalSetback, bool isConditionExistInApcn,
                                             bool isConditionExistInApin, PermitApprovedInfo bldgDept,
                                             PermitApprovedInfo fireMarshal)
        {
            ApplicationProjectDescription = applicationProjectDescription;
            OfficeProjectDescription = officeProjectDescription;
            CubicYardsOfFill = cubicYardsOfFill;
            PercentOfSlope = percentOfSlope;
            SoilErosionControlRequired = soilErosionControlRequired;
            DustAndTrackControlReceived = dustAndTrackControlReceived;
            DustAndTrackReceivedDate = dustAndTrackReceivedDate;
            EngineeringReceived = engineeringReceived;
            EngineeringReceivedDate = engineeringReceivedDate;
            FireDistrictCode = fireDistrictCode;
            ShortFireDistrictName = shortFireDistrictName;
            FireFlowAlreadyProvided = fireFlowAlreadyProvided;
            AdditionalFireFlowRequired = additionalFireFlowRequired;
            AmountOfFireFlowRequired = amountOfFireFlowRequired;
            BldgDeptSetback = bldgDeptSetback;
            FireMarshalSetback = fireMarshalSetback;
            IsConditionExistInApcn = isConditionExistInApcn;
            IsConditionExistInApin = isConditionExistInApin;
            BldgDept = bldgDept;
            FireMarshal = fireMarshal;
        }
    }
}
