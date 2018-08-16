using GrantCountyAs400.Web.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel
{
    public class ChildParentParcelDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Record Code")]
        public string RecordCode { get; set; }

        [Display(Name = "Parent Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParentParcel { get; set; }

        [Display(Name = "Child Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ChildParcel { get; set; }

        [Display(Name = "Seg Comb Date")]
        [DataType(DataType.Date)]
        public DateTime? SegCombDate { get; set; }

        [Display(Name = "Effective Date")]
        [DataType(DataType.Date)]
        public DateTime? EffectiveDate { get; set; }

        [Display(Name = "Reference Number")]
        public string ReferenceNumber { get; set; }

        [Display(Name = "Legal Document Type")]
        public string LegalDocumentType { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayerName { get; set; }

        [Display(Name = "Title Owner")]
        public string TitleOwnerName { get; set; }

        [Display(Name = "Status")]
        public string TaxStatus { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }

        public string TaxStatusDisplay => TaxStatusFactory.TaxStatusCodeToDescription(TaxStatus);
    }
}