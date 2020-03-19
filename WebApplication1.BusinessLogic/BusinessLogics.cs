using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.BusinessLogic.Core;

namespace WebApplication1.BusinessLogic
{
     public class BusinessLogics
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }
     }
}
