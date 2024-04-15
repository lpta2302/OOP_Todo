public class ShortTermService : ITaskService
{
    private static ShortTermService instance = new ShortTermService();
    private ShortTermService() { }
    public static ShortTermService Instance { get { return instance; } }
    public void CompleteTask(Task task)
    {
        task.IsCompleted = true;
        task.Update();
    }
    public void AlertAgain(Task task)
    {
        task.NotiTime.AddMinutes(15);
    }
}
