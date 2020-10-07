using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IHome.ViewModel
{
    public class RoleViewModel : IdentityUser<int>
    {
        [Required]
        public string Role { get; set; }
    }
}
