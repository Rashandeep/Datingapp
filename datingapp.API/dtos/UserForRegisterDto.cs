using System.ComponentModel.DataAnnotations;

namespace datingapp.API.dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="pass between 4 and 8")]
        public string Password { get; set; }
    }
}