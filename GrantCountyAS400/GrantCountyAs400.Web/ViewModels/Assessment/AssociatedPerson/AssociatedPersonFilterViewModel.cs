using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson
{
    public class AssociatedPersonFilterViewModel
    {
        [Display(Name = "Parcel Number")]
        public decimal ParcelNumber { get; set; }

        [Display(Name = "Name Code")]
        public string NameCode { get; set; }
    }
}
