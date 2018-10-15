using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels.AccountVM
{
    public class ChangePasswordViewModel
    {
        [Display(Name ="Current Password")]
        [Required]
        public string OldPassword { get; set; }

        [Display(Name ="New Password")]
        public string NewPassword { get; set; }
    }
}
