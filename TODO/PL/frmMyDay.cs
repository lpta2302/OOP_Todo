using OOP.BL;
using System.Globalization;
using TODO.PL;

namespace TODO
{
    public partial class frmMyDay : Form
    {
        private FilterTaskService filter = FilterTaskService.Instance;
        private SearchTaskService search = SearchTaskService.Instance;
        private IList<Task> tasks;
        public frmMyDay()
        {
            InitializeComponent();
            tasks = search.Search(DateTime.Now, SearchTaskService.SearchType.ByNotiDate)!;
            Renderer.RenderListTask(tasks, flowLayoutPanel1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PerformDay();
        }
        public void PerformDay()
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            filter.DoFilter(FilterTaskService.TaskType.IsImportance);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}