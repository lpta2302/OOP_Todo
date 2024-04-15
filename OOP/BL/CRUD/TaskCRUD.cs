public abstract class TaskCRUD : ICRUD<Task>
{
    public abstract Task? Create(object[] args);
    public Task Create(Task newTask)
    {
        GlobalData.CurrentTasks.Add(newTask);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return newTask;
    }

    public Task? Delete(object i)
    {
        Task? task = Util.FindTask((string)i);
        if (task == null)
            throw new Exception("Task not found");

        GlobalData.CurrentTasks.Remove(task);

        EntityManager<Task>.Delete(task);

        return task;
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
