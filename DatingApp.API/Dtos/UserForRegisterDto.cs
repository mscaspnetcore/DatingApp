using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }


        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "A senha precisa ter entre 4 e 8 caractéres")]
        public string Password { get; set; }
    }
}