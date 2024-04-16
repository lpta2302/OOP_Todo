using OOP.BL;
using System.Globalization;
using TODO.PL;

namespace TODO
{
    public partial class frmMyDay : Form
    {
        private FilterTaskService filter = FilterTaskService.Instance;
        private SearchTaskService search = SearchTaskService.Instance;
        private SortTaskService sort = SortTaskService.Instance;
        private IList<Task> tasks;
        public frmMyDay()
        {
            InitializeComponent();
            GetMyDay();
            GetTaskNotification();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PerformDay();

        }
        private void PerformDay()
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("dddd, MMMM - dd", culture);
            label9.Text = formattedTime;
        }
        private void ToggleImportance(object sender, EventArgs e)
        {
            int index = (int)((Control)sender).Tag!;
            tasks[index].ToggleImportant();
            ((PictureBox)sender).Image = tasks[index].IsImportant ? Properties.Resources.star_fill : Properties.Resources.star;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetMyDay();
        }
        public void GetMyDay()
        {
            tasks = search.Search(DateTime.Now, SearchTaskService.SearchType.ByNotiDate)!;
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetImportance();
        }
        private void GetImportance()
        {
            tasks = filter.DoFilter(FilterTaskService.TaskType.IsImportance);
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }
        private void GetTaskNotification()
        {
            tasks = sort.Sort(tasks, SortTaskService.SortType.ByNotiTime);
            Renderer.RenderListTaskNotification(tasks, flowLayoutPanel2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SearchTask();
        }
        private void SearchTask()
        {
            string textSearch = textBox1.Text;
            try
            {
                if (double.TryParse(textSearch, out double value))
                {
                    tasks = search.Search(textSearch, SearchTaskService.SearchType.ByID);
                    Renderer.RenderListTask(tasks, flowLayoutPanel1);
                }
                else if (textSearch is string)
                {
                    tasks = search.Search(textSearch, SearchTaskService.SearchType.ByTitle);
                    Renderer.RenderListTask(tasks, flowLayoutPanel1);
                }
            }
            catch
            {
                return;
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetAlert();
        }
        private void GetAlert()
        {
            tasks = filter.DoFilter(FilterTaskService.TaskType.ShortTerm);
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetMiniTask();
        }
        private void GetMiniTask()
        {
            tasks = filter.DoFilter(FilterTaskService.TaskType.LongTerm);
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetAllTask();
        }
        private void GetAllTask()
        {
            GetMyDay();
            GetMiniTask();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetCompleteTask();
        }
        private void GetCompleteTask()
        {
            tasks = filter.DoFilter(FilterTaskService.TaskType.IsComplete);
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GetUnCompleteTask();
        }
        private void GetUnCompleteTask()
        {
            tasks = filter.DoFilter(FilterTaskService.TaskType.IsUnComplete);
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }
    }
}