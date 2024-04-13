using System.Reflection;

public interface ITaskService
{
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

        prop.SetValue(task,!(bool)prop.GetValue(task));
    }
}
