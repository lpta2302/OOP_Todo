public class GlobalData
{
    private GlobalData() { }
    public static IList<Task> CurrentTasks { get; set; }
    public static IList<Plan> CurrentPlans { get; set; }
    public static ITaskService ShortTermService { get; set; }
    public static ITaskService LongTermService { get; set; }
    public static Plan CurrentPlan { get; set; }
    static GlobalData()
    {
        CurrentTasks = EntityManager<Task>.GetAll()!;
        CurrentPlans = EntityManager<Plan>.GetAll()!;

        if (CurrentTasks == null)
            CurrentTasks = new List<Task>();
        if (CurrentPlans == null)
            CurrentPlans = new List<Plan>();
        SortTaskService.Instance.Sort(CurrentTasks);
    }

}
