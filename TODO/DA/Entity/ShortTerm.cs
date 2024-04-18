using System.Runtime.Serialization;

public sealed class ShortTerm : Task
{
    public ShortTerm(string title, string content,
        DateTime notiTime, bool isCompleted,
        bool isImportant, bool isRepeated)
        : base(title, content, notiTime, isCompleted, isImportant, isRepeated)
    { }
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }
    public ShortTerm() { }
}
