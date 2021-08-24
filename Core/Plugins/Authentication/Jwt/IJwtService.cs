using Core.Plugins.Authentication.Models;

namespace Core.Plugins.Authentication.Jwt
{
    public interface IJwtService
    {
        TokenInfo CreateToken(JwtCreateModel model);
    }
}