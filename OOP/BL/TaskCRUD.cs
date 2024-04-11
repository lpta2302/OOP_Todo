public abstract class TaskCRUD<TaskType>
{
    public abstract TaskType? Create(object[] args);
    public TaskType? Delete(object i)
    {
        Task? deletedTask = Util.FindTask((string)i);
        if (deletedTask == null)
            throw new Exception("Không tìm thấy task");

        GlobalData.CurrentTasks.Remove(deletedTask);

        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return TypeConverter.Convert<Task, TaskType>(deletedTask);
    }

    public TaskType? Read(object i)
    {
        Task? task = Util.FindTask((string)i);
        
        if (task == null)
            throw new Exception("Không tìm thấy task");

        return TypeConverter.Convert<Task, TaskType>(task);
    }

    public TaskType? Update(Task newTask)
    {
        Task? task = Util.FindTask(newTask.Id);

        if (task == null)
            throw new Exception("Không tìm thấy task");

        task = newTask;
        EntityManager<Task>.Save(GlobalData.CurrentTasks);

        return TypeConverter.Convert<Task, TaskType>(task);
    }
}
