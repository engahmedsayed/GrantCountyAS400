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


        public decimal? NumberOfUnitsTotal
        {
            get
            {
                return NumberOfUnits?.Sum(t => t);
            }
        }

        [Display(Name = "Fee Code")]
        public List<decimal?> SequenceNumber { get; set; }

        [Display(Name = "Fee Description")]
        public List<string> FeeDescription { get; set; }

        public List<decimal?> NumberOfUnits { get; set; }

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

        public int CoutOfLargestList
        {
            get
            {
                List<int> totalNumbers = new List<int>() { SequenceNumber.Count, FeeDescription.Count, NumberOfUnits.Count, BaseFee.Count,UnitCharge.Count, ExtendedAmount.Count };
                return totalNumbers.OrderByDescending(t => t).FirstOrDefault();
            }
        }

        public decimal? BidPlanExtendedAmount { get; set; }

        public decimal? PlrvwExtendedAmount { get; set; }
    }
}
