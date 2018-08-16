using GrantCountyAs400.Web.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.LegalDescription
{
    public class LegalDescriptionDetailsViewModel
    {
        private int Id { get; set; }

        [Display(Name = "Parcel")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Full Legal Description")]
        public string LegalDescrtiption { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }

        [Display(Name = "Status")]
        public string TaxStatus { get; set; }

        [Display(Name = "Change Id")]
        public string ChangeId { get; set; }

        [Display(Name = "Change Date")]
        [DataType(DataType.Date)]
        public DateTime ChangeDate { get; set; }

        public string TaxStatusDisplay => TaxStatusFactory.TaxStatusCodeToDescription(TaxStatus);
    }
}