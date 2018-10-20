using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreaspersonalPropertyMaster
    {
        public int Id { get; set; }
        public string RecordCode { get; set; }
        public decimal? PersPropParcel { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public string SeniorCitizenCd { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? LandUseCode { get; set; }
        public string TaxpayerCode { get; set; }
        public string TitleOwnerCode { get; set; }
        public string BusinessName { get; set; }
        public string Location { get; set; }
        public string HeadofHouseholdExemption { get; set; }
        public decimal? Abs1Value { get; set; }
        public decimal? Abs2Value { get; set; }
        public decimal? Abs3Value { get; set; }
        public decimal? Abs4Value { get; set; }
        public decimal? Abs5Value { get; set; }
        public decimal? Abs6Value { get; set; }
        public decimal? Abs7Value { get; set; }
        public decimal? Abs8Value { get; set; }
        public decimal? Abs9Value { get; set; }
        public decimal? Abs10Value { get; set; }
        public decimal? Abs11Value { get; set; }
        public decimal? Abs12Value { get; set; }
        public decimal? Abs13Value { get; set; }
        public decimal? Abs14Value { get; set; }
        public string Filler01 { get; set; }
        public string NameChangeReason { get; set; }
        public string FormStatCd { get; set; }
        public string Filler02 { get; set; }
        public decimal? PenPercent { get; set; }
        public string TaxStatus { get; set; }
        public string Filler03 { get; set; }
        public string LienCertNumber { get; set; }
        public string StateOfIncorporation { get; set; }
        public string ChgId { get; set; }
        public string ChangeReasonCode { get; set; }
        public string RecType { get; set; }
        public string ExemptRegNumber { get; set; }
        public string Filler04 { get; set; }
        public string NameChangeId { get; set; }
        public DateTime? NameChangeDate { get; set; }
        public DateTime? FormReturnDate { get; set; }
        public DateTime? LienDate { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
