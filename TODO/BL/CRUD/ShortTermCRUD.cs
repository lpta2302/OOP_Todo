public class ShortTermCRUD : TaskCRUD
{
    private static readonly ShortTermCRUD instance = new ShortTermCRUD();
    private ShortTermCRUD() { }
    public static ShortTermCRUD Instance { get { return instance; } }

    public override ShortTerm? Create(object[] args)
    {
        ShortTerm task = new ShortTerm(
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
