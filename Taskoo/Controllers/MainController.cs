using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Taskoo.Helpers;

namespace Taskoo.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index(char priority = 'g')
        {
            TaskDataContext db = new TaskDataContext();

            TaskManager taskManager = new TaskManager();

            List<Task> tasks = taskManager.getAllNotFinishedTasksByPriority(db, priority);

            ViewBag.Tasks = taskManager.processTasks(tasks);

            return View();
        }
    }
}