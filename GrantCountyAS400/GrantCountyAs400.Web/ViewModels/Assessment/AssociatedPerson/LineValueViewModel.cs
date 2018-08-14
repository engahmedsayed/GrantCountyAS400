using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.AssociatedPerson
{
    public class LineValueViewModel
    {
        [Display(Name ="Name #")]
        public string AsmtrealPropertyAssociatedPersonsNameCode { get; set; }

        [Display(Name = "Name")]
        public string AsmtmasterNameAddressNameCode { get; set; }

        [Display(Name ="Comment")]
        public string Comment { get; set; }
    }
}
