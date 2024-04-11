public class GlobalData
{
    public static IList<Task> CurrentTasks { get; set; }

    public static IList<Plan> CurrentPlans { get; set; }
    static GlobalData()
    {
        CurrentTasks = EntityManager<Task>.GetAll()!;
        CurrentPlans = EntityManager<Plan>.GetAll()!;

        if (CurrentTasks == null)
            CurrentTasks = new List<Task>();
        if (CurrentPlans == null)
            CurrentPlans = new List<Plan>();
    }

}
