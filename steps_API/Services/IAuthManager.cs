using Microsoft.AspNetCore.Identity;
using steps_API.Users;

namespace steps_API.Services
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

        Task<bool> Login(LoginDto loginDto);
    }
}