using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.GeneralLedgerVM
{
    public class GeneralLedgerFilterVM
    {
        [Display(Name = "Fiscal Year")]
        public int FiscalYear { get; set; }

        [Display(Name = "Fund")]
        public string Fund { get; set; }

        public string Department { get; set; }

        public string Program { get; set; }
    }
}
