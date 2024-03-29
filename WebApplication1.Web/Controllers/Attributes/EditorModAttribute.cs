﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.Enums;
using WebApplication1.Web.Extensions;

namespace WebApplication1.Web.Controllers.Attributes
{
     public class EditorModAttribute : ActionFilterAttribute
	{
		private readonly ISession _sessionBL;

		public EditorModAttribute()
		{
			var businessLogic = new InstanceBL();
			_sessionBL = businessLogic.GetSessionBL();
		}

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
			if (apiCookie != null)
			{
				var profile = _sessionBL.GetUserByCookie(apiCookie.Value);
				if (profile != null && profile.Level.CompareTo(URole.Administrator) >= 0)
				{
					HttpContext.Current.SetMySessionObject(profile);
				}
				else
				{
					filterContext.Result = new RedirectToRouteResult(new
						RouteValueDictionary(new { controller = "Home", action = "Index" }));
				}
			}
		}
	}
}