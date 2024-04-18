using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class UserProvider : IUserProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserProvider(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public int GetUserId()
    {
        return int.Parse(_httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "-1");
    }
}