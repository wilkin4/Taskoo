using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taskoo.Helpers;

namespace Taskoo.Controllers
{
    public class EditTaskController : Controller
    {
        // GET: EditTask
        public ActionResult Index(int taskId)
        {
            TaskDataContext db = new TaskDataContext();

            TaskManager taskManager = new TaskManager();

            Task task = taskManager.getTaskById(db, taskId)[0];

            ViewBag.Task = taskManager.processTask(task);

            return View();
        }
    }
}