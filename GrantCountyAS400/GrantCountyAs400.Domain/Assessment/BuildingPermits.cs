using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment
{
    public class BuildingPermits
    {
        public decimal? ParcelNumber { get; }

        public string TaxPayer { get; }

        public string Owner { get; }

        public string FirstDescription { get; }

        public string LandUse { get;}

        public string SecondDescription { get; }

        public decimal? TotalAcre { get;}

        public string ThirdDescription { get; }

        public decimal? LandAv { get; }

        public string FourthDescription { get; }

        public decimal? BuildingValue { get;}


        public List<BuildingPermitsLineValue> LineValues { get; }

        public BuildingPermits(decimal? parcelNumber, string taxPayer, string owner, string firstDescription, string landUse
                               , string secondDescription, decimal? totalAcre, string thirdDescription, decimal? landAv
                               , string fourthDescription, decimal? buildingValue, List<BuildingPermitsLineValue> lineValues)
        {
            ParcelNumber = parcelNumber;
            TaxPayer = taxPayer;
            Owner = owner;
            FirstDescription = firstDescription;
            LandUse = landUse;
            SecondDescription = secondDescription;
            TotalAcre = totalAcre;
            ThirdDescription = thirdDescription;
            LandAv = landAv;
            FourthDescription = fourthDescription;
            BuildingValue = buildingValue;
            LineValues = lineValues;
        }
    }

    public class BuildingPermitsLineValue
    {
        public int PermitNumber { get; }

        public int PermitAddenDum { get; }

        public DateTime? PermitIssueDate { get;}

        public string JurisdictionCode { get; }

        public decimal? PercentComplete { get; }

        public decimal? EstimatedValue { get; }

        public string NewOrDemo { get;}

        public string Comment { get; set; }

        public BuildingPermitsLineValue(int permitNumber, int permitAddenDum, DateTime? permitIssueDate, string jurisdictionCode
                                        , decimal? percentComplete, decimal? estimatedValue, string newOrDemo, string comment)
        {
            PermitNumber = permitNumber;
            PermitAddenDum = permitAddenDum;
            PermitIssueDate = permitIssueDate;
            JurisdictionCode = jurisdictionCode;
            PercentComplete = percentComplete;
            EstimatedValue = estimatedValue;
            NewOrDemo = newOrDemo;
            Comment = comment;
        }
    }
}
