using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountVM
{
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        [Required]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
    }
}