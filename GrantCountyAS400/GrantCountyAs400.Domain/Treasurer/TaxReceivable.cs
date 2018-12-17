namespace GrantCountyAs400.Domain.Treasurer
{
    public class TaxReceivable
    {
        public int Id { get; }
        public decimal? ParcelNumber { get; }
        public decimal? ParentParcelNumber { get; }
        public string TaxpayerCode { get; }
        public string TitleOwnerCode { get; }
        public decimal? TaxCodeArea { get; }
        public decimal? LandUseCode { get; }

        public string TaxpayerName { get; }
        public string TitleOwnerName { get; }

        public decimal? ParcelExtension { get; }

        public TaxReceivable(int id, decimal? parcelNumber, decimal? parentParcelNumber, string taxpayerCode, string titleOwnerCode, decimal? taxCodeArea,
            decimal? landUseCode, string taxpayerName, string titleOwnerName, decimal? parcelExtension)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            ParentParcelNumber = parentParcelNumber;
            TaxpayerCode = taxpayerCode;
            TitleOwnerCode = titleOwnerCode;
            TaxCodeArea = taxCodeArea;
            LandUseCode = landUseCode;
            TaxpayerName = taxpayerName;
            TitleOwnerName = titleOwnerName;
            ParcelExtension = parcelExtension;
        }
    }
}