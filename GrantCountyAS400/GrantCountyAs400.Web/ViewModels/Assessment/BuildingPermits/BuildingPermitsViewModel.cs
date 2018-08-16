using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits
{
    public class BuildingPermitsViewModel
    {
        public decimal? ParcelNumber { get; set; }

        public string TaxPayer { get; set; }

        public string Owner { get; set; }

        public string FirstDescription { get; set; }

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
        public decimal? PermitNumber { get; set; }

        public decimal? PermitAddenDum { get; set; }

        public DateTime? PermitIssueDate { get; set; }

        public string JurisdictionCode { get; set; }

        public decimal? PercentComplete { get; set; }

        public decimal? EstimatedValue { get; set; }

        public string NewOrDemo { get; set; }

        public string Comment { get; set; }

    }
}
