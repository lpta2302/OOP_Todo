using System.Collections;

public class GlobalData
{
    public static IList<Task> CurrentTasks { get; set; }

    public static IList<Plan> CurrentPlans { get; set; }
    static GlobalData()
    {
        if (CurrentTasks == null)
            CurrentTasks = new List<Task>();
        if (CurrentPlans == null)
            CurrentPlans = new List<Plan>();
    }

}
