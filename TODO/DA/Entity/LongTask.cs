using System.Runtime.Serialization;

public class LongTask : Task, IProgressService
{
    public string PlanId { get; set; }

    public override DateTime NotiTime
    {
        get
        {
            if (DateOnly.FromDateTime(notiTime) == DateOnly.FromDateTime(DateTime.MinValue))
            {
                if (fromDate <= DateOnly.FromDateTime(DateTime.Now) && toDate >= DateOnly.FromDateTime(DateTime.Now))
                {
                    return DateTime.Now;
                }
            }
            return notiTime;
        }
    }
    private DateOnly fromDate;
    public DateOnly FromDate { get { return fromDate; } set { fromDate = value; } }
    private DateOnly toDate;
    public DateOnly ToDate { get { return toDate; } set { toDate = value; } }
    private string rating;
    public string Rating
    {
        get { return rating; }
        set
        {
            if (IsCompleted && Constant.Ratings.Contains(value))
                rating = value;
        }
    }
    public IList<Detail> Details { get; set; }

    public LongTask()
    {
        PlanId = "";
        Details = new List<Detail>();
    }

    public LongTask(SerializationInfo info, StreamingContext context)
    : base(info, context)
    {
        PlanId = info.GetString("PlanId")!;
        FromDate = (DateOnly)info.GetValue("FromDate", typeof(DateOnly))!;
        ToDate = (DateOnly)info.GetValue("ToDate", typeof(DateOnly))!;
        Details = (List<Detail>)info.GetValue("Details", typeof(List<Detail>))!;
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("PlanId", PlanId);
        info.AddValue("FromDate", FromDate);
        info.AddValue("ToDate", ToDate);
        info.AddValue("Details", Details);
    }

    public float CalculateCurrentProgress()
    {
        int count = 0;

        foreach (Detail detail in Details)
        {
            if (detail.IsCompleted)
                count++;
        }

        return (float)Math.Round(1.0 * count / Details.Count, 2);
    }

    public LongTask(string title, string planId, string content,
        DateTime notiTime, DateOnly from, DateOnly to, bool isCompleted,
        bool isImportant, IList<Detail> details, DateTime endTime = new DateTime())
        : base(title, content, notiTime, isCompleted, isImportant, endTime)
    {
        PlanId = planId;
        FromDate = from;
        ToDate = to;
        Details = details;
    }

    public override string ToString()
    {
        return
            $"{Id}, {Title}, {NotiTime}, from: {FromDate}, to: {ToDate}, comp:{IsCompleted}, imp:{IsImportant}, {GetType()}";
    }
}
