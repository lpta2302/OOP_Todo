namespace Name
{
    class Program
    {
        public static void Main(){
            ShortTerm shortTerm = new ShortTerm(
                "First","Hello World",DateTime.Now,true,false,false,new Tag()
            );
            Console.WriteLine(shortTerm);
        }
    }
}