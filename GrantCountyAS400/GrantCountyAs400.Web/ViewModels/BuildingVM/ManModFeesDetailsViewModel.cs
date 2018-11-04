﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class ManModFeesDetailsViewModel
    {
        public BuildingPermitSystemBasicInfoViewModel BasicInfo { get; set; }

        [Display(Name = "Total Building Fees")]
        public decimal? TotalBuildingFees { get; set; }

        [Display(Name ="Inspect/Pln-Rvw")]
        public decimal? InspectPlanReview { get; set; }

        [Display(Name = "Total")]
        public decimal? TotalValue { get; set; }

        public List<decimal?> ExtendedAmount { get; set; }


        public List<decimal?> SequenceNumber { get; set; }

        public List<string> FeeDescription { get; set; }

        public List<decimal?> NumberOfUnits { get; set; }

        public List<decimal?> BaseFee { get; set; }

        public List<decimal?> FeeIncrement { get; set; }

        public List<string> MinMaxFlag { get; set; }

    }
}
