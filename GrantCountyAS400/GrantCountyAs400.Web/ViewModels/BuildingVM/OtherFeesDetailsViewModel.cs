using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class OtherFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        [Display(Name = "Total Other Fees")]
        public decimal? OtherExtendedAmount { get; set; }

        public decimal? ExtendedAmount { get; set; }

        [Display(Name ="Seq #")]
        public decimal? SequenceNumber { get; set; }

        [Display(Name ="Fee description")]
        public string FeeDescription { get; set; }

        [Display(Name ="Units/Hrs")]
        public decimal? NumberOfUnits { get; set; }

        [Display(Name ="Unit Fee")]
        public decimal? UnitCharge { get; set; }

        [Display(Name ="Extended Amount")]
        public decimal? TotalExtendedAmount
        {
            get
            {
                return NumberOfUnits.GetValueOrDefault() * UnitCharge.GetValueOrDefault();
            }
        }
    }
}
