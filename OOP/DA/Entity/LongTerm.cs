using System.ComponentModel.DataAnnotations;

public class LongTerm : Task
{
    public string PlanId { get; set; }
    private DateTime from;
    public DateTime From { get { return from; } set { from = value; } }
    private DateTime to;
    public DateTime To { get { return to; } set { to = value; } }
    public IList<Detail> Details { get; set; }

    public LongTerm()
    {
        Details = new List<Detail>();
    }

    public LongTerm(string title, string planId, string content,
        DateTime notiTime, DateTime from, DateTime to, bool isCompleted,
        bool isImportant, bool isRepeated, IList<Detail> details, DateTime? endTime = null)
        : base(title, content, notiTime, isCompleted, isImportant, isRepeated, endTime)
    {
        PlanId = planId;
        From = from;
        To = to;
        Details = details;
    }
    public override string ToString()
    {
        return $"{Id},{PlanId},{Title} LongTerm";
    }
}
