﻿public class LongTerm : Task
{
    private DateTime from;
    public DateTime From { get { return from; } set { from = value; } }
    private DateTime to;

    public DateTime To { get { return to; } set { to = value; } }
    public IList<Detail> Details { get; set; }

    public LongTerm() { }
    public LongTerm(string title, string content,
        DateTime notiTime, DateTime from, DateTime to, bool isCompleted,
        bool isImportant, bool isRepeated, IList<Detail> details)
    {
        Title = title;
        Content = content;
        NotiTime = notiTime;
        From = from;
        To = to;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
        Details = details;
    }
}
