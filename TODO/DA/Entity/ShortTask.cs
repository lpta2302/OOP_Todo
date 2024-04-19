using System.Runtime.Serialization;

public sealed class ShortTask : Task
{
    public bool IsRepeated { get; set; }

    public ShortTask() { }

    public ShortTask(string title, string content,
        DateTime notiTime, bool isCompleted,
        bool isImportant, bool isRepeated, DateTime endTime = new DateTime())
        : base(title, content, notiTime, isCompleted, isImportant, endTime)
    {
        IsRepeated = isRepeated;
    }

    public ShortTask(SerializationInfo info, StreamingContext context)
    : base(info, context)
    {
        IsRepeated = info.GetBoolean("IsRepeated");
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("IsRepeated", IsRepeated);
    }

    public void ToggleRepeated()
    {
        ((ShortTaskService)service).ToggleRepeated(this);
    }

}
