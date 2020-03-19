using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Core
{
     public class UserApi
     {
          internal ULoginResp UserLoginAction(ULoginData data)
          {
               var _username = "test@test";
               var _password = "test";

               if (data.Username != _username || data.Password != _password)
               {
                    return new ULoginResp
                    {
                         Status = false,
                         StatusMsg = "The Username or Password is Incorrect"
                    };
               }
               return new ULoginResp { Status = true };
          }
     }
}
