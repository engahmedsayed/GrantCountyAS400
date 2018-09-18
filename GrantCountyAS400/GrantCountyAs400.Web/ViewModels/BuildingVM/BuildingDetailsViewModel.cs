using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingDetailsViewModel
    {
        [Display(Name ="Jurisdiction")]
        public string JurisdictionCode { get;   set; }
        [Display(Name ="Department")]
        public string DepartmentCode { get;   set; }
        [Display(Name = "Application Yr/#")]
        public decimal? ApplicationYear { get;   set; }
        [Display(Name ="Addendum")]
        public decimal? AddendumNumber { get;   set; }
        public string PermitStatus { get;   set; }
        [Display(Name ="Application Name")]
        public string ApplicationName { get;   set; }
        [Display(Name ="Gen. Contractor")]
        public string ContractLicenseNumber { get;   set; }
        [Display(Name ="Application Project Description")]
        public string ApplicantProjectDescription { get;   set; }
        [Display(Name ="Additional Project Information")]
        public string AdditionalInformation { get;   set; }
        [Display(Name ="Result Of Enforcement Action?")]
        public string ResultOfEnforcementAction { get;   set; }
        public string EnforcementDescription { get;   set; }

        [Display(Name ="Plot Plan received")]
        public string PlotPlanReceived { get;   set; }

        [Display(Name ="Only Structure On Parcel?")]
        public string OnlyStructureOnParcel { get;   set; }
        [Display(Name ="Only Residence On Parcel?")]
        public string OnlyResidenceOnParcel { get;   set; }
    }
}
