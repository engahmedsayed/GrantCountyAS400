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
        public List<decimal?> SequenceNumber { get; set; }

        [Display(Name ="Fee description")]
        public List<string> FeeDescription { get; set; }

        [Display(Name ="Units/Hrs")]
        public List<decimal?> NumberOfUnits { get; set; }

        [Display(Name ="Unit Fee")]
        public List<decimal?> UnitCharge { get; set; }

        public List<string> FeeCode { get; set; }

        public int CoutOfLargestList
        {
            get
            {
                List<int> totalNumbers = new List<int>() { SequenceNumber.Count, FeeDescription.Count, NumberOfUnits.Count, UnitCharge.Count, FeeCode.Count };
                return totalNumbers.OrderByDescending(t => t).FirstOrDefault();
            }
        }

    }
}
