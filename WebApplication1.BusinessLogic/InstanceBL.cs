using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.BusinessLogic.Core;
using WebApplication1.BusinessLogic.Interfaces;

namespace WebApplication1.BusinessLogic
{
     public class InstanceBL
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }

          public IBlog GetBlogBL()
          {
               return new BlogBL();
          }
     }
}
