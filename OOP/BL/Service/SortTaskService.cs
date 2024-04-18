public class SortTaskService
{
    private SortTaskService() { }
    private static SortTaskService instance = new SortTaskService();
    public static SortTaskService Instance
    {
        get { return instance; }
    }
    public enum SortType
    {
        ASCENDING, DESCENDING
    }
    private delegate bool SortDelegate(Task task1, Task task2);
    public List<Task>? Sort(IList<Task> tasks, SortType sortType = SortType.ASCENDING)
    {
        if (tasks == null)
            tasks = GlobalData.CurrentTasks;

        List<Task> res = new List<Task>(tasks);
        SortDelegate SortDelegate = CreateSortDel(sortType);

        for (int i = 0; i < res.Count - 1; i++)
        {
            Task minTask = res[i];
            int ilast = i;
            for (int j = i + 1; j < res.Count; j++)
            {
                if (SortDelegate(minTask, res[j]))
                {
                    minTask = res[j];
                    ilast = j;
                }
            }
            if (ilast == i)
                continue;
            Task tmp = res[i];
            res[i] = minTask;
            res[ilast] = tmp;
        }

        return res;
    }
    private SortDelegate CreateSortDel(SortType sortType)
    {

        switch (sortType)
        {
            case SortType.ASCENDING:
                return SortAscending;
            case SortType.DESCENDING:
                return SortDescending;
        }
        return SortAscending;

    }
    private bool SortAscending(Task task1, Task task2)
    {
        return task1 > task2;
    }
    private bool SortDescending(Task task1, Task task2)
    {
        return task1 < task2;
    }
}
