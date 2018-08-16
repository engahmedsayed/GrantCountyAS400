namespace GrantCountyAs400.Domain.Assessment
{
    public class Assessment
    {
        public int Id { get; set; }
        public decimal ParcelNumber { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerName { get; }
        public string ContractHolderName { get; }
        public decimal TaxCodeArea { get; }
        public string TaxCodeDesc { get; }

        public Assessment(int id, decimal parcelNumber, string taxPayerName, string titleOwnerName, string contractHolderName, decimal taxCodeArea,
            string taxCodeDesc)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            TaxPayerName = taxPayerName;
            TitleOwnerName = titleOwnerName;
            ContractHolderName = contractHolderName;
            TaxCodeArea = taxCodeArea;
            TaxCodeDesc = taxCodeDesc;
        }
    }
}