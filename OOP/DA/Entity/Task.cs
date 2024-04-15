using System.Runtime.Serialization;

public abstract class Task : ISerializable
{
    public string Id { get; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; }
    private DateTime notiTime;
    public DateTime NotiTime
    {
        get
        {
            return notiTime;
        }
        set
        {
            if (value >= DateTime.Now.AddSeconds(-60))
                notiTime = value;
        }
    }
    private DateTime? endTime;
    public DateTime? EndTime
    {
        get
        {
            return endTime;
        }
        set
        {
            if (value == null || value >= notiTime)
                endTime = value;
        }
    }
    public bool IsCompleted { get; set; }
    public bool IsImportant { get; set; }
    public bool IsRepeated { get; set; }
    protected ITaskService service;
    protected TaskCRUD crud;
    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Id", Id);
        info.AddValue("Title", Title);
        info.AddValue("Content", Content);
        info.AddValue("CreatedAt", CreatedAt);
        info.AddValue("NotiTime", NotiTime);
        info.AddValue("EndTime", EndTime);
        info.AddValue("IsCompleted", IsCompleted);
        info.AddValue("IsImportant", IsImportant);
        info.AddValue("IsRepeated", IsRepeated);
    }
    protected Task()
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Content = "";
        Title = "";
        IsCompleted = false;
        IsImportant = false;
        IsRepeated = false;
        service =
            GetType().IsAssignableTo(typeof(ShortTerm)) ?
            ShortTermService.Instance :
            LongTermService.Instance;
    }

    protected Task(string title, string content, DateTime notiTime, bool isCompleted, bool isImportant, bool isRepeated, DateTime? endTime = null)
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Title = title;
        Content = content;
        NotiTime = notiTime;
        EndTime = endTime;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
        service =
            GetType().IsAssignableTo(typeof(ShortTerm)) ?
            ShortTermService.Instance :
            LongTermService.Instance;
    }

    public Task Create()
    {
        return crud.Create(this);
    }
    public Task Delete()
    {
        return crud.Delete(Id)!;
    }

    public Task Update()
    {
        return crud.Update(this)!;
    }

    public void ToggleImportant()
    {
        service.ToggleBoolProp(this, ITaskService.BoolProp.IsImportant);
    }
    public void ToggleRepeated()
    {
        service.ToggleBoolProp(this, ITaskService.BoolProp.IsRepeated);
    }
    public bool CheckTime()
    {
        return service.IsTime(this);
    }

    public void CompleteTask()
    {
        service.CompleteTask(this);
    }
    public override string ToString()
    {
        return
            $"{Id}, {Title}, {NotiTime}, comp:{IsCompleted}, imp:{IsImportant}, rep:{IsRepeated}, {GetType()}";
    }
}