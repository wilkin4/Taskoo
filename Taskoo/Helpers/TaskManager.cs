using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskoo.Helpers
{
    public class TaskManager
    {
        public List<Task> getTaskById(TaskDataContext db, int taskId)
        {
            return (from c in db.Tasks
                    where c.taskID == taskId
                    select c).ToList();
        }

        // No test for this method yet.
        public List<Task> getAllNotFinishedTasksByPriority(TaskDataContext db, char priority)
        {
            List<Task> tasks = null;

            switch (priority)
            {
                case 'g':
                    tasks = getNotFinihedTasks(db, 'g');
                    break;
                case 'y':
                    tasks = getNotFinihedTasks(db, 'y');
                    break;
                case 'r':
                    tasks = getNotFinihedTasks(db, 'r');
                    break;
            }

            return tasks;
        }

        // No test for this method yet.
        public List<Task> getNotFinihedTasks(TaskDataContext db, char priority)
        {
            return (from c in db.Tasks
                    where c.priority == priority && c.isDone == false
                    orderby c.finalDate ascending
                    select c).Take(3).ToList();
        }

        // No test for this method yet.
        public List<Task> getAllTasksByPriority(TaskDataContext db, char priority)
        {
            List<Task> tasks = null;

            switch (priority)
            {
                case 'g':
                    tasks = getAllTasks(db, 'g');
                    break;
                case 'y':
                    tasks = getAllTasks(db, 'y');
                    break;
                case 'r':
                    tasks = getAllTasks(db, 'r');
                    break;
                case 'a':
                    tasks = (from c in db.Tasks
                             orderby c.finalDate ascending
                             select c).ToList();
                    break;
            }

            return tasks;
        }

        // No test for this method yet.
        public List<Task> getAllTasks(TaskDataContext db, char priority)
        {
            return (from c in db.Tasks
                    where c.priority == priority
                    orderby c.finalDate ascending
                    select c).ToList();
        }

        // No test for this method yet.
        public List<TaskProcessed> processTasks(List<Task> tasks)
        {
            List<TaskProcessed> tasksProcessedList = new List<TaskProcessed>();

            foreach (var task in tasks)
            {
                TaskProcessed taskProcessed = new TaskProcessed();

                taskProcessed.taskId = task.taskID;
                taskProcessed.Priority = (char)task.priority;
                taskProcessed.IsFinishedTask = (bool) task.isDone;
                taskProcessed.Title = task.title;
                taskProcessed.Date = String.Format("{0:dddd, MMMM d}", task.finalDate);
                taskProcessed.Time = String.Format("{0:T}", task.finalDate);
                taskProcessed.Description = task.description;

                tasksProcessedList.Add(taskProcessed);
            }

            return tasksProcessedList;
        }

        // No test for this method yet.
        public TaskProcessed processTask(Task task)
        {
            TaskProcessed taskProcessed = new TaskProcessed();

            taskProcessed.Priority = (char) task.priority;
            taskProcessed.IsFinishedTask = (bool) task.isDone;
            taskProcessed.Title = task.title;
            taskProcessed.DateTime = (DateTime) task.finalDate;
            taskProcessed.Hour = int.Parse(taskProcessed.DateTime.ToString("hh:mm").Split(':')[0]);
            taskProcessed.Minute = int.Parse(taskProcessed.DateTime.ToString("hh:mm").Split(':')[1]);
            taskProcessed.Description = task.description;

            return taskProcessed;
        }
    }
}