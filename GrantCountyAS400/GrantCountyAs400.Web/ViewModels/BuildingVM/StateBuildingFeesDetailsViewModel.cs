using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class StateBuildingFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        public decimal? StateBuildingExtendedAmount { get; set; }

        public decimal? TotalValue { get; set; }

        [Display(Name ="Number Of units")]
        public List<decimal?> NumberOfUnits { get; set; }

        [Display(Name ="Extended Amount")]
        public List<decimal?> ExtendedAmount { get; set; }

        public int CoutOfLargestList
        {
            get
            {
                List<int> totalNumbers = new List<int>() { NumberOfUnits.Count, ExtendedAmount.Count};
                return totalNumbers.OrderByDescending(t => t).FirstOrDefault();
            }
        }
    }
}
