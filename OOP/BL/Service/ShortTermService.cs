public class ShortTermService : TaskService
{
    private ShortTermService() { }
    public ShortTermService _ShortTermService
    {
        get
        {
            if (_taskService == null)
            {
                _taskService = new ShortTermService();
            }
            return (ShortTermService)_taskService;
        }
    }

}
