using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate(string email, string password);
        Task Logout();
    }
}
