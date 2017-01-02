using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskoo.Helpers
{
    public class TaskProcessed
    {
        public char Priority { get; set; }
        public string Title { get; set; }
        public string PriorityIconName { get; set; }
        public string IsFinishedIconName { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public bool IsAvailable { get; set; }
    }
}