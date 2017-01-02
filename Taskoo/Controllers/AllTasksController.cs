using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taskoo.Controllers
{
    public class AllTasksController : Controller
    {
        // GET: AllTasks
        public ActionResult Index(char? priority)
        {
            ViewBag.Priority = priority;
        
            return View();
        }
    }
}