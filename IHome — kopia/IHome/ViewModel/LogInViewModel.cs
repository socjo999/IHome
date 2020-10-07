using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IHome.ViewModel
{
    public class LogInViewModel : IdentityUser<int>
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
