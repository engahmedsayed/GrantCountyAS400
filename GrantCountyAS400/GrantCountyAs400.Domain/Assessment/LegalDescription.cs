namespace GrantCountyAs400.Domain.Assessment
{
    public class LegalDescription
    {
        public int Id { get; }
        public decimal ParcelNumber { get; }
        public string Descrtiption { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerName { get; }
        public string ContractHolderName { get; }

        public LegalDescription(int id, decimal parcelNumber, string descrtiption, string taxPayerName, string titleOwnerName,
                                string contractHolderName)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            Descrtiption = descrtiption;
            TaxPayerName = taxPayerName;
            TitleOwnerName = titleOwnerName;
            ContractHolderName = contractHolderName;
        }
    }
}