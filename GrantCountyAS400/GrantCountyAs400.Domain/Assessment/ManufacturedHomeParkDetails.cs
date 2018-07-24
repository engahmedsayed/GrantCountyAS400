namespace GrantCountyAs400.Domain.Assessment
{
    public class ManufacturedHomeParkDetails
    {
        public string MhparkCode { get; }
        public string Name { get; }
        public string AddressLine1 { get; }
        public string AddressLine2 { get; }
        public string ContactNameCode { get; }
        public string ContactName { get; }
        public string TelephoneNumber { get; }
        public decimal ParcelNumber { get; }
        public string Filler01 { get; }
        public decimal SpaceNumber { get; }
        public string QualCode { get; }
        public string Description1 { get; }
        public string Description2 { get; }
        public string Description3 { get; }
        public string Description4 { get; }
        public string Description5 { get; }

        public ManufacturedHomeParkDetails(string mhparkCode, string name, string addressLine1, string addressLine2, string contactNameCode,
            string contactName, string telephoneNumber, decimal parcelNumber, string filter, decimal spaceNumber, string description1,
            string description2, string description3, string description4, string description5)
        {
            MhparkCode = mhparkCode;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            ContactNameCode = contactNameCode;
            ContactName = contactName;
            TelephoneNumber = telephoneNumber;
            ParcelNumber = parcelNumber;
            Filler01 = filter;
            SpaceNumber = spaceNumber;
            Description1 = description1;
            Description2 = description2;
            Description3 = description3;
            Description4 = description4;
            Description5 = description5;
        }
    }
}