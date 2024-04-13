using System.Runtime.Serialization;

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
        PlanId = "";
        Details = new List<Detail>();
    }
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("PlanId", PlanId);
        info.AddValue("From", From);
        info.AddValue("To", To);
        info.AddValue("Details", Details);
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
}
