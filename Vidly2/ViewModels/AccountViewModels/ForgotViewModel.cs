using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
    }
}