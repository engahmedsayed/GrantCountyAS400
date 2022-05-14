using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.AccountVM
{
    public class ChangePasswordViewModel
    {
        [Display(Name = "Current Password")]
        [Required]
        public string OldPassword { get; set; }

        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
    }
}