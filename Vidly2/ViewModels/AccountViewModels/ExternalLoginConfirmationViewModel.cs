using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Phone]
        [StringLength(30)]
        public string Phone { get; set; }   
    }
}