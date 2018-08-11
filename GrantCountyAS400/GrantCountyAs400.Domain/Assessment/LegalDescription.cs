using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment
{
    public class LegalDescription
    {
        public int Id { get; }
        public decimal ParcelNumber { get; }
        public string Descrtiption { get; }

        public LegalDescription(int id, decimal parcelNumber, string descrtiption)
        {
            Id = id;
            ParcelNumber = parcelNumber;
            Descrtiption = descrtiption;
        }
    }

    public class RealPropertyWithLegalDescriptions
    {
        public decimal ParcelNumber { get; }
        public string TaxPayerName { get; }
        public string TitleOwnerName { get; }
        public string ContractHolderName { get; }
        public IEnumerable<LegalDescription> LegalDescrtiptions { get; }

        public RealPropertyWithLegalDescriptions(decimal parcelNumber, string taxPayerName, string titleOwnerName, string contractHolderName,
                                IEnumerable<LegalDescription> legalDescrtiptions)
        {
            ParcelNumber = parcelNumber;
            TaxPayerName = taxPayerName;
            TitleOwnerName = titleOwnerName;
            ContractHolderName = contractHolderName;
            LegalDescrtiptions = legalDescrtiptions;
        }
    }
}