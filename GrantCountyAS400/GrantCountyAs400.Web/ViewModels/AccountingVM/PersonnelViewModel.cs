using GrantCountyAs400.Web.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class PersonnelViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public decimal SSNumber { get; set; }

        [Display(Name = "Employee #")]
        [DisplayFormat(DataFormatString = "{0:00000}")]
        public decimal PersonNumber { get; set; }

        [Display(Name = "P")]
        public string HasContracts { get { return Contracts != null && Contracts.Any() ? "P" : string.Empty; } }

        [Display(Name = "SSN")]
        public string SSNumberDisplay => this.SSNumber.MaskSSN();

        public IEnumerable<ContractViewModel> Contracts { get; set; }
    }
}