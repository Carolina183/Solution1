using System;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Web.Models;
using WebApplication1.BusinessLogic.Interfaces;
using System.Web.Routing;

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
					HttpCookie cookie = _session.GenCookie(login.Username);
					ControllerContext.HttpContext.Response.Cookies.Add(cookie);

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
		[ValidateAntiForgeryToken]
		public ActionResult SignUp(UserRegisterModel user)
		{
			if (ModelState.IsValid)
			{
				var data = new URegisterData
				{
					Login = user.Login,
					Password = user.Password,
					RegisterDate = DateTime.Now
				};

				var registerResponse = _session.UserRegister(data);
				if (registerResponse.Status)
				{
					return Redirect("/Home/Index");
				}
				else
				{
					ModelState.AddModelError("", registerResponse.StatusMsg);
				}
			}
			return Redirect("/Home/Index");
		}

		public ActionResult Logout()
		{
			var apiCookie = Request.Cookies["X-KEY"];
			var sessionExist = _session.UserLogout(apiCookie.Value);
			if (sessionExist.Status)
			{
				return new RedirectToRouteResult(new
					RouteValueDictionary(new { controller = "Home", action = "Index" }));
			}
			else
			{
				ModelState.AddModelError("", sessionExist.StatusMsg);
			}
			return Redirect("/Home/Index");
		}
	}
}