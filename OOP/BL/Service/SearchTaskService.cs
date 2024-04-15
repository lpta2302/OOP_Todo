public class SearchTaskService
{
    private SearchTaskService() { }
    private static SearchTaskService instance;
    public static SearchTaskService Instance
    {
        get
        {
            if (instance == null)
                instance = new SearchTaskService();
            return instance;
        }
    }
    public enum SearchType { ByID, ByTitle, ByNotiDate }

    private delegate bool SearchDel(object key, Task task);

    public List<Task>? Search(object key, SearchType searchType, IList<Task>? tasks = null)
    {
        if (tasks == null)
            tasks = GlobalData.CurrentTasks;

        List<Task> res = new List<Task>();
        SearchDel searchDel = CreateSearchDel(searchType)!;

        foreach (Task item in tasks)
        {

            if (searchDel(key, item))
            {
                res.Add(item);
            }
        }

        return res;
    }

    //Create SearchDelegate by type
    private SearchDel? CreateSearchDel(SearchType searchType)
    {
        switch (searchType)
        {
            case SearchType.ByID:
                return new SearchDel(SearchById);
            case SearchType.ByTitle:
                return new SearchDel(SearchByTitle);
            case SearchType.ByNotiDate:
                return new SearchDel(SearchByNotiDate);
            default: return null;
        }
    }
    //Search Term
    private bool SearchById(object key, Task task)
    {
        return task.Id.Contains(key.ToString()!) ? true : false;
    }
    private bool SearchByTitle(object key, Task task)
    {
        return task.Title.ToLower().Contains(((string)key).ToLower()) ? true : false;
    }
    private bool SearchByNotiDate(object key, Task task)
    {
        DateTime keyDate = TypeConverter.Convert<object, DateTime>(key);

        return
            task.NotiTime.Day == keyDate.Day &&
            task.NotiTime.Month == keyDate.Month &&
            task.NotiTime.Year == keyDate.Year;
    }
}
