using FBLmannagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace FBLmannagement.Controllers
{
    public class AddController : Controller
    {
        MyDbContext context = new MyDbContext();
        // GET: Add
        public ActionResult Index()
        {
            return View(context.AddResults);
        }
        public ActionResult ADD()
        {
            return View();
        }
        public ActionResult ADDED(AddResult a)
        {
            context.AddResults.Add(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
      
        



    }
}