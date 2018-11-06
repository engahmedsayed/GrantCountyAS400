using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class TotalFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        [Display(Name ="Total Value Or Bid")]
        public decimal? TotalValue { get; set; }

        [Display(Name ="Total Fees Due")]
        public decimal? TotalFeesDue { get; set; }

        [Display(Name ="Total Paid")]
        public decimal? TotalPaid { get; set; }

        [Display(Name ="Balance Due")]
        public decimal? BalanceDue { get; set; }

        [Display(Name ="State Classification")]
        public decimal? StateClassification { get; set; }

        public string IsRequirementsReceived { get; set; }

        public string ViewIssuePermit { get; set; }

        [Display(Name ="Projected Expire Date")]
        public DateTime? ProjectedExpireDate { get; set; }

        public DateTime? ActualExpireDate { get; set; }

        [Display(Name ="User")]
        public string ByUser { get; set; }
    }
}
