using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Web.Models;
using WebApplication1.BusinessLogic.Interfaces;

namespace WebApplication1.Web.Controllers
{
     public class AuthentificationController : Controller
     {
          private readonly ISession _session;
          public AuthentificationController()
          {
               var bl = new BusinessLogics();
               _session = bl.GetSessionBL();
          }

          public ActionResult SignIn()
          {
               return View();
          }

          [HttpPost]
          public ActionResult SignIn(UserLogin login)
          {
               if (ModelState.IsValid)
               {
                    var data = new ULoginData
                    {
                         Username = login.Username,
                         Password = login.Password,
                         LoginDateTime = DateTime.Now
                    };
                    var userLogin = _session.UserLogin(data);
                    if (userLogin.Status)
                    {
                         return Redirect("/Home/Index");
                    }
                    else
                    {
                         ModelState.AddModelError("", userLogin.StatusMsg);
                    }
               }
               return Redirect("/Home/Index");
          }

          [HttpPost]
          public ActionResult SignUp()
          {
               return View();
          }
     }
}