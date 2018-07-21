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
}