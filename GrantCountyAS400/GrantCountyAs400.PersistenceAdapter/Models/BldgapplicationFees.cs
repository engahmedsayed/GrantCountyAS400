using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgapplicationFees
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string FeeCode { get; set; }
        public decimal? SequenceNumber { get; set; }
        public decimal? NumberOfUnits { get; set; }
        public decimal? UnitCharge { get; set; }
        public decimal? ExtendedAmount { get; set; }
        public string FeeDescription { get; set; }
        public string MinMaxFlag { get; set; }
        public decimal? FeeDistributionCategory { get; set; }
        public decimal? FeeIncrement { get; set; }
        public decimal? BaseFee { get; set; }
        public string ChargeByValue { get; set; }
    }
}
