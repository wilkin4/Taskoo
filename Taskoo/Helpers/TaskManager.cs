using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskoo.Helpers
{
    public class TaskManager
    {
        // No test for this method yet.
        public IEnumerable<Task> getTasksByPriority(TaskDataContext db, char? priority)
        {
            var query = getTasks(db, 'g');

            switch (priority)
            {
                case 'g':
                    query = getTasks(db, 'g');
                    break;
                case 'y':
                    query = getTasks(db, 'y');
                    break;
                case 'r':
                    query = getTasks(db, 'r');
                    break;
            }

            return query;
        }

        // No test for this method yet.
        public IEnumerable<Task> getTasks(TaskDataContext db, char priority)
        {
            return from c in db.Tasks
                   where c.priority == priority && c.isDone == false
                   orderby c.finalDate ascending
                   select c;
        }

        // No test for this method yet.
        public List<TaskProcessed> processTasks(List<Task> tasks)
        {
            List<TaskProcessed> tasksProcessedList = new List<TaskProcessed>();

            foreach (var task in tasks)
            {
                TaskProcessed taskProcessed = new TaskProcessed();

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
    }
}