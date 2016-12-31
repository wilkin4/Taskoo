using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Taskoo.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            TaskDataContext db = new TaskDataContext();

            var query = from c in db.Tasks
                        select c;

            var tasks = query.ToList();

            ViewBag.Tasks = tasks;

            return View();
        }
    }
}