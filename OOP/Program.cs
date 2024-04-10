namespace Name
{
    class Program
    {
        public static Task Create()
        {
            return new ShortTerm();
        }
        public static Task CreateLong(){
            return new LongTerm(){
                From = DateTime.Now
            };
        }
        public static void Main()
        {
        }
    }
}