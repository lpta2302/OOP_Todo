public interface ITaskCRUD<TaskType>
{
    public TaskType Create(object[] args);
    public TaskType Read(object i);
    public TaskType Update(Task newTask);
    public TaskType Delete(object i);
}
