public class ShortTermService : TaskService
{
    public static List<ShortTerm> GetShortTerms()
    {
        return new List<ShortTerm>();
    }

    public int CountShortTerm()
    {
        int count = 0;
        foreach (ShortTerm shortTerm in GlobalData.CurrentTasks)
        {
            if (shortTerm is ShortTerm)
            {
                count++;
            }
        }
        return count;
    }

}
