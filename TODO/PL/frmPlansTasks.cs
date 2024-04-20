using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO.PL
{
    public partial class frmPlansTasks : Form
    {
        IList<Task> tasks = new List<Task>();
        Plan plan;
        public frmPlansTasks(Plan plan)
        {
            InitializeComponent();
            LoadTaskFormPlansTasks();
            this.plan = plan;
            label6.Text = plan.CalculateCurrentProgress().ToString() + "%";
            foreach (TaskRef task in this.plan.Tasks)
            {
                tasks.Add(SearchTaskService.Instance.Search(task.Id, SearchTaskService.SearchType.ByID)[0]);
            }
            flowLayoutPanel1.Controls.Clear();
            Renderer.RenderListTask(tasks, flowLayoutPanel1, "", this);
            label4.Text = plan.Name;
        }
        private void LoadTaskFormPlansTasks()
        {

        }
        #region transform
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMyDay(frmMyDay.MyDayType.Myday).ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMyDay(frmMyDay.MyDayType.Importance).ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPlan().ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMyDay(frmMyDay.MyDayType.AllTasks).ShowDialog();
            Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Hide();
            new frmCreateLobby().ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPlanS().ShowDialog();
            Close();
        }
        #endregion

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            label6.Text = plan.CalculateCurrentProgress().ToString() + "%";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPlansTasks(plan).ShowDialog();
            Close();
        }
    }
}
