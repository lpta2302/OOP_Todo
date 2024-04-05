public abstract class Task
{
    public int Id { get; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime NotiTime { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsImportant { get; set; }
    public bool IsRepeated { get; set; }
    public Tag TagType { get; set; }
    public Task(){
        Id = GlobalData.CurrentTasks.Count;
        CreatedAt = DateTime.Now;
    }
}