using System.Reflection;

public abstract class TaskService
{
    protected TaskService _taskService;
    public enum BoolProp
    {
        IsCompleted,
        IsImportant,
        IsRepeated
    }
    //Pass task and Prop type that need Toggle ex: ToggleBoolProp(task, BoolProp.IsImportant)
    public void ToggleBoolProp(Task task, BoolProp propType)
    {
        PropertyInfo prop = typeof(Task).GetProperty(Enum.GetName(propType) ?? "")!;

        prop.SetValue(task, !(bool)prop.GetValue(task));
    }

    public bool IsTime(Task task)
    {
        return DateTime.Now == task.NotiTime;
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
}
