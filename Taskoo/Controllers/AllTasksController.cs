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
        public ActionResult Index(char priority)
        {
            TaskDataContext db = new TaskDataContext();

            // This is for save a task in the DB, it need to be place in the correct place.
            if (priority == 's')
            {
                Task task = new Task();

                task.priority = 'r';
                task.title = "Esto es una prueba";
                task.finalDate = new DateTime(2017, 11, 4, 9, 30, 0);
                task.description = "Esto es una descripción.";
                task.isDone = false;
                task.isAvailable = true;

                db.Tasks.InsertOnSubmit(task);
                db.SubmitChanges();
            }

            TaskManager taskManager = new TaskManager();

            List<Task> tasks = taskManager.getAllTasksByPriority(db, priority);

            ViewBag.Tasks = taskManager.processTasks(tasks);

            return View();
        }
    }
}