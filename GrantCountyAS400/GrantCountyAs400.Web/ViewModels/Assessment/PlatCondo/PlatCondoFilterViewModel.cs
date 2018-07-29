using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.Assessment.PlatCondo
{
    public class PlatCondoFilterViewModel
    {
        [Display(Name = "Plat Code Type")]
        public string CodeType { get; set; }

        [Display(Name = "Plat Code")]
        public string Code { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}