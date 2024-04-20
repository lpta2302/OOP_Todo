using System.Runtime.Serialization;

namespace TODO.DA;
public sealed class Detail: ISerializable
{
    public string Id { get; set; }
    public string Content { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? Time { get; set; }
    public Detail(string content = "", bool isCompleted = false)
    {
        Id = Generator.GenerateId();
        Content = content;
        IsCompleted = isCompleted;
    }
    public void ToggleCompletion()
    {
        IsCompleted = !IsCompleted;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Id", Id);
        info.AddValue("Content", Content);
        info.AddValue("IsComplete", IsCompleted);
    }
    public Detail(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("Id");
        Content = info.GetString("Content");
        IsCompleted = info.GetBoolean("Iscomplete");
    }
}
