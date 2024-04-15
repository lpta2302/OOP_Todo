public class LongTermService : ITaskService
{
    private static LongTermService instance = new LongTermService();
    private LongTermService() { }
    public static LongTermService Instance { get { return instance; } }
    public void CompleteTask(Task _task)
    {
        LongTerm task = (_task as LongTerm)!;
        foreach (Detail detail in task.Details)
        {
            detail.IsCompleted = true;
        }
    }
}
