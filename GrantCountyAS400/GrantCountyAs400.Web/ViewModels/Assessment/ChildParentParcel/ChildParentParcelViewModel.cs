using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel
{
    public class ParentParcelViewModel
    {
        [Display(Name = "Parent Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayerName { get; set; }

        [Display(Name = "Title Owner")]
        public string TitleOwnerName { get; set; }

        public IEnumerable<ChildParcelViewModel> Children { get; set; }
    }

    public class ChildParcelViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Parent Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParentParcelNumber { get; set; }

        [Display(Name = "Child Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Seg Comb Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? SegCombDate { get; set; }

        [Display(Name = "Effective Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? EffectiveDate { get; set; }

        [Display(Name = "Reference Number")]
        public string ReferenceNumber { get; set; }

        [Display(Name = "Legal Document Type")]
        public string LegalDocumentType { get; set; }
    }
}