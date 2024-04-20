using System.Reflection;

public interface ITaskService
{
    public void ToggleIsNotificated(Task task)
    {
        task.IsNotificated = !task.IsNotificated;

        task.Update();
    }
    public void ToggleImportant(Task task)
    {
        task.IsImportant = !task.IsImportant;

        task.Update();
    }

    public bool IsTime(Task task)
    {
        return task.NotiTime.Hour == DateTime.Now.Hour &&
        task.NotiTime.Minute == DateTime.Now.Minute;
    }

    public List<Task> IsTime(IList<Task> tasks)
    {
        List<Task> res = new List<Task>();
        foreach (Task task in tasks)
        {
            if (IsTime(task))
                res.Add(task);
        }
        return res;
    }

    public void CompleteTask(Task task);
}
