public class LongTerm : Task
{
    public DateTime From { get; set; }

    public DateTime To { get; set; }
    
    public LongTerm(string title, string content,
        DateTime notiTime, DateTime from, DateTime to, bool isCompleted,
        bool isImportant, bool isRepeated)
    {
        Title = title;
        Content = content;
        NotiTime = notiTime;
        From = from;
        To = to;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
    }
}
