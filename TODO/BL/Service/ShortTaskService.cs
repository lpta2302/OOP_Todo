public class ShortTaskService : ITaskService
{
    private static ShortTaskService instance = new ShortTaskService();
    private ShortTaskService() { }
    public static ShortTaskService Instance { get { return instance; } }
    public void CompleteTask(Task task)
    {
        task.IsCompleted = !task.IsCompleted;
        task.Update();
    }
    public void ToggleRepeated(ShortTask task)
    {
        task.IsRepeated = !task.IsRepeated;

        task.Update();
    }
    public void AlertAgain(Task task)
    {
        task.NotiTime.AddMinutes(15);
    }
}
