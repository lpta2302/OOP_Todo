using System.Collections;

public class GlobalData
{
    public static IList<Task> CurrentTasks;
    public static IList<Plan> CurrentPlans;
    static GlobalData()
    {
        CurrentTasks = new List<Task>();
        CurrentPlans = new List<Plan>();
    }
}
