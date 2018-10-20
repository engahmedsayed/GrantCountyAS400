using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemAssessorApprovalViewModel
    {
        [Display(Name = "App Prj Dsc")]
        public string ApplicantProjectDescription { get; set; }

        [Display(Name = "Project Notes")]
        public string Comments { get; set; }

        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }

        [Display(Name = "Chg User")]
        public string UserID { get; set; }

        [Display(Name = "Chg Date")]
        [DataType(DataType.Date)]
        public DateTime? ChangeDate { get; set; }

        [Display(Name ="Assrs Parcel #")]
        public decimal? AssessorParcelNumber { get; set; }

        public string Name { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }
    }
}
