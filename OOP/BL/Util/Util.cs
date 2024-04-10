public class Util
{
    public static Task? FindTask(string key)
    {
        int id = 0;
        foreach (Task task in GlobalData.CurrentTasks)
        {
            if (task.Id.Equals(key))
                return task;
            id++;
        }
        return null;
    }
}
