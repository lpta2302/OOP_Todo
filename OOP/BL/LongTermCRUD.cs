public class LongTermCRUD : ITaskCRUD<LongTerm>
{
    public LongTerm Create(object[] args)
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

    public LongTerm Delete(object i)
    {
        Task? deletedTask = Util.FindTask((string)i);
        if (deletedTask == null)
            throw new Exception("Không tìm thấy task");

        GlobalData.CurrentTasks.Remove(deletedTask);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return (LongTerm)deletedTask;
    }

    public LongTerm Read(object i)
    {
        Task? task = Util.FindTask((string)i);
        if (task == null)
            throw new Exception("Không tìm thấy task");
        return (LongTerm)task;
    }

    public LongTerm Update(Task newTask)
    {
        Task? task = Util.FindTask(newTask.Id);

        if (task == null)
            throw new Exception("Không tìm thấy task");

        task = newTask;
        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return (LongTerm)task;
        throw new NotImplementedException();
    }
}
