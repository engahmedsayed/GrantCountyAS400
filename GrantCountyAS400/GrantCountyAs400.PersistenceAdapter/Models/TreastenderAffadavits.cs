using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class TreastenderAffadavits
    {
        public int Id { get; set; }
        public string RecCode { get; set; }
        public decimal? TranYear { get; set; }
        public decimal? ReceiptTranNumber { get; set; }
        public string RcptExt { get; set; }
        public decimal? ReceiptTran { get; set; }
        public string RcptExt1 { get; set; }
        public DateTime? AffidavitDate { get; set; }
        public decimal? TaxAmount { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string LegalDocumentType { get; set; }
        public decimal? TotalPaid { get; set; }
        public decimal? StateTaxPaid { get; set; }
        public string ExemptRegNumber { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string PreviousOwnerSeller { get; set; }
        public string NewOwnerBuyer { get; set; }
        public decimal? ParcelNumber { get; set; }
        public decimal? AssessedValue { get; set; }
        public string TaxStatus { get; set; }
        public string PropertyType { get; set; }
        public string MobileHomeNotation { get; set; }
        public decimal? PrimaryUseCode { get; set; }
        public string PPtype { get; set; }
        public decimal? PPvalue { get; set; }
        public decimal? GiftDebt { get; set; }
        public decimal? LocalTaxPaid { get; set; }
        public decimal? StatePenalty { get; set; }
        public decimal? LocalPenalty { get; set; }
        public decimal? StateInterest { get; set; }
        public decimal? LocalInterest { get; set; }
        public string ExciseAreaCode { get; set; }
        public decimal? TaxCodeArea { get; set; }
        public decimal? TechnicalFee { get; set; }
        public string TechFeeRecipient { get; set; }
        public decimal? SubsidizedFee { get; set; }
        public string SubsidizedRecipient { get; set; }
    }
}
