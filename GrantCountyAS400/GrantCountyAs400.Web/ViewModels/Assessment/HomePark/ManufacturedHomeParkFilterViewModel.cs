using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.HomePark
{
    public class ManufacturedHomeParkFilterViewModel
    {
        [Display(Name = "Code")]
        public string MhparkCode { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
    }
}