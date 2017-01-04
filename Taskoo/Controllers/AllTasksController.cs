using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taskoo.Helpers;

namespace Taskoo.Controllers
{
    public class AllTasksController : Controller
    {
        // GET: AllTasks
        public ActionResult Index(char? priority)
        {
            TaskDataContext db = new TaskDataContext();

            TaskManager taskManager = new TaskManager();

            List<Task> tasks = taskManager.getAllTasksByPriority(db, priority);

            ViewBag.Tasks = taskManager.processTasks(tasks);

            return View();
        }
    }
}