using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Web.Controllers.Attributes;

namespace WebApplication1.Web.Controllers
{
	[AdminMod]
     public class AdminController : BaseController
     {
          private readonly IBlog _blog;

          public AdminController()
          {
               var bl = new InstanceBL();
               _blog = bl.GetBlogBL();
          }

          public ActionResult Index()
          {
               SessionStatus();
               return View();
          }
     }
}