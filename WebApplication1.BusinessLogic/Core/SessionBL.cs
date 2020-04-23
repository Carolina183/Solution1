using System.Web;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Core
{
     public class SessionBL : UserApi, ISession
     {
          public UserEntity GetUserByCookie(string apiCookieValue)
          {
               return UserCookie(apiCookieValue);
          }

          public HttpCookie GenCookie(string username)
          {
               return Cookie(username);
          }

          public UActionResp UserLogin(ULoginData data)
          {
               return UserLoginAction(data);
          }

          public UActionResp UserRegister(URegisterData data)
          {
               return UserRegisterAction(data);
          }

          public UActionResp UserLogout(string cookie)
          {
               return UserLogoutAction(cookie);
          }
     }
}
