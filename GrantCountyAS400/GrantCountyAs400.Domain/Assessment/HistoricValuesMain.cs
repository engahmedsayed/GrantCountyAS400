using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment
{
    public class HistoricValuesMain
    {

        public List<HistoricValuesItems> Items { get; set; }

    }

    public class HistoricValuesItems
    {
        //
        public decimal? ParcelNumber { get; }

        public int? TaxYear { get; }

        public string RevaluationPhase { get; }

        public string TaxPayerCode { get; }

        public decimal? TaxCodeArea { get; }

        public string Description1 { get; }

        public string Description2 { get; }

        public string Description3 { get; set; }

        public string Description4 { get; }
        public decimal? LandUseCode { get; }

        public string TaxStatus { get; }

        public decimal? BuildingValue { get; }

        public decimal? ImprovedLandValue { get; }

        public decimal? UnimprovedLandValue { get; }
        //

        public decimal? UndividedInterestPercent { get; }


        public string SubsidiaryParcelCode { get; }

        public decimal? UnimprovedLandAcres { get; }

        public decimal? ImprovedLandAcres { get; }

        public decimal? FirePatrolAcres { get; }

        public decimal? MobileHomeValue { get; }

        public string ChangeReasonCode { get; }

        public HistoricValuesItems(decimal? parcelNumber, int? taxYear, string revaluationPhase, string taxPayerCode, decimal? taxCodeArea,
                                   string description1, string description2, string description3, string description4, decimal? landUseCode, 
                                   string taxStatus, decimal? buildingValue, decimal? improvedLandValue, decimal? unimprovedLandValue, 
                                   decimal? undividedInterestPercent, string subsidiaryParcelCode, decimal? unimprovedLandAcres, decimal? improvedLandAcres,
                                   decimal? firePatrolAcres, decimal? mobileHomeValue, string changeReasonCode)
        {
            ParcelNumber = parcelNumber;
            TaxYear = taxYear;
            RevaluationPhase = revaluationPhase;
            TaxPayerCode = taxPayerCode;
            TaxCodeArea = taxCodeArea;
            Description1 = description1;
            Description2 = description2;
            Description3 = description3;
            Description4 = description4;
            LandUseCode = landUseCode;
            TaxStatus = taxStatus;
            BuildingValue = buildingValue;
            ImprovedLandValue = improvedLandValue;
            UnimprovedLandValue = unimprovedLandValue;
            UndividedInterestPercent = undividedInterestPercent;
            SubsidiaryParcelCode = subsidiaryParcelCode;
            UnimprovedLandAcres = unimprovedLandAcres;
            ImprovedLandAcres = improvedLandAcres;
            FirePatrolAcres = firePatrolAcres;
            MobileHomeValue = mobileHomeValue;
            ChangeReasonCode = changeReasonCode;
        }
    }
}
