using System;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Web.Controllers.Attributes;
using WebApplication1.Web.Extensions;

namespace WebApplication1.Web.Controllers
{
	public class PostsController : BaseController
	{
		private readonly IBlog _blog;

		public PostsController()
		{
			var bl = new InstanceBL();
			_blog = bl.GetBlogBL();
		}

		public ActionResult Index()
		{
			SessionStatus();
			return View(_blog.GetAllPosts());
		}

		[AdminMod]
		public ActionResult Create()
		{
			SessionStatus();
			return View();
		}

		[AdminMod]
		[HttpPost]
		public ActionResult Create(PostEntity post)
		{
			SessionStatus();

			if (string.IsNullOrEmpty(post.Title) || string.IsNullOrEmpty(post.PostContent))
				return View();

			var user = System.Web.HttpContext.Current.GetMySessionObject();

			try
			{
				post.Date = DateTime.Now;
				post.User = user;

				_blog.TryAddPost(post);

				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public ActionResult Details(int id)
		{
			return View(_blog.GetPostById(id));
		}

		[AdminMod]
		public ActionResult Edit(int id)
		{
			return View(_blog.GetPostById(id));
		}

		[AdminMod]
		[HttpPost]
		public ActionResult Edit(PostEntity post)
		{
			if (post == null)
				return RedirectToAction("Index");

			try
			{
				var result = _blog.TryEditPost(post);

				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		[AdminMod]
		public ActionResult Delete(int? id)
		{
			if (id == null) return View();
			return View(_blog.GetPostById((int)id));
		}

		[AdminMod]
		[HttpPost]
		public ActionResult Delete(int id)
		{
			try
			{
				var result = _blog.TryDeletePost(id);

				if (result)
				{
					return RedirectToAction("Index");
				} else
				{
					return View();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}