using System.Reflection;

public interface ITaskService
{
    public enum BoolProp
    {
        IsImportant,
        IsRepeated
    }
    //Pass task and Prop type that need Toggle ex: ToggleBoolProp(task, BoolProp.IsImportant)
    public void ToggleBoolProp(Task task, BoolProp propType)
    {
        PropertyInfo prop = typeof(Task).GetProperty(Enum.GetName(propType) ?? "")!;

        prop.SetValue(task, !(bool)prop.GetValue(task));

        task.Update();
    }

    public bool IsTime(Task task)
    {
        return task.NotiTime == DateTime.Now;
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
