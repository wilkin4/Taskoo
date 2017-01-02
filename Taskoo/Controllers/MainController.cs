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
        private string _highlightClassName = "task-highlighted-icon";

        // GET: Main
        public ActionResult Index(char? priority)
        {
            TaskDataContext db = new TaskDataContext();

            var query = getTasks(db, 'g');

            switch (priority)
            {               
                case 'g':
                    query = getTasks(db, 'g');

                    ViewBag.GreenTransparenceIcon = _highlightClassName;

                    break;
                case 'y':
                    query = getTasks(db, 'y');

                    ViewBag.YellowTransparenceIcon = _highlightClassName;

                    break;
                case 'r':
                    query = getTasks(db, 'r');

                    ViewBag.RedTransparenceIcon = _highlightClassName;

                    break;
                default:
                    ViewBag.GreenTransparenceIcon = _highlightClassName;
                    break;

            }

            List<Task> tasks = query.Take(3).ToList();

            ViewBag.Tasks = ProcessTasks(tasks);

            return View();
        }

        // No test for this method yet.
        private IEnumerable<Task> getTasks(TaskDataContext db, char priority)
        {
            return from c in db.Tasks
                   where c.priority == priority
                   orderby c.finalDate ascending
                   select c;
        }

        // No test for this method yet.
        public List<TaskProcessed> ProcessTasks(List<Task> tasks)
        {
            List<TaskProcessed> tasksProcessedList = new List<TaskProcessed>();

            foreach (var task in tasks)
            {
                TaskProcessed taskProcessed = new TaskProcessed();

                taskProcessed.Priority = (char) task.priority;
                taskProcessed.PriorityIconName = findPriorityIconName((char) task.priority);
                taskProcessed.IsFinishedIconName = findIsFinishedIconName((bool) task.isDone);
                taskProcessed.Title = task.title;
                taskProcessed.Date = String.Format("{0:dddd, MMMM d}", task.finalDate);
                taskProcessed.Time = String.Format("{0:T}", task.finalDate);
                taskProcessed.Description = task.description;

                tasksProcessedList.Add(taskProcessed);
            }

            return tasksProcessedList;
        }

        public string findPriorityIconName(char priority)
        {
            string priorityIconName = "";

            switch (priority)
            {
                case 'r':
                    priorityIconName = "red-triangle";
                    break;
                case 'y':
                    priorityIconName = "yellow-triangle";
                    break;
                case 'g':
                    priorityIconName = "green-triangle";
                    break;
            }

            return priorityIconName;
        }

        public string findIsFinishedIconName(bool isDone)
        {
            return isDone ? this._highlightClassName : "";
        }
    }
}