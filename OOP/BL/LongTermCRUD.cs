public class LongTermCRUD : TaskCRUD<LongTerm>
{
    public override LongTerm? Create(object[] args)
    {
        LongTerm task = new LongTerm(
            (string)args[0],
            (string)args[1],
            (DateTime)args[2],
            (DateTime)args[3],
            (DateTime)args[4],
            (bool)args[5],
            (bool)args[6],
            (bool)args[7],
            new List<Detail>()
        );

        GlobalData.CurrentTasks.Add(task);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return task;
    }
}
