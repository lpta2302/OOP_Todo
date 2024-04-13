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
            else notiTime = DateTime.MinValue;
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

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Id", Id);
        info.AddValue("Title", Title);
        info.AddValue("Content", Content);
        info.AddValue("CreatedAt", CreatedAt);
        info.AddValue("NotiTime", NotiTime);
        info.AddValue("EndTime", EndTime);
        info.AddValue("IsCompleted", IsCompleted);
        info.AddValue("IsImportant", IsImportant);
        info.AddValue("IsRepeated", IsRepeated);
    }

    protected Task()
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Content = "";
        Title = "";
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

    public override string ToString()
    {
        return
            $"{Id}, {Title}, {NotiTime}, comp:{IsCompleted}, imp:{IsImportant}, rep:{IsRepeated}, {GetType()}";
    }
}