using SpaBackend.Db.Entity;

namespace SpaBackend.Services.Abstract;

public interface ITokenProvider
{
    string Generate(User user);
}