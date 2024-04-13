public class LongTerm : Task, TaskManager
{
    private class Detail
    {
        public string[] ratings { get; } = { "Unacceptable", "Unsatisfactory", "Inadequate", "Sufficient", "Proficient", "Excellent", "Outstanding" };
        public int Id { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Rating
        {
            get { return Rating; }
            set
            {
                if (ratings.Contains(value))
                    Rating = value;
            }
        }
        public bool IsCompleted { get; set; }
        public DateTime Time { get; set; }
    }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public LongTerm(string title, string content,
        DateTime notiTime, DateTime from, DateTime to, bool isCompleted,
        bool isImportant, bool isRepeated, Tag tagType)
    {
        Title = title;
        Content = content;
        NotiTime = notiTime;
        From = from;
        To = to;
        IsCompleted = isCompleted;
        IsImportant = isImportant;
        IsRepeated = isRepeated;
        TagType = tagType;
    }
}
