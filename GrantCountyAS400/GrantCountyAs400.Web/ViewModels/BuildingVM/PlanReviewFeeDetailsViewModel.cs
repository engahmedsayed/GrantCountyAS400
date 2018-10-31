using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class PlanReviewFeeDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }


        [Display(Name ="Extended Amount")]
        public decimal? ExtendedAmount { get; set; }

        [Display(Name ="Plan Review %")]
        public decimal? PlanReviewFee { get; set; }

        [Display(Name ="Building Permit")]
        public decimal? BuildingPermit { get; set; }

        [Display(Name ="Total Value")]
        public decimal? TotalValue { get; set; }

        [Display(Name ="Total Plan Review Fees")]
        public decimal? TotalPlanReviewFees { get; set; }




    }
}
