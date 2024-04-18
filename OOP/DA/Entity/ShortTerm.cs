using System.Runtime.Serialization;

public sealed class ShortTerm : Task
{
    public bool IsRepeated { get; set; }

    public ShortTerm() { }

    public ShortTerm(string title, string content,
        DateTime notiTime, bool isCompleted,
        bool isImportant, bool isRepeated, DateTime endTime = new DateTime())
        : base(title, content, notiTime, isCompleted, isImportant, endTime)
    {
        IsRepeated = isRepeated;
    }

    public ShortTerm(SerializationInfo info, StreamingContext context)
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
        ((ShortTermService)service).ToggleRepeated(this);
    }

}
