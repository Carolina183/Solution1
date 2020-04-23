using System.Web;
using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Interfaces
{
     public interface ISession
     {
          UActionResp UserRegister (URegisterData data);
          UActionResp UserLogin (ULoginData data);
          UActionResp UserLogout (string cookie);
          HttpCookie GenCookie (string username);
          UserEntity GetUserByCookie (string apiCookieValue);
     }
}