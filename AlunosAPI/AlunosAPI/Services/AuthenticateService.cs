using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly SignInManager<IdentityUser> _singInManager;
        public AuthenticateService(SignInManager<IdentityUser> singInManager) 
        {
            _singInManager = singInManager;
        }
        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _singInManager.PasswordSignInAsync(email, password, 
                false, lockoutOnFailure:false);

            return result.Succeeded;
        }

        public async Task Logout()
        {
            await _singInManager.SignOutAsync();
        }
    }
}
