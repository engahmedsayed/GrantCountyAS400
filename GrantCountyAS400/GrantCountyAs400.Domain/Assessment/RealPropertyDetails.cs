using System;

namespace GrantCountyAs400.Domain.Assessment
{
    public class RealPropertyDetails
    {
        public decimal ParcelNumber { get; }
        public string TaxPayerCode { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerCode { get; }
        public string TitleOwnerName { get; }
        public string ContractHolderCode { get; }
        public string ContractHolderName { get; }
        public decimal TaxYear { get; }
        public DateTime? NameChangeDate { get; }
        public string NameChangeId { get; }
        public string NameChangeReason { get; }
        public string LoanNumber { get; }
        public string PlatCode { get; }
        public string PlatCodeType { get; }
        public string BlockNumber { get; }
        public string LotNumber { get; }
        public string UnitNumber { get; }
        public string DockNumber { get; }
        public string Description1 { get; }
        public string Description2 { get; }
        public string Description3 { get; }
        public string Description4 { get; }
        public string Description5 { get; }
        public decimal TaxCodeArea { get; }
        public string TaxCodeDesc { get; }
        public decimal LandUseCode { get; }
        public DateTime ChangeDate { get; }
        public string ChangeId { get; }
        public string ChangeReasonCode { get; }
        public string UseCodeShortDesc { get; }
        public string ZoneCode { get; }
        public string ZoneCodeDesc { get; }
        public string TaxStatus { get; }
        public string RevalutionPhase { get; }
        public decimal UnimprovedLandAcres { get; }
        public decimal ImprovedLandAcers { get; }
        public decimal TimberAcers { get; }
        public decimal UnimprovedLandValue { get; }
        public decimal ImprovedLandValue { get; }
        public decimal TimberlandValue { get; }
        public decimal BuildingValue { get; }
        public decimal FmbuildingValue { get; }
        public decimal FmunimprovedLandValue { get; }
        public decimal FmimprovedLandValue { get; }
        public decimal FmtimberValue { get; }
        public decimal? NewConstructionBuildingAv { get; }
        public decimal AssocMhparcel { get; }
        public decimal AffidavitAssessmentYear { get; }
        public decimal AffidavitTaxYear { get; }
        public decimal OpenspaceApplicationNum { get; }
        public decimal OpenSpaceAgreementNum { get; }
        public decimal UndividedInterestPercent { get; }
        public decimal MobileHomeValue { get; }
        public string SeniorCitizenCode { get; }
        public string SubsidiaryParcelCode { get; }

        public RealPropertyDetails(decimal parcelNumber, string taxPayerCode, string taxPayerName, string titleOwnerCode, string titleOwnerName,
            string contractHolderCode, string contractHolderName, decimal taxYear, DateTime? nameChangeDate, string nameChangeId, string nameChangeReason,
            string loanNumber, string platCode, string platCodeType, string blockNumber, string lotNumber, string unitNumber, string dockNumber,
            string description1, string description2, string description3, string description4, string description5, decimal taxCodeArea,
            string taxCodeDesc, decimal landUseCode, DateTime changeDate, string changeId, string changeReasonCode, string useCodeShortDesc,
            string zoneCode, string zoneCodeDesc, string taxStatus, string revalutionPhase, decimal unimprovedLandAcres, decimal improvedLandAcers,
            decimal timberAcers, decimal unimprovedLandValue, decimal improvedLandValue, decimal timberlandValue, decimal buildingValue,
            decimal fmbuildingValue, decimal fmunimprovedLandValue, decimal fmimprovedLandValue, decimal fmtimberValue,
            decimal? newConstructionBuildingAv, decimal assocMhparcel, decimal affidavitAssessmentYear, decimal affidavitTaxYear,
            decimal openspaceApplicationNum, decimal openSpaceAgreementNum, decimal undividedInterestPercent, decimal mobileHomeValue,
            string seniorCitizenCode, string subsidiaryParcelCode)
        {
            ParcelNumber = parcelNumber;
            TaxPayerCode = taxPayerCode;
            TaxPayerName = taxPayerName;
            TitleOwnerCode = titleOwnerCode;
            TitleOwnerName = titleOwnerName;
            ContractHolderCode = contractHolderCode;
            ContractHolderName = contractHolderName;
            TaxYear = taxYear;
            NameChangeDate = nameChangeDate;
            NameChangeId = nameChangeId;
            NameChangeReason = nameChangeReason;
            LoanNumber = loanNumber;
            PlatCode = platCode;
            PlatCodeType = platCodeType;
            BlockNumber = blockNumber;
            LotNumber = lotNumber;
            UnitNumber = unitNumber;
            DockNumber = dockNumber;
            Description1 = description1;
            Description2 = description2;
            Description3 = description3;
            Description4 = description4;
            Description5 = description5;
            TaxCodeArea = taxCodeArea;
            TaxCodeDesc = taxCodeDesc;
            LandUseCode = landUseCode;
            ChangeDate = changeDate;
            ChangeId = changeId;
            ChangeReasonCode = changeReasonCode;
            UseCodeShortDesc = useCodeShortDesc;
            ZoneCode = zoneCode;
            ZoneCodeDesc = zoneCodeDesc;
            TaxStatus = taxStatus;
            RevalutionPhase = revalutionPhase;
            UnimprovedLandAcres = unimprovedLandAcres;
            ImprovedLandAcers = improvedLandAcers;
            TimberAcers = timberAcers;
            UnimprovedLandValue = unimprovedLandValue;
            ImprovedLandValue = improvedLandValue;
            TimberlandValue = timberlandValue;
            BuildingValue = buildingValue;
            FmbuildingValue = fmbuildingValue;
            FmunimprovedLandValue = fmunimprovedLandValue;
            FmimprovedLandValue = fmimprovedLandValue;
            FmtimberValue = fmtimberValue;
            NewConstructionBuildingAv = newConstructionBuildingAv;
            AssocMhparcel = assocMhparcel;
            AffidavitAssessmentYear = affidavitAssessmentYear;
            AffidavitTaxYear = affidavitTaxYear;
            OpenspaceApplicationNum = openspaceApplicationNum;
            OpenSpaceAgreementNum = openSpaceAgreementNum;
            UndividedInterestPercent = undividedInterestPercent;
            MobileHomeValue = mobileHomeValue;
            SeniorCitizenCode = seniorCitizenCode;
            SubsidiaryParcelCode = subsidiaryParcelCode;
        }
    }
}