using System.Runtime.Serialization;

public abstract class Task : ISerializable
{
    public string Id { get; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime NotiTime { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsImportant { get; set; }
    public bool IsRepeated { get; set; }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id",Id);
        info.AddValue("title",Title);
        info.AddValue("content",Content);
        info.AddValue("createdAt",CreatedAt);
        info.AddValue("notiTime",NotiTime);
        info.AddValue("isCompleted",IsCompleted);
        info.AddValue("isImportant", IsImportant);
        info.AddValue("isRepeated", IsRepeated );
    }
}