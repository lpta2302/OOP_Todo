public class LongTerm : Task
{
    public string PlanId { get; set; }
    private DateTime from;
    public DateTime From { get { return from; } set { from = value; } }
    private DateTime to;
    public DateTime To { get { return to; } set { to = value; } }
    public IList<Detail> Details { get; set; }

    public LongTerm() { }
    public LongTerm(string title, string planId, string content,
        DateTime notiTime, DateTime from, DateTime to, bool isCompleted,
        bool isImportant, bool isRepeated, IList<Detail> details)
    {
        Title = title;
        Content = content;
        PlanId = planId;
        NotiTime = notiTime;
        From = from;
        To = to;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
        Details = details;
    }
    public override string ToString()
    {
        return $"{Id},{PlanId},{Title} LongTerm";
    }
}
