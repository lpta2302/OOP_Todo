public class ShortTermCRUD : ITaskCRUD<ShortTerm>
{
    public ShortTerm Create(object[] args)
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

    public ShortTerm Delete(object i)
    {
        Task? deletedTask = Util.FindTask((string)i);
        if (deletedTask == null)
            throw new Exception("Không tìm thấy task");

        GlobalData.CurrentTasks.Remove(deletedTask);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return (ShortTerm)deletedTask;
    }

    public ShortTerm Read(object i)
    {
        Task? task = Util.FindTask((string)i);
        if (task == null)
            throw new Exception("Không tìm thấy task");
        return (ShortTerm)task;
    }

    public ShortTerm Update(Task newTask)
    {
        Task? task = Util.FindTask(newTask.Id);

        if (task == null)
            throw new Exception("Không tìm thấy task");

        task = newTask;
        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return (ShortTerm)task;
        throw new NotImplementedException();
    }
}
