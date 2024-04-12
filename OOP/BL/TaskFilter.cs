using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SearchTask;

namespace OOP.BL
{
    public class TaskFilter
    {
        public enum TaskType
        {
            ShortTerm,
            LongTerm,
            IsImportance,
            IsComplete
        }
        public delegate void ArrangeDelegate();
        public List<Task> listTask;
        public List<Task> FilterBy(TaskType taskType)
        {
            ArrangeDelegate arrangeDelegate = CreateFilterBy(taskType);
            if (arrangeDelegate != null)
            {
                arrangeDelegate();
            }
            return listTask;
        }

        public ArrangeDelegate CreateFilterBy(TaskType taskType)
        {
            ArrangeDelegate? arrangeDelegate = null;
            switch (taskType)
            {
                case TaskType.ShortTerm:
                    arrangeDelegate += ArrangeByShortTerm;
                    break;
                case TaskType.LongTerm:
                    arrangeDelegate += ArrangeByLongTerm;
                    break;
                case TaskType.IsImportance:
                    arrangeDelegate += ArrangeByImportance;
                    break;
                case TaskType.IsComplete:
                    arrangeDelegate += ArrangeByCompletion;
                    break;
                default: return null;
            }
            return arrangeDelegate;
        }
        public void ArrangeByShortTerm()
        {
            listTask = new List<Task>();    
            foreach ( Task task in GlobalData.CurrentTasks)
            {
                if ( task is ShortTerm)
                {
                    listTask.Add(task);
                }
            }
        }
        public void ArrangeByLongTerm()
        {
            listTask = new List<Task>();
            foreach (Task task in GlobalData.CurrentTasks)
            {
                if (task is LongTerm)
                {
                    listTask.Add(task);
                }
            }
        }
        public void ArrangeByImportance()
        {
            listTask = new List<Task>();
            foreach (Task task in GlobalData.CurrentTasks)
            {
                if (task.IsImportant)
                {
                    listTask.Add(task);
                }
            }
        }
        public void ArrangeByCompletion()
        {
            listTask = new List<Task>();
            foreach (Task task in GlobalData.CurrentTasks)
            {
                if (task.IsCompleted)
                {
                    listTask.Add(task);
                }
            }
        }
    }
}
