public class SearchTask
{
    public enum SearchType { ByID, ByTitle, ByNotiDate }

    private delegate void SearchDel(object key, Task task, ref bool accumulate);

    public List<Task>? Search(object key, SearchType searchType, IList<Task>? tasks = null)
    {
        if (tasks == null)
            tasks = GlobalData.CurrentTasks;

        List<Task> res = new List<Task>();
        SearchDel searchDel = CreateSearchDel(searchType)!;

        foreach (Task item in tasks)
        {
            bool checker = true;
            searchDel(key, item, ref checker);

            if (checker)
            {
                res.Add(item);
            }
        }

        return res;
    }

    //Create SearchDelegate by type
    private SearchDel? CreateSearchDel(SearchType searchType)
    {
        SearchDel? searcher = null;

        switch (searchType)
        {
            case SearchType.ByID:
                searcher += SearchById;
                break;
            case SearchType.ByTitle:
                searcher += SearchByTitle;
                break;
            case SearchType.ByNotiDate:
                searcher += SearchByNotiDate;
                break;
            default: return null;
        }

        return searcher;
    }
    //Search Term
    private void SearchById(object key, Task task, ref bool accumulate)
    {
        accumulate = task.Id.Contains((string)key) ? accumulate && true : false;
    }
    private void SearchByTitle(object key, Task task, ref bool accumulate)
    {
        accumulate = task.Title.Contains((string)key) ? accumulate && true : false;
    }
    private void SearchByNotiDate(object key, Task task, ref bool accumulate)
    {
        DateOnly keyDate = TypeConverter.Convert<object, DateOnly>(key);

        accumulate =
            accumulate &&
            task.NotiTime.Day == keyDate.Day &&
            task.NotiTime.Month == keyDate.Month &&
            task.NotiTime.Year == keyDate.Year;
    }
}
