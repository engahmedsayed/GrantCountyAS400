namespace GrantCountyAs400.Domain.Treasurer
{
    public class TreasurerMaster
    {
        public int Id { get; }
        public decimal? ParcelNumber { get; }
        public decimal? ParentParcelNumber { get; }
        public string TaxpayerCode { get; }
        public string TitleOwnerCode { get; }
        public decimal? TaxCodeArea { get; }
        public decimal? LandUseCode { get; }

        public string TaxpayerName { get; }

        public TreasurerMaster(int id, decimal? parcelNumber, decimal? parentParcelNumber, string taxpayerCode, string titleOwnerCode, decimal? taxCodeArea, 
            decimal? landUseCode, string taxpayerName)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            ParentParcelNumber = parentParcelNumber;
            TaxpayerCode = taxpayerCode;
            TitleOwnerCode = titleOwnerCode;
            TaxCodeArea = taxCodeArea;
            LandUseCode = landUseCode;
            TaxpayerName = taxpayerName;
        }
    }
}