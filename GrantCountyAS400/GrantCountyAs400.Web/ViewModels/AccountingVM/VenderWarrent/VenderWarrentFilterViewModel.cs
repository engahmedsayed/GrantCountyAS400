using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM.VenderWarrent
{
    public class VenderWarrentFilterViewModel
    {
        [Display(Name = "Vendor Id")]
        public string VendorId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Representative")]
        public string Representative { get; set; }
        [Display(Name = "Pay Date From")]
        [UIHint("DatePicker")]
        public DateTime? MinPayDate { get; set; } = null;
        [Display(Name = "Pay Date To")]
        [UIHint("DatePicker")]
        public DateTime? MaxPayDate { get; set; } = null;
    }
}