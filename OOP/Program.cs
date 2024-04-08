namespace Name
{
    class Program
    {
        public static void Main()
        {
            MyFakeData.Init();
            Console.WriteLine(new EntityManager<Plan>().GetAll()[0]);
        }
    }
}