using System.Runtime.Serialization;

public class ShortTerm : Task
{
    public ShortTerm(string title, string content,
        DateTime notiTime, bool isCompleted,
        bool isImportant, bool isRepeated)
    {
        Title = title;
        Content = content;
        NotiTime = notiTime;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
    }
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }
    public ShortTerm() { }
}
