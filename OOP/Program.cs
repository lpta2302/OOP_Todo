using OOP.BL;

namespace Name
{
    class Program
    {
       
        public static void Main()
        {
            MyFakeData.Init();
            List<Task> listT = TaskFilter.ArrangeByType();
            foreach (Task t in listT)
            {
                Console.WriteLine(t);
            }

        }
    }
}