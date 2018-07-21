using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AsmtmasterNameAddress
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public string NameCode { get; set; }
        public string NameFormat { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string NameChangeId { get; set; }
        public string PhoneNumber { get; set; }
        public string TaxServiceCode { get; set; }
        public string NameChangeReason { get; set; }
        public string ZipDeliveryPoint { get; set; }
        public string Casscertified { get; set; }
        public DateTime? NameChangeDate { get; set; }
    }
}
