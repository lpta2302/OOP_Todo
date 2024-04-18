﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class FilterTaskService
    {
        private FilterTaskService() { }
        private static FilterTaskService instance;
        public static FilterTaskService Instance
        {
            get
            {
                if (instance == null)
                    instance = new FilterTaskService();
                return instance;
            }
        }
        public enum TaskType
        {
            ShortTerm,
            LongTerm,
            IsImportance,
            IsUnComplete,
            IsComplete
        }
        private delegate void ArrangeDelegate(Task task, ref bool accumulator);
        public List<Task> DoFilter(TaskType taskType, IList<Task>? tasks = null)
        {
            return FilterInternally(new[] { taskType }, tasks);
        }
        public List<Task> DoFilter(TaskType[] taskTypes, IList<Task>? tasks = null)
        {
            return FilterInternally(taskTypes, tasks);
        }
        private List<Task> FilterInternally(TaskType[] taskTypes, IList<Task>? tasks = null)
        {
            if (tasks == null)
                tasks = GlobalData.CurrentTasks;

            List<Task> res = new List<Task>();

            ArrangeDelegate? arrangeDelegate = CreateFilterDel(taskTypes);

            if (arrangeDelegate == null)
                return new List<Task>();

            foreach (Task task in tasks)
            {
                bool checker = true;

                arrangeDelegate(task, ref checker);

                if (checker)
                    res.Add(task);
            }

            return res;
        }

        private ArrangeDelegate? CreateFilterDel(TaskType[] taskTypes)
        {
            ArrangeDelegate? arrangeDelegate = null;

            foreach (TaskType taskType in taskTypes)
            {
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
                    case TaskType.IsUnComplete:
                        arrangeDelegate += ArrangeByUnCompletion;
                        break;
                    case TaskType.IsComplete:
                        arrangeDelegate += ArrangeByCompletion;
                        break;
                    default:
                        return arrangeDelegate;
                }
            }
            return arrangeDelegate;
        }
        private void ArrangeByShortTerm(Task task, ref bool accumulator)
        {
            accumulator = accumulator && task is ShortTerm;
        }
        private void ArrangeByLongTerm(Task task, ref bool accumulator)
        {
            accumulator = accumulator && task is LongTerm;
        }
        private void ArrangeByImportance(Task task, ref bool accumulator)
        {
            accumulator = accumulator && task.IsImportant;
        }
        private void ArrangeByUnCompletion(Task task, ref bool accumulator)
        {
            accumulator = accumulator && !task.IsCompleted;
        }
        private void ArrangeByCompletion(Task task, ref bool accumulator)
        {
            accumulator = accumulator && task.IsCompleted;
        }
    }
}
