using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;
using SpaBackend.Db.Entity;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class TokenProvider : ITokenProvider
{
    private readonly IConfiguration _configuration;

    public TokenProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public string Generate(User user)
    {
        var keyBytes = Encoding.Default.GetBytes(_configuration["AuthSecret"]).ToArray();
        var symmetricKey = new SymmetricSecurityKey(keyBytes);

        var signingCredentials = new SigningCredentials(
            symmetricKey,
            SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>()
        {
            new Claim("sub", user.Login),
            new Claim("name", user.Id.ToString()),
            new Claim("role", user.Role),
            new Claim("aud", "localhost")
        };
    
        var token = new JwtSecurityToken(
            issuer: "localhost",
            audience: "localhost",
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: signingCredentials);

        var rawToken = new JwtSecurityTokenHandler().WriteToken(token);
        return rawToken;
    }
}