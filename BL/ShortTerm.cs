public class ShortTerm : Task, TaskManager
{

    public ShortTerm(string title, string content,
        DateTime notiTime, bool isCompleted,
        bool isImportant, bool isRepeated, Tag tagType)
    {
        Title = title;
        Content = content;
        NotiTime = notiTime;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
        TagType = tagType;
    }
    public override string ToString()
    {
        return $"{Id},{Title}";
    }
}
