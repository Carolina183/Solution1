using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Core
{
     public class SessionBL : UserApi, ISession
     {
          public ULoginResp UserLogin(ULoginData data)
          {
               return UserLoginAction(data);
          }
     }
}
