using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.ChildParentParcel
{
    public class ChildParentParcelFilterViewModel
    {
        [Display(Name = "Parcel Number")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Effective Date")]
        [UIHint("DatePicker")]
        public DateTime? EffectiveDate { get; set; }

        [Display(Name = "Legal Document Type")]
        public string LegalDocumentType { get; set; }
    }
}