using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class PersonnelDetailsFilterViewModel
    {
        [Display(Name = "From")]
        [UIHint("YearDatePicker")]
        public int? FromYear { get; set; } = null;

        [Display(Name = "To")]
        [UIHint("YearDatePicker")]
        public int? ToYear { get; set; } = null;

        [Display(Name = "Deduction Code")]
        public string DeductionCode { get; set; }

        public bool IsEmpty
        {
            get { return !this.FromYear.HasValue && !this.ToYear.HasValue && string.IsNullOrWhiteSpace(this.DeductionCode); }
        }
    }
}