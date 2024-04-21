using SpaBackend.Models;

namespace SpaBackend.Services.Abstract;

public interface IUserService
{
    Task<string?> Login(LoginForm form);
    Task CreateUser(UserForm form);
    Task<bool> IsEmployee(string login);
    IEnumerable<UserInfo> GetEmployees();
}