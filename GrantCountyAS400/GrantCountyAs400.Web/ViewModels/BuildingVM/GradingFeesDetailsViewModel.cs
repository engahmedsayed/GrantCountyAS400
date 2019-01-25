using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class GradingFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        public decimal? GradExtendedAmount { get; set; }

        public decimal? PlrvwExtendedAmount { get; set; }
        
        public decimal? TotalCubicYardsOfFill { get; set; }

        [Display(Name ="Total Grading Fees")]
        public decimal? TotalExtendedAmount { get; set; }


        [Display(Name = "Fee Code")]
        public List<decimal?> SequenceNumber { get; set; }

        [Display(Name = "Fee Description")]
        public List<string> FeeDescription { get; set; }

        public List<decimal?> CubicYardsOfFill { get; set; }

        public List<decimal?> BaseFee { get; set; }

        public List<decimal?> FeeIncrement { get; set; }

        public List<decimal?> ExtendedAmount { get; set; }

        public List<string> MinMaxFlag { get; set; }

        public int CoutOfLargestList
        {
            get
            {
                List<int> totalNumbers = new List<int>() { SequenceNumber.Count, FeeDescription.Count, CubicYardsOfFill.Count, BaseFee.Count, FeeIncrement.Count,
                                                           ExtendedAmount.Count, MinMaxFlag.Count };
                return totalNumbers.OrderByDescending(t => t).FirstOrDefault();
            }
        }



    }
}
