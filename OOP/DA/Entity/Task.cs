using System.Runtime.Serialization;

public abstract class Task : ISerializable
{
    public string Id { get; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; }
    private DateTime notiTime;
    public DateTime NotiTime
    {
        get
        {
            return notiTime;
        }
        set
        {
            if (value >= DateTime.Now && value <= DateTime.MaxValue)
                notiTime = value;
        }
    }
    private DateTime? endTime;
    public DateTime? EndTime
    {
        get
        {
            return endTime;
        }
        set
        {
            if (value == null || value >= notiTime)
                endTime = value;
        }
    }
    public bool IsCompleted { get; set; }
    public bool IsImportant { get; set; }
    public bool IsRepeated { get; set; }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id", Id);
        info.AddValue("title", Title);
        info.AddValue("content", Content);
        info.AddValue("createdAt", CreatedAt);
        info.AddValue("notiTime", NotiTime);
        info.AddValue("endTime", EndTime);
        info.AddValue("isCompleted", IsCompleted);
        info.AddValue("isImportant", IsImportant);
        info.AddValue("isRepeated", IsRepeated);
    }
    public Task(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("id")!;
        Title = info.GetString("title")!;
        Content = info.GetString("content")!;
        CreatedAt = info.GetDateTime("createdAt");
        NotiTime = info.GetDateTime("notiTime");
        NotiTime = info.GetDateTime("endTime");
        IsCompleted = info.GetBoolean("isCompleted");
        IsImportant = info.GetBoolean("isImportant");
        IsRepeated = info.GetBoolean("isRepeated");
    }
    protected Task()
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Content = "";
        IsCompleted = false;
        IsImportant = false;
        IsRepeated = false;
    }

    protected Task(string title, string content, DateTime notiTime, bool isCompleted, bool isImportant, bool isRepeated, DateTime? endTime = null)
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Title = title;
        Content = content;
        NotiTime = notiTime;
        EndTime = endTime;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
    }
}