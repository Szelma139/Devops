using System.ComponentModel.DataAnnotations;

namespace MyAPI.DTO.Account
{
    public class RegisterDto
    {
        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Too much")]
        public string FirstName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
