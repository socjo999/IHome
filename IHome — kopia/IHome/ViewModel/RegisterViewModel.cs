using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IHome.ViewModel
{
    public class RegisterViewModel : IdentityUser<int>
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public override string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
