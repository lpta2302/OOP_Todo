public class Plan
{

    public int Id { get; }

    public DateTime CreatedAt { get; }

    public IList<LongTerm> tasks { get; set; }

    public Plan(IList<LongTerm> tasks)
    {
        CreatedAt = DateTime.Now;
        Id = GlobalData.CurrentPlans.Count;
        this.tasks = tasks;
    }
}
