public class SortTaskService
{
    private SortTaskService() { }
    private static SortTaskService instance;
    public static SortTaskService Instance
    {
        get
        {
            if (instance == null)
                instance = new SortTaskService();
            return instance;
        }
    }
    public enum SortType { ByNotiTime, ByStartDate }

    private delegate bool SortDel(Task task1, Task task2);

    public List<Task>? Sort(IList<Task> tasks, SortType sortType)
    {
        if (tasks == null)
            tasks = GlobalData.CurrentTasks;

        List<Task> res = new List<Task>();
        SortDel sortDel = CreateSortDel(sortType)!;

        for (int i = 0; i < tasks.Count - 1; i++)
        {
            Task minTask = tasks[i];
            int ilast = i;
            for (int j = i + 1; j < tasks.Count; j++)
            {
                if (sortDel(minTask, tasks[j]))
                {
                    minTask = tasks[j];
                    ilast = j;
                }
            }
            if (ilast == i)
                continue;
            Task tmp = tasks[i];
            tasks[i] = minTask;
            tasks[ilast] = tmp;
        }

        return res;
    }

    //Create SortDelegate by type
    private SortDel? CreateSortDel(SortType searchType)
    {
        switch (searchType)
        {
            case SortType.ByNotiTime:
                return new SortDel(SortByNotiTime);
            case SortType.ByStartDate:
                return new SortDel(SortByStartDate);
            default: return null;
        }
    }
    //Sort Term
    private bool SortByNotiTime(Task task1, Task task2)
    {
        return task1.NotiTime >= task2.NotiTime;
    }
    private bool SortByStartDate(Task _task1, Task _task2)
    {
        if (_task1 is LongTerm && _task2 is LongTerm)
        {
            LongTerm task1 = TypeConverter.Convert<Task, LongTerm>(_task1)!;
            LongTerm task2 = TypeConverter.Convert<Task, LongTerm>(_task2)!;
            return task1.From >= task2.From;
        }
        else return false;
    }
}
