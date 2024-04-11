using System.ComponentModel;

public class MyFakeData
{
    public static void CreateShortTask()
    {
        Task task = new ShortTerm("Thức dậy nào",
                "Buổi sáng rồi phải thức dậy thôi nào",
                DateTime.Now, false, false, false);
        List<Task> tasks = new List<Task>(){
            task,
            new ShortTerm("Đánh răng thôi",
                "Thức dậy rồi đánh răng thôi nào",
                DateTime.Now.AddHours(1), false, false, false),
            new LongTerm("Learn Vocabulary","I have to learn vocabulary",Generator.GenerateId(),
                DateTime.Now,DateTime.Now,DateTime.Now.AddDays(30),false,false,false, new List<Detail>())
        };
        EntityManager<Task>.Save(tasks);
    }
    public static void CreatePlan()
    {
        EntityManager<Plan> entityManager = new EntityManager<Plan>();

        Plan plan = new Plan()
        {
            Name = "Learn Toeic",
            Tasks = new List<TaskRef>()
            {
                new TaskRef(Generator.GenerateId())
            }
        };
        EntityManager<Plan>.Save(new List<Plan>() { plan });
    }

    public static void Init()
    {
        CreatePlan();
        CreateShortTask();
    }
}
