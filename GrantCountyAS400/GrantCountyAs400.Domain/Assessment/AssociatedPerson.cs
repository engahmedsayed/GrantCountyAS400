using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment
{
    public class AssociatedPerson
    {
        public int Id { get;}

        public decimal? ParcelNumber { get; }

        public string TaxPayer { get; }

        public string Owner { get; }

        public string Description { get; }

        public string LandUse { get;}

        public string SecondDescription { get; }

        public string ThirdDescription { get; }

        public string FourthDescrition { get;}
        public string FifthDescription { get; }

        public DateTime? LineDate { get; }
        public decimal? AffidavitNumber { get; }
        public string ZoneCodeDescr { get; }

        public string TaxCodeDesc { get;}

        public decimal? FirePatrolAcres { get; }

        public decimal? UnImprovedLandAcres { get;}

        public decimal? ImprovedLandAcres { get;}

        public decimal? TotalAcres { get { return UnImprovedLandAcres + ImprovedLandAcres; } }

        public decimal? FMImprovedLandValue { get;}

        public decimal? BuildingValue{ get;}

        public decimal? AffidavitTaxYear { get; }

        public string AsmtrealPropertyAssociatedPersonsNameCode { get;}

        public string AsmtmasterNameAddressNameCode { get;}

        public string Comment { get;}

        public string AddressLine1 { get; }

        public string City { get; }

        public string State { get; }
        public string Zip { get;}

        public string LocalAddress { get { return City + "," + State + " " + Zip; } }

        public string ChangeId { get; }

        public DateTime? ChangeDate { get; }




        public AssociatedPerson(int id, decimal? parcelNumber, string taxPayer, string owner
                                , string description, string landUse, string secondDescription,string thirdDescription
                                ,string fourthDescription,string fifthDescription,DateTime? lineDate,decimal? affidaviteNumber
                                ,string zoneCodeDesc,string taxCodeDesc,decimal? firePatrolAcres,decimal?unImprovedLandAcres
                                ,decimal? improvedLandAcres,decimal? fMImprovedLandValue,decimal? buildingValue
                                ,decimal? affidavitTaxYear,string asmtrealPropertyAssociatedPersonsNameCode
                                ,string asmtmasterNameAddressNameCode,string comment, string addressLine1
                                ,string city,string state,string zip,string changeId,DateTime? changeDate)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            TaxPayer = taxPayer;
            Owner = owner;
            Description = description;
            LandUse = landUse;
            SecondDescription = secondDescription;
            ThirdDescription = thirdDescription;
            FourthDescrition = fourthDescription;
            FifthDescription = fifthDescription;
            LineDate = lineDate;
            AffidavitNumber = affidaviteNumber;
            ZoneCodeDescr = zoneCodeDesc;
            TaxCodeDesc = taxCodeDesc;
            FirePatrolAcres = firePatrolAcres;
            UnImprovedLandAcres = unImprovedLandAcres;
            ImprovedLandAcres = improvedLandAcres;
            FMImprovedLandValue = fMImprovedLandValue;
            BuildingValue = buildingValue;
            AffidavitTaxYear = affidaviteNumber;
            AsmtrealPropertyAssociatedPersonsNameCode = asmtrealPropertyAssociatedPersonsNameCode;
            AsmtmasterNameAddressNameCode = asmtmasterNameAddressNameCode;
            Comment = comment;
            City = city;
            State = state;
            Zip = zip;
            AddressLine1 = addressLine1;
            ChangeId = changeId;
            ChangeDate = changeDate;
        }
    }
}
