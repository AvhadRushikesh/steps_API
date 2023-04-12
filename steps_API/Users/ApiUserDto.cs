using System.ComponentModel.DataAnnotations;

namespace steps_API.Users
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }        
    }
}