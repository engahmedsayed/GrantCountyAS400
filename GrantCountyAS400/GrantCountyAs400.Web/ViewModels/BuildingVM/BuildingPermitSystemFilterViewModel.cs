using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemFilterViewModel
    {
        [Display(Name = "Application Year")]
        public int? ApplicationYear { get; set; }

        [Display(Name = "Application Number")]
        public decimal? ApplicationNumber { get; set; }

        [Display(Name = "Permit Number")]
        public decimal? PermitNumber { get; set; }

        [Display(Name = "Applicant Business Name")]
        public string ApplicantBusinessName { get; set; }

        [Display(Name = "Applicant Last Name")]
        public string ApplicantLastName { get; set; }

        [Display(Name = "Applicant First Name")]
        public string ApplicantFirstName { get; set; }

        [Display(Name = "Permit Year")]
        public int? PermitYear { get; set; }

        [Display(Name = "Preliminary Parcel Number")]
        public decimal? PreliminaryParcelNumber { get; set; }

        [Display(Name = "Assessor Parcel Number")]
        public decimal? AssessorParcelNumber { get; set; }

        [Display(Name = "State Class Code")]
        public decimal? StateClassCode { get; set; }

        [Display(Name = "Project Description")]
        public string ProjectDescription { get; set; }

        [Display(Name = "Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name = "General Contractor")]
        public string ContractorBusinessName { get; set; }

        [Display(Name = "Enforcement Action (Y/N)")]
        public List<SelectListItem> EnforcementActionRequired
        {
            get
            {
                return new List<SelectListItem> { new SelectListItem { Text = "", Value = "" },
                       new SelectListItem { Text = "Y", Value = "Y" },
                       new SelectListItem { Text = "N", Value = "N" } };
            }
        }

        public string EnforcementAction { get; set; }

        [Display(Name = "City Jurisdiction/Utility Approved (Y/N)")]
        public List<SelectListItem> CityApprovalRequired
        {
            get
            {
                return new List<SelectListItem> { new SelectListItem { Text = "", Value = "" },
                       new SelectListItem { Text = "Y", Value = "Y" },
                       new SelectListItem { Text = "N", Value = "N" } };
            }
        }

        public string CityApproval { get; set; }

        [Display(Name = "Issue Date From")]
        [UIHint("DatePicker")]
        public DateTime? FromDate { get; set; } = null;
        [Display(Name = "Issue Date To")]
        [UIHint("DatePicker")]
        public DateTime? ToDate { get; set; } = null;

        [Display(Name = "Application Date From")]
        [UIHint("DatePicker")]
        public DateTime? ApplicationDateFrom { get; set; } = null;

        [Display(Name = "Application Date To")]
        [UIHint("DatePicker")]
        public DateTime? ApplicationDateTo { get; set; } = null;
    }
}