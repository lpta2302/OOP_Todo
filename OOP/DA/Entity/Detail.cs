public sealed class Detail
{
    public string Id { get; }
    public string Content { get; set; }
    public string Rating
    {
        get { return Rating; }
        set
        {
            if (IsCompleted && Constant.Ratings.Contains(value))
                Rating = value;
        }
    }
    public bool IsCompleted { get; set; }
    public DateTime? Time { get; set; }
    public Detail(string content = "", string rating = "", bool isCompleted = false)
    {
        Id = Generator.GenerateId();
        Content = content;
        Rating = rating;
        IsCompleted = isCompleted;
    }
    public void ToggleCompletion()
    {
        IsCompleted = !IsCompleted;
    }
}
