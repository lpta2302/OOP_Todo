using OOP.BL;

namespace Name
{
    class Program
    {
        public static void Main()
        {
            MyFakeData.Init();
            SearchTaskService searchTask = new SearchTaskService();
            IList<Task>? tasks = searchTask.Search("Đi học", SearchTaskService.SearchType.ByTitle);

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
