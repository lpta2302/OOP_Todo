using System.Runtime.Serialization;

public class Plan : ISerializable, IProgressService
{
    public string Id { get; set; }

    public string Name { get; set; }

    public DateTime CreatedAt { get; }

    public IList<TaskRef> Tasks { get; set; }
    public Plan()
    {
        CreatedAt = DateTime.Now;
        Id = Generator.GenerateId();
        Tasks = new List<TaskRef>();
    }
    public Plan(List<TaskRef> tasks, string name)
    {
        CreatedAt = DateTime.Now;
        Id = Generator.GenerateId();
        Tasks = tasks;
        Name = name;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id", Id);
        info.AddValue("createdAt", CreatedAt);
        info.AddValue("tasks", Tasks);
        info.AddValue("name", Name);
    }

    public Plan(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("id");
        Name = info.GetString("name");
        CreatedAt = info.GetDateTime("createdAt");
        List<TaskRef> tasksArray = info.GetValue("tasks", typeof(List<TaskRef>)) as List<TaskRef>;
    }

    public void AddTask(Task task)
    {
        Tasks.Add(new TaskRef(task.Id));
    }
    public void AddTask(string id)
    {
        Tasks.Add(new TaskRef(id));
    }
    public override string ToString()
    {
        return
        $"{Name}, {CreatedAt}, {Tasks[0].Id}";
    }

    public float CalculateCurrentProgress()
    {
        int count = 0;

        foreach (TaskRef taskRef in Tasks)
        {
            Task task = Util.FindTask(taskRef.Id)!;
            if (task.IsCompleted)
                count++;
        }

        return (float)Math.Round(1.0 * count*100 / Tasks.Count, 2);
    }
}
