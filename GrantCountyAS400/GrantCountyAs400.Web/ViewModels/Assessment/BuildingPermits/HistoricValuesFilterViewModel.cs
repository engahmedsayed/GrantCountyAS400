using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits
{
    public class HistoricValuesFilterViewModel
    {
        [Display(Name = "Parcel Number")]
        [Required]
        public decimal ParcelNumber { get; set; }

        [Display(Name ="Tax Payer Code")]
        public string TaxPayerCode { get; set; }
    }
}
