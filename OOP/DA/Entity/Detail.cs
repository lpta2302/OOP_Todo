public sealed class Detail
{
    public string Id { get; }
    public string Content { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? Time { get; set; }
    public Detail(string content = "", bool isCompleted = false)
    {
        Id = Generator.GenerateId();
        Content = content;
        IsCompleted = isCompleted;
    }
    public void ToggleCompletion()
    {
        IsCompleted = !IsCompleted;
    }
}
