using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits
{
    public class BuildingPermitsFilterViewModel
    {
        [Display(Name = "Parcel Number")]
        public decimal ParcelNumber { get; set; }
    }
}
