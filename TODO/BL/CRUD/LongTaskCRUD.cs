using TODO.DA;
public class LongTaskCRUD : TaskCRUD
{
    private static readonly LongTaskCRUD instance = new LongTaskCRUD();
    private LongTaskCRUD() { }
    public static LongTaskCRUD Instance { get { return instance; } }
    public override Task? Create(object[] args)
    {
        LongTask task = new LongTask(
            (string)args[0],
            (string)args[1],
            (string)args[2],
            (DateTime)args[3],
            (DateOnly)args[4],
            (DateOnly)args[5],
            (bool)args[6],
            (bool)args[7],
            new List<Detail>()
        );

        GlobalData.CurrentTasks.Add(task);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return task;
    }
}
