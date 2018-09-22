using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingPermitSystemDetailsHeaderViewModel
    {
        [Display(Name = "Jurisdiction")]
        public string JurisdictionCode { get; set; }
        public string JurisidictionShortDepartmentName { get; set; }

        [Display(Name = "Application Yr/#")]
        public decimal ApplicationYear { get; set; }
        public decimal ApplicationNumber { get; set; }

        [Display(Name = "Department")]
        public string DepartmentCode { get; set; }
        public string DepartmentShortDepartmentName { get; set; }
        [Display(Name = "Addendum #")]
        public int AddendumNumber { get; set; }
        
        public string PermitStatus { get; set; }

        [Display(Name = "Application(Year-Number)")]
        // computed properties
        public string ApplicationYearDisplay => $"{ApplicationYear} - {ApplicationNumber}";

        
        [Display(Name = "Jurisdiction")]
        public string JurisdictionDisplay => $"{JurisdictionCode} - {JurisidictionShortDepartmentName}";

        [Display(Name = "Department")]
        public string DepartmentDisplay => $"{DepartmentCode} - {DepartmentShortDepartmentName}";

        [Display(Name = "Permit Status")]
        public string PermitStatusDisplay
        {
            get
            {
                switch (PermitStatus)
                {
                    case "A": return "Applica";
                    case "D": return "VoidApp";
                    case "E": return "ExpApp";
                    case "W": return "Working";
                    case "V": return "VoidPer";
                    case "U": return "ExpPer";
                    case "F": return "Final";
                    case "C": return "Closed";
                    default: return "";
                }
            }
        }
    }
}
