using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BidPlanFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        [Display(Name = "Fee Code")]
        public List<decimal?> SequenceNumber { get; set; }

        [Display(Name = "Fee Description")]
        public List<string> FeeDescription { get; set; }

        public List<decimal?> NumberOfUnits { get; set; }

        public decimal? NumberOfUnitsTotal
        {
            get
            {
                return NumberOfUnits?.Sum(t => t);
            }
        }

        public List<decimal?> BaseFee { get; set; }

        public List<decimal?> UnitCharge { get; set; }

        public List<decimal?> ExtendedAmount { get; set; }

        public decimal? ExtendedAmountTotal
        {
            get
            {
                return ExtendedAmount?.Sum(t => t);
            }
        }

        public decimal? BidPlanExtendedAmount { get; set; }

        public decimal? PlrvwExtendedAmount { get; set; }
    }
}
