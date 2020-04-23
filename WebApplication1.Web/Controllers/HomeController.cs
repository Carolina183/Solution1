using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;

namespace WebApplication1.Web.Controllers
{
     public class HomeController : BaseController
     {
          private readonly IBlog _blog;

          public HomeController()
          {
               var bl = new InstanceBL();
               _blog = bl.GetBlogBL();
          }

          public ActionResult Index()
          {
               SessionStatus();
               return View(_blog.GetAllPosts());
          }

          public ActionResult Detail(int id)
          {
               SessionStatus();
               return View(_blog.GetPostById(id));
          }

          public ActionResult FlowerCompositions()
          {
               SessionStatus();
               return View();
          }
          public ActionResult Contacts()
          {
               SessionStatus();
               return View();
          }
          public ActionResult FlowerBouquets()
          {
               SessionStatus();
               return View();
          }

          public ActionResult Cakes()
          {
               SessionStatus();
               return View();
          }

          public ActionResult Toys()
          {
               SessionStatus();
               return View();
          }

          public ActionResult Balloons()
          {
               SessionStatus();
               return View();
          }
     }
}