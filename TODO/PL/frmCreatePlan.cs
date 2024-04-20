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
    public partial class frmCreatePlan : Form
    {
        private Plan plan;
        bool isCreating = true;
        public frmCreatePlan(Plan plan = null)
        {
            InitializeComponent();

            if (plan == null)
            {
                isCreating = true;
                this.plan = GlobalData.CurrentPlan;
            }
            else
            {
                isCreating = false;
                this.plan = plan;
            }
            LoadForm();
        }

        private void LoadForm()
        {
            textBox2.Text = plan.Name;
            for (int i = 0; i < plan.Tasks.Count; i++)
            {
                ListViewItem item = new ListViewItem("" + (i + 1));
                LongTask task = (LongTask)Util.FindTask(plan.Tasks[i].Id);
                item.SubItems.Add(task.Title);
                item.SubItems.Add(task.Details.Count.ToString());
                listView1.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new frmCreate(frmCreate.CreateType.LongTerm).ShowDialog();
            Close();
        }

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
            new frmCreatePlan().ShowDialog();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPlanS().ShowDialog();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            plan.Name = textBox2.Text;
            if (isCreating)
            {
                PlanCRUD.Instance.Create(plan);
            }
            else
                PlanCRUD.Instance.Update(plan);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Hide();
            new frmCreate(frmCreate.CreateType.LongTerm, Util.FindTask(plan.Tasks[listView1.SelectedIndices[0]].Id));
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            plan.Tasks.RemoveAt(listView1.SelectedIndices[0]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(isCreating)
                GlobalData.CurrentPlan.Name = textBox2.Text;
        }
    }
}
