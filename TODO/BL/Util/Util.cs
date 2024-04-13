using System.Reflection;
using System.Text;

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
    public static Plan? FindPlan(string key)
    {
        int id = 0;
        foreach (Plan plan in GlobalData.CurrentPlans)
        {
            if (plan.Id.Equals(key))
                return plan;
            id++;
        }
        return null;
    }
    public static void CoppyClass<T>(T intiInstance, T coppiedInstance)
    {
        Type type = typeof(T);

        PropertyInfo[] props = type.GetProperties();
        foreach (PropertyInfo prop in props)
        {
            if (prop.CanWrite)
            {
                prop.SetValue(coppiedInstance, prop.GetValue(intiInstance));
            }
        }
    }
}
