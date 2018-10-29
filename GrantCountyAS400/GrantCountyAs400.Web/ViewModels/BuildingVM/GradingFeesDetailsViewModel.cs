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

        
        public decimal? CubicYardsOfFill { get; set; }

        [Display(Name = "Fee Code")]
        public decimal? SequenceNumber { get; set; }

        [Display(Name ="Fee Description")]
        public string FeeDescription { get; set; }

        public decimal? GradExtendedAmount { get; set; }

        public decimal? PlrvwExtendedAmount { get; set; }

        public decimal? BaseFee { get; set; }

        public decimal? FeeIncrement { get; set; }

        public string ExtendedAmount { get; set; }

        public string MinMaxFlag { get; set; }



    }
}
