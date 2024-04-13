using OOP.BL;

namespace Name
{
    class Program
    {
        public static void PrintTasks(IList<Task> tasks)
        {
            if (tasks != null)
            {
                foreach (Task task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
            else
            {
                Console.WriteLine("No tasks found.");
            }
            Console.WriteLine("".PadRight(40, '-'));
        }
        public static void Main()
        {
            MyFakeData.Init();

            IList<Task>? tasks = FilterTaskService.Instance.DoFilter(FilterTaskService.TaskType.LongTerm);

            PrintTasks(tasks);
            SortTaskService.Instance.Sort(tasks, SortTaskService.SortType.ByStartDate);
            PrintTasks(tasks);
        }
    }
}
