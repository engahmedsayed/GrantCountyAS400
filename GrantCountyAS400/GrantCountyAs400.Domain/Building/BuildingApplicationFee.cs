namespace GrantCountyAs400.Domain.Building
{
    public class BuildingApplicationFee
    {
        public int Id { get; }
        public string JurisdictionCode { get; }
        public string DepartmentCode { get; }
        public decimal ApplicationYear { get; }
        public decimal ApplicationNumber { get; }
        public decimal? AddendumNumber { get; }
        public string FeeCode { get; }
        public decimal? SequenceNumber { get; }
        public decimal? NumberOfUnits { get; }
        public decimal? UnitCharge { get; }
        public decimal? ExtendedAmount { get; }
        public string FeeDescription { get; }
        public string MinMaxFlag { get; }
        public decimal? FeeDistributionCategory { get; }
        public decimal? FeeIncrement { get; }
        public decimal? BaseFee { get; }
        public string ChargeByValue { get; }

        public BuildingApplicationFee(int id, string jurisdictionCode, string departmentCode, decimal applicationYear, decimal applicationNumber,
            decimal? addendumNumber, string feeCode, decimal? sequenceNumber, decimal? numberOfUnits, decimal? unitCharge, decimal? extendedAmount,
            string feeDescription, string minMaxFlag, decimal? feeDistributionCategory, decimal? feeIncrement, decimal? baseFee, string chargeByValue)
        {
            Id = id;
            JurisdictionCode = jurisdictionCode;
            DepartmentCode = departmentCode;
            ApplicationYear = applicationYear;
            ApplicationNumber = applicationNumber;
            AddendumNumber = addendumNumber;
            FeeCode = feeCode;
            SequenceNumber = sequenceNumber;
            NumberOfUnits = numberOfUnits;
            UnitCharge = unitCharge;
            ExtendedAmount = extendedAmount;
            FeeDescription = feeDescription;
            MinMaxFlag = minMaxFlag;
            FeeDistributionCategory = feeDistributionCategory;
            FeeIncrement = feeIncrement;
            BaseFee = baseFee;
            ChargeByValue = chargeByValue;
        }
    }
}