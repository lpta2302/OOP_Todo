using OOP.BL;

namespace Name
{
    class Program
    {
        public static void Main()
        {
            MyFakeData.Init();
            SearchTask searchTask = new SearchTask();
            IList<Task>? tasks = searchTask.Search(Generator.GenerateId(), SearchTask.SearchType.ByID);

            foreach (Task task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}