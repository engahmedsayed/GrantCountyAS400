namespace GrantCountyAs400.Domain.Assessment
{
    public class ManufacturedHomePark
    {
        public int Id { get; }
        public string MhparkCode { get; }
        public string Name { get; }
        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public string ContactNameCode { get; }
        public string ContactName { get; }
        public string TelephoneNumber { get; }
        public decimal ParcelNumber { get; }

        public ManufacturedHomePark(int id, string mhparkCode, string name, string addressLine1, string addressLine2, string contactNameCode,
            string contactName, string telephoneNumber, decimal parcelNumber)
        {
            Id = id;
            MhparkCode = mhparkCode;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            ContactNameCode = contactNameCode;
            ContactName = contactName;
            TelephoneNumber = telephoneNumber;
            ParcelNumber = parcelNumber;
        }
    }
}