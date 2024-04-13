public class PlanCRUD : CRUD<Plan>
{
    private static readonly PlanCRUD instance;

    public static PlanCRUD Instance
    {
        get
        {
            if (instance == null)
                return new PlanCRUD();
            return instance;
        }
    }

    private PlanCRUD() { }

    public Plan? Create(object[] args)
    {
        Plan newPlan = new Plan(
            (List<TaskRef>)args[0],
            (string)args[1]
        );

        GlobalData.CurrentPlans.Add(newPlan);

        EntityManager<Plan>.Save(GlobalData.CurrentPlans);

        return newPlan;
    }

    public Plan Create(Plan newTask)
    {
        GlobalData.CurrentPlans.Add(newTask);

        EntityManager<Plan>.Save(GlobalData.CurrentPlans);

        return newTask;
    }

    public Plan? Delete(object i)
    {
        Plan? deletedPlan = Util.FindPlan((string)i);
        if (deletedPlan == null)
            throw new Exception("Không tìm thấy plan nào");

        GlobalData.CurrentPlans.Remove(deletedPlan);

        EntityManager<Plan>.Save(GlobalData.CurrentPlans);

        return deletedPlan;
    }

    public Plan? Read(object i)
    {
        Plan? plan = Util.FindPlan((string)i);

        if (plan == null)
            throw new Exception("Không tìm thấy plan");

        if (plan.Tasks.Count == 0)
            return plan;

        return plan;
    }

    public Plan? Update(Plan newPlan)
    {
        Plan? plan = Util.FindPlan(newPlan.Id);

        if (plan == null)
            throw new Exception("Không tìm thấy Plan");

        plan = newPlan;
        EntityManager<Plan>.Save(GlobalData.CurrentPlans);

        return plan;
    }
}
