using Microsoft.AspNetCore.Identity;

namespace steps_API.Model
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
