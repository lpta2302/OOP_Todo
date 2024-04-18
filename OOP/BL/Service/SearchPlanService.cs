public class SearchPlanService
{
    private SearchPlanService() { }
    public static List<Plan>? Search(object key, IList<Plan>? plans = null)
    {
        if (plans == null)
            plans = GlobalData.CurrentPlans;

        List<Plan> res = new List<Plan>();

        foreach (Plan plan in plans)
        {

            if (plan.Name.Contains((string)key))
            {
                res.Add(plan);
            }
        }

        return res;
    }
}
