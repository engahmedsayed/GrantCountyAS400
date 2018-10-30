using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class ManModFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        public string FeeDescription { get; set; }

        public decimal? NumberOfUnits { get; set; }

        public decimal? BaseFee { get; set; }

        public decimal? FeeIncrement { get; set; }

        public decimal? ExtendedAmount { get; set; }

        public string MinMaxFlag { get; set; }
        public decimal? SequenceNumber { get; set; }

        [Display(Name ="Total")]
        public decimal? TotalValue { get; set; }

        [Display(Name ="Total Building Fees")]
        public decimal? TotalBuildingFees { get; set; }

        public decimal? InspectPlanReview { get; set; }
    }
}
