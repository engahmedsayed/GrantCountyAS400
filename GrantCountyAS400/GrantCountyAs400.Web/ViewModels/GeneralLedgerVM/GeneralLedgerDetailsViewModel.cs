using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.GeneralLedgerVM
{
    public class GeneralLedgerDetailsViewModel
    {
        public string FirstCurrentExpense { get; set; }

        public string SecondCurrentExpense { get; set; }

        public decimal? Month { get; set; }

        public decimal? Year { get; set; }

        public decimal? Budget { get; set; }

        [Display(Name ="Pend. Encumb.")]
        [DefaultValue(0)]
        public decimal? PendingEncumbrance { get; set; } 

        public decimal? Encumbrance { get; set; }

        public decimal? Action { get; set; }

        public string Fund { get; set; }

        public string Department { get; set; }

        public string Program { get; set; }

        public string Project { get; set; }
    }
}
