using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits
{
    public class BuildingPermitsViewModel
    {
        [Display(Name ="Parcel Number")]
        public decimal? ParcelNumber { get; set; }

        [Display(Name = "Tax Payer")]
        public string TaxPayer { get; set; }

        public string Owner { get; set; }

        [Display(Name ="Description")]
        public string FirstDescription { get; set; }

        [Display(Name = "Land Use")]
        public string LandUse { get; set; }

        public string SecondDescription { get; set; }

        public decimal? TotalAcre { get; set; }

        public string ThirdDescription { get; set; }

        public decimal? LandAv { get; set; }

        public string FourthDescription { get; set; }

        public decimal? BuildingValue { get; set; }


        public List<BuildingPermitsLineValueViewModel> LineValues { get; set; }
    }

    public class BuildingPermitsLineValueViewModel
    {
        [Display(Name ="Permit Number")]
        public decimal? PermitNumber { get; set; }

        [Display(Name = "Seq")]
        public decimal? PermitAddenDum { get; set; }

        [Display(Name = "Issue Date")]
        public DateTime? PermitIssueDate { get; set; }

        [Display(Name = "Jurisdiction")]
        public string JurisdictionCode { get; set; }

        [Display(Name = "% Complete")]
        public decimal? PercentComplete { get; set; }

        [Display(Name = "Estimated Value")]
        public decimal? EstimatedValue { get; set; }

        [Display(Name = "N/D")]
        public string NewOrDemo { get; set; }

        public string Comment { get; set; }

    }
}
