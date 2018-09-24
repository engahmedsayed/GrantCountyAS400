using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class StructurePermitDetail
    {
        public string OfficeProjectDescription { get;   }

        public string ResAgCommOther { get;   }

        public decimal? NumberOfBedrooms { get;   }

        public decimal? NumberOfBathrooms { get;   }

        public decimal? NumberOfUnits { get;   }

        public string Heated { get;   }

        public string HeatSourceDescription { get;   }

        public string PrescriptiveReviewDone { get;   }

        public string WattsunRunReviewDone { get;   }

        public string NRECReceived { get;   }

        public string PlansAnalystReviewDone { get;   }

        public string PlansAnalystReviewDescription { get;   }

        public string PlansAnalystReviewDoneDisplay => PlansAnalystReviewDone + PlansAnalystReviewDescription;

        public string SprinklerSystemRequired { get;   }

        public string SprinklerSyustemDescription { get;   }

        public string SprinklerSystemRequiredDisplay => SprinklerSystemRequired + SprinklerSyustemDescription;


        public string AlarmSystemRequired { get;   }

        public string AlarmSystemDescription { get;   }

        public string AlarmSystemRequiredDisplay => AlarmSystemRequired + AlarmSystemDescription;

        public string SpecialInspectionRequired { get;   }

        public string SpecialInspectionDescription { get;   }

        public string SpecialInspectionRequiredDisplay => SpecialInspectionRequired + SpecialInspectionDescription;

        public string PermitIncludePlumbing { get;   }

        public string PermitIncludeMechanical { get;   }

        public string FireDistrictCode { get;   }

        public string ShortFireDistrictName { get;   }

        public string FireDistrictCodeDisplay => FireDistrictCode + " " + ShortFireDistrictName;

        public string FireFlowAlreadyProvided { get;   }

        public string AdditionalFireFlowRequired { get;   }

        public string AmountOfFireFlowRequired { get;   }

        public decimal? BldgDeptSetback { get;   }

        public decimal? FireMarshalSetback { get;   }
        public bool IsConditionExistInApcn { get;   }

        public bool IsConditionExistInApin { get;   }

        public decimal? ExtendedValue { get;   }
        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public StructurePermitDetail(string officeProjectDescription, string resAgCommOther, decimal? numberOfBedrooms,
                                     decimal? numberOfBathrooms, decimal? numberOfUnits, string heated,
                                     string heatSourceDescription, string prescriptiveReviewDone, string wattsunRunReviewDone,
                                     string nRECReceived, string plansAnalystReviewDone, string plansAnalystReviewDescription,
                                     string sprinklerSystemRequired, string sprinklerSyustemDescription,
                                     string alarmSystemRequired, string alarmSystemDescription, string specialInspectionRequired,
                                     string specialInspectionDescription, string permitIncludePlumbing,
                                     string permitIncludeMechanical, string fireDistrictCode, string shortFireDistrictName,
                                     string fireFlowAlreadyProvided, string additionalFireFlowRequired,
                                     string amountOfFireFlowRequired, decimal? bldgDeptSetback, decimal? fireMarshalSetback,
                                     bool isConditionExistInApcn, bool isConditionExistInApin, decimal? extendedValue,
                                     PermitApprovedInfo bldgDept, PermitApprovedInfo fireMarshal)
        {
            OfficeProjectDescription = officeProjectDescription;
            ResAgCommOther = resAgCommOther;
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfBathrooms = numberOfBathrooms;
            NumberOfUnits = numberOfUnits;
            Heated = heated;
            HeatSourceDescription = heatSourceDescription;
            PrescriptiveReviewDone = prescriptiveReviewDone;
            WattsunRunReviewDone = wattsunRunReviewDone;
            NRECReceived = nRECReceived;
            PlansAnalystReviewDone = plansAnalystReviewDone;
            PlansAnalystReviewDescription = plansAnalystReviewDescription;
            SprinklerSystemRequired = sprinklerSystemRequired;
            SprinklerSyustemDescription = sprinklerSyustemDescription;
            AlarmSystemRequired = alarmSystemRequired;
            AlarmSystemDescription = alarmSystemDescription;
            SpecialInspectionRequired = specialInspectionRequired;
            SpecialInspectionDescription = specialInspectionDescription;
            PermitIncludePlumbing = permitIncludePlumbing;
            PermitIncludeMechanical = permitIncludeMechanical;
            FireDistrictCode = fireDistrictCode;
            ShortFireDistrictName = shortFireDistrictName;
            FireFlowAlreadyProvided = fireFlowAlreadyProvided;
            AdditionalFireFlowRequired = additionalFireFlowRequired;
            AmountOfFireFlowRequired = amountOfFireFlowRequired;
            BldgDeptSetback = bldgDeptSetback;
            FireMarshalSetback = fireMarshalSetback;
            IsConditionExistInApcn = isConditionExistInApcn;
            IsConditionExistInApin = isConditionExistInApin;
            ExtendedValue = extendedValue;
            BldgDept = bldgDept;
            FireMarshal = fireMarshal;
        }
    }
}
