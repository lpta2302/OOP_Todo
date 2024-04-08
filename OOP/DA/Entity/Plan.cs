using System.Runtime.Serialization;

public class Plan : ISerializable
{
    public string Id { get; set; }

    public DateTime CreatedAt { get; }

    public IList<TaskRef> Tasks { get; set; }
    public Plan()
    {
        CreatedAt = DateTime.Now;
        Id = Generator.GenerateId();
        Tasks = new List<TaskRef>();
    }
    public Plan(List<TaskRef> tasks)
    {
        CreatedAt = DateTime.Now;
        Id = Generator.GenerateId();
        Tasks = tasks;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Id", Id);
        info.AddValue("CreatedAt", CreatedAt);
        info.AddValue("Tasks", Tasks);
    }

    public void AddTask(string id)
    {
        Tasks.Add(new TaskRef(id));
    }
}
