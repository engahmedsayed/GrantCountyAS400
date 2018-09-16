using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingMainModuleFilterViewModel
    {
        [Display(Name ="Jurs")]
        public string JurisdictionCode { get; set; }

        [Display(Name ="Dept")]
        public string DepartmentCode { get; set; }

        [Display(Name = "Year")]
        public int? ApplicationYear { get; set; }

        [Display(Name = "Numb")]
        public decimal? ApplicationNumber { get; set; }
    }
}
