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
        Plan plan;  
        public frmCreatePlan()
        {
            InitializeComponent();
            if(GlobalData.CurrentPlan == null)
                GlobalData.CurrentPlan = new Plan();
            plan = GlobalData.CurrentPlan;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new frmCreate(frmCreate.CreateType.LongTerm);
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
    }
}
