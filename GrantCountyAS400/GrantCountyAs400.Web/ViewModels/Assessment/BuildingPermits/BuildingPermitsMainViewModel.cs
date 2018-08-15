using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits
{
    public class BuildingPermitsMainViewModel
    {
        [Display(Name = "Parcel Number")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal? ParcelNumber { get; set; }
        [Display(Name = "Owner")]
        public string TitleOwnerCode { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }
    }
}
