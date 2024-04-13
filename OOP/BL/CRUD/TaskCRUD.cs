public abstract class TaskCRUD : CRUD<Task>
{
    protected static TaskCRUD instance;

    public abstract Task? Create(object[] args);
    public Task Create(Task newTask)
    {
        GlobalData.CurrentTasks.Add(newTask);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return newTask;
    }

    public Task? Delete(object i)
    {
        Task? deletedTask = Util.FindTask((string)i);
        if (deletedTask == null)
            throw new Exception("Không tìm thấy task");

        GlobalData.CurrentTasks.Remove(deletedTask);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return deletedTask;
    }

    public Task Read(object i)
    {
        Task? task = Util.FindTask((string)i);

        if (task == null)
            throw new Exception("Không tìm thấy task");

        return task;
    }

    public Task? Update(Task newTask)
    {
        Task? task = Util.FindTask(newTask.Id);

        if (task == null)
            throw new Exception("Không tìm thấy task");

        Util.CoppyClass(newTask, task);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return task;
    }
}
