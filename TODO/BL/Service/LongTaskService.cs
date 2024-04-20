using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class LongTaskService : ITaskService
{
    private static LongTaskService instance = new LongTaskService();
    private LongTaskService() { }
    public static LongTaskService Instance { get { return instance; } }
    public void CompleteTask(Task _task)
    {
        _task.IsCompleted = !_task.IsCompleted;
        LongTask task = (_task as LongTask)!;
        foreach (Detail detail in task.Details)
        {
            detail.IsCompleted = !detail.IsCompleted;
        }
        _task.Update();
    }
}
