using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson
{
    public class AssociatedPersonMainViewModel
    {
        [Display(Name ="Parcel Number")]
        [DisplayFormat(DataFormatString = "{0:00 0000 000}")]
        public decimal? ParcelNumber { get; set; }

        [Display(Name ="Name Code")]
        public string NameCode { get; set; }

        [Display(Name ="Comment")]
        public string Comment { get; set; }
    }
}
