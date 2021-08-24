using System.Threading.Tasks;
using Core.Plugins.Authentication.Models;

namespace Business.Abstract
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Login Operation
        /// </summary>
        /// <param name="loginModel"></param>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        Task<TokenInfo> LoginAsync(LoginRequestModel loginModel,string ipAddress);

        /// <summary>
        /// Logout
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task LogoutAsync(int accountId);
        
        /// <summary>
        /// Login by Refresh Token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        Task<TokenInfo> RefreshAsync(string refreshToken,string ipAddress);
        
        /// <summary>
        /// Register Operation
        /// </summary>
        /// <param name="registerModel"></param>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        Task<TokenInfo> RegisterAsync(RegisterRequestModel registerModel,string ipAddress);

        /// <summary>
        ///  Get User Info
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        Task<UserInfo> UserInfo(int accountId);
    }
}