using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class DemolitionFeesDetailsViewModel
    {

        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        [Display(Name = "Fee Code")]
        public List<decimal?> SequenceNumber { get; set; }

        [Display(Name = "Fee Description")]
        public List<string> FeeDescription { get; set; }

        public List<decimal?> NumberOfUnits { get; set; }

        public List<decimal?> UnitCharge { get; set; }

        public List<decimal?> ExtendedAmount { get; set; }

        public decimal? DemolitionExtendedAmount { get; set; }

        public decimal? PlrvwExtendedAmount { get; set; }
    }
}
