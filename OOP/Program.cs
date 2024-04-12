using OOP.BL;

namespace Name
{
    class Program
    {
        public static void Main()
        {
            MyFakeData.Init();
            TaskFilter taskFilter = new TaskFilter();
            IList<Task> tasks = taskFilter.FilterBy(TaskFilter.TaskType.IsImportance);

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
        }
    }
}
