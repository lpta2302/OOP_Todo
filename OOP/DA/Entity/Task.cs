using System.Numerics;
using System.Runtime.Serialization;

public abstract class Task : ISerializable
{
    public string Id { get; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; }
    protected DateTime notiTime;
    public virtual DateTime NotiTime
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
    private DateTime endTime;
    public DateTime EndTime
    {
        get
        {
            return endTime;
        }
        set
        {
            endTime = value;
        }
    }
    public static bool operator >(Task task1, Task task2)
    {
        if (task1.GetType().IsAssignableTo(typeof(LongTerm)) &&
            task2.GetType().IsAssignableTo(typeof(LongTerm)) &&
            task1.NotiTime == task2.NotiTime)
        {
            LongTerm long1 = (LongTerm)task1;
            LongTerm long2 = (LongTerm)task2;
            return long1.FromDate > long2.FromDate;
        }


        return task1.NotiTime > task2.NotiTime;
    }
    public static bool operator <(Task task1, Task task2)
    {
        if (task1.GetType().IsAssignableTo(typeof(LongTerm)) &&
            task2.GetType().IsAssignableTo(typeof(LongTerm)) &&
            task1.NotiTime == task2.NotiTime)
        {
            LongTerm long1 = (LongTerm)task1;
            LongTerm long2 = (LongTerm)task2;
            return long1.FromDate < long2.FromDate;
        }


        return task1.NotiTime < task2.NotiTime;
    }
    public bool IsNotificated { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsImportant { get; set; }
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
    }
    private void InjectDependencies()
    {
        service =
            GetType().IsAssignableTo(typeof(ShortTerm)) ?
            ShortTermService.Instance :
            LongTermService.Instance;
        crud =
            GetType().IsAssignableTo(typeof(ShortTerm)) ?
            ShortTermCRUD.Instance :
            LongTermCRUD.Instance;
    }
    public Task(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("Id")!;
        Title = info.GetString("Title")!;
        Content = info.GetString("Content")!;
        CreatedAt = info.GetDateTime("CreatedAt");
        NotiTime = info.GetDateTime("NotiTime");
        EndTime = info.GetDateTime("EndTime");
        IsCompleted = info.GetBoolean("IsCompleted");
        IsImportant = info.GetBoolean("IsImportant");
        InjectDependencies();
    }
    protected Task()
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Content = "";
        Title = "";
        IsCompleted = false;
        IsImportant = false;
        InjectDependencies();
    }

    protected Task(string title, string content, DateTime notiTime, bool isCompleted, bool isImportant, DateTime endTime = new DateTime())
    {
        Id = Generator.GenerateId();
        CreatedAt = DateTime.Now;
        Title = title;
        Content = content;
        NotiTime = notiTime;
        EndTime = endTime;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        InjectDependencies();
    }

    public Task Delete()
    {
        return crud.Delete(Id)!;
    }

    public Task Update()
    {
        return crud.Update(this)!;
    }

    public void ToggleIsNotificated()
    {
        service.ToggleIsNotificated(this);
    }
    public void ToggleImportant()
    {
        service.ToggleImportant(this);
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
            $"{Id}, {Title}, {NotiTime}, comp:{IsCompleted}, imp:{IsImportant}, {GetType()}";
    }
}