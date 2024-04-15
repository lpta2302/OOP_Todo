using System.ComponentModel;

public sealed class MyFakeData
{
    private static string[] habits = { "Đánh răng thôi", "Rửa mặt", "Đi học", "Thức dậy" };
    private static string[] contents = { "Buổi sáng phải thức dậy thôi nào", "Hello World", "Đến giờ đi học rồi", "IDK" };
    public static void CreateShortTask()
    {
        Task shortTerm;
        Random r = new Random();

        for (int i = 0; i < 10; i++)
        {
            ShortTermCRUD.Instance.Create(
                new object[]{
                    habits[r.Next(0, 4)],
                    contents[r.Next(0, 4)],
                    DateTime.Now,
                    false,
                    r.Next(0, 2) == 0 ? false : true,
                    r.Next(0, 5) == 0 ? true : false}
            );
        }
        for (int i = 0; i < 10; i++)
        {
            ShortTermCRUD.Instance.Create(
                new object[]{
                    habits[r.Next(0, 4)],
                    contents[r.Next(0, 4)],
                    DateTime.Now.AddDays(r.Next(0, 120)),
                    false,
                    r.Next(0, 2) == 0 ? false : true,
                    r.Next(0, 5) == 0 ? true : false}
            );
        }

    }
    public static void CreatePlan()
    {
        Plan plan = new Plan()
        {
            Name = "Learn Toeic"
        };

        LongTermCRUD.Instance.Create(
            new object[]{
                "Thu thập yêu cầu và phân tích",
            plan.Id,
            "Thực hiện bước đầu là thu thập và phân tích dự án nhầm phát triển dự án theo đúng yêu cầu khách hàng",
            new DateTime(),
            DateTime.Now,
            DateTime.Now.AddDays(7),
            false, false, false,
            new List<Detail>(){
                new Detail("Phân tích tính khả thôi"),
                new Detail("Thu thập yêu cầu khách hàng"),
                new Detail("Phân tích yêu cầu"),
                new Detail("Xác nhận yêu cầu")
            }
            }
        );
        LongTermCRUD.Instance.Create(
            new object[]{
                "Thiết kế",
            plan.Id,
            "Thực hiện bước đầu thiết kế",
            new DateTime(),
            DateTime.Now.AddDays(8),
            DateTime.Now.AddDays(15),
            false, false, false,
            new List<Detail>(){
                new Detail("Thiết kế hệ thống (System Design)"),
                new Detail("Thiết kế Database"),
                new Detail("Thiết kế Model"),
                new Detail("Thiết kế giao diện")
            }
            }
        );
        LongTermCRUD.Instance.Create(
            new object[]{
                "Thực hiện code (Implementation)",
            plan.Id,
            "Bắt đầu thực hiện dự án",
            new DateTime(),
            DateTime.Now.AddDays(16),
            DateTime.Now.AddDays(39),
            false, false, false,
            new List<Detail>(){
                new Detail("Chuẩn bị môi trường phát triển"),
                new Detail("Xác định các nhiệm vụ"),
                new Detail("Triển khai mã nguồn"),
                new Detail("Hoàn thành bản test")
            }
            }
        );
        LongTermCRUD.Instance.Create(
            new object[]{
                "Testing",
            plan.Id,
            "Thực hiện kiểm thử dự án",
            new DateTime(),
            DateTime.Now.AddDays(40),
            DateTime.Now.AddDays(44),
            false, false, false,
            new List<Detail>(){
                new Detail("Xác định yêu cầu kiểm thử"),
                new Detail("Unit Test"),
                new Detail("Integration Testing"),
                new Detail("System Testing"),
                new Detail("User Acceptance Testing"),
                new Detail("Bug fixing and retesting")
            }
            }
        );
        LongTermCRUD.Instance.Create(
            new object[]{
                "Deployment",
                plan.Id,
                "Triển khai dự án cho khách hàng",
                new DateTime(),
                DateTime.Now.AddDays(45),
                DateTime.Now.AddDays(45),
                false, false, false,
                new List<Detail>(){
                    new Detail("Chuẩn bị môi trường triển khai"),
                    new Detail("Thực hiện láp đặt thiết bị"),
                    new Detail("Integration Testing"),
                    new Detail("System Testing"),
                    new Detail("User Acceptance Testing"),
                    new Detail("Bug fixing and retesting")
                }
            }
        );
    }

    public static void Init()
    {
        CreateShortTask();
        CreatePlan();
    }
}
