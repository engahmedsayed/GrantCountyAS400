using System;

namespace GrantCountyAs400.Domain.Building
{
    public class ManufactureModularPermit
    {
        public string OfficeProjectDescription { get; }
        public string ManorMod { get; }
        public decimal YearManufactured { get; }
        public string NewOrUsed { get; }
        public decimal SquareFeet { get; }
        public string Dimensions { get; }
        public string BuildingDescription { get; }
        public string ResCommStor { get; }
        public string CommercialUseDesc1 { get; }
        public string CommercialUseDesc2 { get; }
        public string DealerNameCode { get; }
        public string ManufacturerName { get; }
        public string LotorMan { get; }
        public DateTime? ApproxPurchaseDate { get; }
        public DateTime? ApproxDeliveryDate { get; }
        public string InstallationIncludedInPrice { get; }
        public string MovingFromGrantCounty { get; }
        public string CountyStateIfNotGrant { get; }
        public string TitleOwnerName { get; }
        public string TaxpayerName { get; }
        public decimal MovingFromParcelNumber { get; }
        public string MovingFromAddress { get; }
        public string CertInstallerCode { get; }
        public string FireDistrictCode { get; }
        public string FireFlowAlreadyProvided { get; }
        public string AdditionalFireFlowRequired { get; }
        public string AmountOfFireFlowRequired { get; }
        public decimal BldgDeptSetback { get; }
        public decimal FireMarshalSetback { get; }

        public decimal? ExtendedValue { get; }
        public string LongFireDistrictName { get; }
        public bool HasBuildingApplicationCondition { get; }
        public bool HasBuildingApplicationInspection { get; }
        public DealersInstallersArchitectInfo DealerInfo { get; }
        public DealersInstallersArchitectInfo InstallerInfo { get; }
        public PermitApprovedInfo BldgDept { get; }
        public PermitApprovedInfo FireMarshal { get; }

        public ManufactureModularPermit(string officeProjectDescription, string manorMod, decimal yearManufactured, string newOrUsed, decimal squareFeet,
            string dimensions, string buildingDescription, string resCommStor, string commercialUseDesc1, string commercialUseDesc2, string dealerNameCode,
            string manufacturerName, string lotorMan, DateTime? approxPurchaseDate, DateTime? approxDeliveryDate, string installationIncludedInPrice,
            string movingFromGrantCounty, string countyStateIfNotGrant, string titleOwnerName, string taxpayerName, decimal movingFromParcelNumber,
            string movingFromAddress, string certInstallerCode, string fireDistrictCode, string fireFlowAlreadyProvided, string additionalFireFlowRequired,
            string amountOfFireFlowRequired, decimal bldgDeptSetback, decimal fireMarshalSetback, decimal? extendedValue, string longFireDistrictName,
            bool hasBuildingApplicationCondition, bool hasBuildingApplicationInspection, PermitApprovedInfo bldgDept, PermitApprovedInfo fireMarshal,
            DealersInstallersArchitectInfo dealerInfo, DealersInstallersArchitectInfo installerInfo)
        {
            OfficeProjectDescription = officeProjectDescription;
            ManorMod = manorMod;
            YearManufactured = yearManufactured;
            NewOrUsed = newOrUsed;
            SquareFeet = squareFeet;
            Dimensions = dimensions;
            BuildingDescription = buildingDescription;
            ResCommStor = resCommStor;
            CommercialUseDesc1 = commercialUseDesc1;
            CommercialUseDesc2 = commercialUseDesc2;
            DealerNameCode = dealerNameCode;
            ManufacturerName = manufacturerName;
            LotorMan = lotorMan;
            ApproxPurchaseDate = approxPurchaseDate;
            ApproxDeliveryDate = approxDeliveryDate;
            InstallationIncludedInPrice = installationIncludedInPrice;
            MovingFromGrantCounty = movingFromGrantCounty;
            CountyStateIfNotGrant = countyStateIfNotGrant;
            TitleOwnerName = titleOwnerName;
            TaxpayerName = taxpayerName;
            MovingFromParcelNumber = movingFromParcelNumber;
            MovingFromAddress = movingFromAddress;
            CertInstallerCode = certInstallerCode;
            FireDistrictCode = fireDistrictCode;
            FireFlowAlreadyProvided = fireFlowAlreadyProvided;
            AdditionalFireFlowRequired = additionalFireFlowRequired;
            AmountOfFireFlowRequired = amountOfFireFlowRequired;
            BldgDeptSetback = bldgDeptSetback;
            FireMarshalSetback = fireMarshalSetback;

            ExtendedValue = extendedValue;
            LongFireDistrictName = longFireDistrictName;
            HasBuildingApplicationCondition = hasBuildingApplicationCondition;
            HasBuildingApplicationInspection = hasBuildingApplicationInspection;
            BldgDept = bldgDept;
            FireMarshal = fireMarshal;
            DealerInfo = dealerInfo;
            InstallerInfo = installerInfo;
        }
    }
}