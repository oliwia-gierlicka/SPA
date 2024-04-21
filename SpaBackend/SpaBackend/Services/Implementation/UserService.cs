using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class UserService : IUserService
{
    private readonly SpaDbContext _dbContext;
    private readonly ITokenProvider _tokenProvider;

    public UserService(SpaDbContext dbContext, ITokenProvider tokenProvider)
    {
        _dbContext = dbContext;
        _tokenProvider = tokenProvider;
    }

    public async Task<string?> Login(LoginForm form)
    {
        var hash = Convert.ToHexString(SHA256.HashData(Encoding.Default.GetBytes(form.Password)));
        var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Login == form.Login);
        return user is not null && hash==user.Password ? _tokenProvider.Generate(user) : null;
    }

    public async Task CreateUser(UserForm form)
    {
        _dbContext.Users.Add(new User
        {
            Role = "customer",
            Name = form.Firstname,
            Surname = form.Lastname,
            Email = form.Email,
            Login = form.Login,
            Password = Convert.ToHexString(SHA256.HashData(Encoding.Default.GetBytes(form.Password)))
        });
        await _dbContext.SaveChangesAsync();
    }

    public async Task<bool> IsEmployee(string login)
    {
        return (await _dbContext.Users.FirstOrDefaultAsync(x => x.Login == login))?.Role == "employee";
    }

    public IEnumerable<UserInfo> GetEmployees()
    {
        return _dbContext.Users.Where(x => x.Role == "employee").Select(x => new UserInfo
        {
            Id = x.Id,
            Name = x.Name,
            Surname = x.Surname
        });
    }
}