using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Taskoo.Helpers;

namespace Taskoo.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index(char? id)
        {
            TaskDataContext db = new TaskDataContext();

            var query = from c in db.Tasks
                        select c;

            switch (id)
            {
                case 'r':
                    query = from c in db.Tasks
                            where c.priority == 'r'
                            select c;
                    break;
                case 'g':
                    query = from c in db.Tasks
                            where c.priority == 'g'
                            select c;
                    break;
                case 'y':
                    query = from c in db.Tasks
                            where c.priority == 'y'
                            select c;
                    break;
            }

            List<Task> tasks = query.ToList();

            ViewBag.Tasks = ProcessTasks(tasks);

            return View();
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
            return isDone ? "check2" : "check1";
        }
    }
}