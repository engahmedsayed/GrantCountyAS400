using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctVendor
    {
        public string VendorId { get; set; }
        public decimal Number { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string DisplayFlag { get; set; }
        public string TaxFlag { get; set; }
        public string TaxId { get; set; }
        public string PaymentTerms { get; set; }
        public string Phone { get; set; }
        public string Representative { get; set; }
        public string RepresentativeKind { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ZipCodeSuffix { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalCity { get; set; }
        public string PhysicalState { get; set; }
        public string PhysicalZipCode { get; set; }
        public string PhysicalZipCodeSuffix { get; set; }
        public string OldKey { get; set; }
        public int Id { get; set; }
    }
}
