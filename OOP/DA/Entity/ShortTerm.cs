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
    public override string ToString()
    {
        return $"{Id},{Title}";
    }
}
