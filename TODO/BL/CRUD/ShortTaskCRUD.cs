public class ShortTaskCRUD : TaskCRUD
{
    private static readonly ShortTaskCRUD instance = new ShortTaskCRUD();
    private ShortTaskCRUD() { }
    public static ShortTaskCRUD Instance { get { return instance; } }

    public override ShortTask? Create(object[] args)
    {
        ShortTask task = new ShortTask(
            (string)args[0],
            (string)args[1],
            (DateTime)args[2],
            (bool)args[3],
            (bool)args[4],
            (bool)args[5]
        );

        GlobalData.CurrentTasks.Add(task);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return task;
    }
}
