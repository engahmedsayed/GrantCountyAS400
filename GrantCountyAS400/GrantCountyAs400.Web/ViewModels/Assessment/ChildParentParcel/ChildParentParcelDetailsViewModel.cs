using GrantCountyAs400.Web.Utils;
using System;
using System.Collections.Generic;
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

        [Display(Name = "Parcel Number")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ChildParcel { get; set; }

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

        public IEnumerable<ChildParcelViewModel> Children { get; set; }

        public string TaxStatusDisplay => TaxStatusFactory.TaxStatusCodeToDescription(TaxStatus);

        public List<string> Descriptions
        {
            get
            {
                List<string> result = new List<string>();
                if (!string.IsNullOrEmpty(Description1)) result.Add(Description1);
                if (!string.IsNullOrEmpty(Description2)) result.Add(Description2);
                if (!string.IsNullOrEmpty(Description3)) result.Add(Description3);
                if (!string.IsNullOrEmpty(Description4)) result.Add(Description4);
                if (!string.IsNullOrEmpty(Description5)) result.Add(Description5);
                return result;
            }
        }
    }
}