using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.Assessment.BuildingPermits
{
    public class HistoricValuesViewModel
    {
        [Display(Name ="Tax Year")]
        public int? TaxYear { get; set; }

        public decimal? UndividedInterestPercent { get; set; }

        public int? TaxCodeArea { get; set; }

        public string SubsidiaryParcelCode { get; set; }

        public decimal? UnimprovedLandAcres { get; set; }

        public decimal? ImprovedLandAcres { get; set; }

        [Display(Name ="Total Acres")]
        public decimal? LandAcresDisplay
        {
            get
            {
                return UnimprovedLandAcres + ImprovedLandAcres;
            }
        }

        public decimal? FirePatrolAcres { get; set; }

        [Display(Name = "Building Value")]
        public int? BuildingValue { get; set; }

        public decimal? ImprovedLandValue { get; set; }

        public decimal? UnimprovedLandValue { get; set; }

        [Display(Name = "Land Value")]
        public decimal? LandValueDisplay
        {
            get
            {
                return ImprovedLandValue + UnimprovedLandValue;
            }
        }

        [Display(Name ="Total Value")]
        public decimal? BuildingValueDisplay
        {
            get
            {
                return BuildingValue + LandValueDisplay;
            }
        }

        public decimal? MobileHomeValue { get; set; }

        public string ChangeReasonCode { get; set; }

        public int? LandUseCode { get; set; }

        //
        public int? ParcelNumber { get; set; }


        public string RevaluationPhase { get; set; }

        public string TaxPayerCode { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }

        public string Description3 { get; set; }

        public string Description4 { get; set; }

        [Display(Name = "Description")]
        public string DescriptionDisplay
        {
            get
            {
                return Description1 + " " + Description2 + " " + Description3 + " " + Description4;
            }
        }

        [Display(Name = "Tax Status")]
        public string TaxStatus { get; set; }

        
  
        //
        //
    }
}
