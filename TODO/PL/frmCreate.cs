using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO.PL
{
    public partial class frmCreate : Form
    {
        private bool IsUpdate = false;
        private Task task;
        public enum CreateType
        {
            ShortTerm,
            LongTerm
        }
        public frmCreate(CreateType createType, Task task = null)
        {
            InitializeComponent();
            switch (createType)
            {
                case CreateType.ShortTerm:
                    this.task = new ShortTask();
                    panel5.Visible = false;
                    listView1.Visible = false;
                    panel3.Visible = false;
                    break;
                case CreateType.LongTerm:
                    this.task = new LongTask();

                    break;
            }
            if (task != null)
            {
                this.task = task;
                IsUpdate = true;
                Load(task);
            }
        }
        private void Load(Task task)
        {
            txtTitle.Text = task.Title;
            txtNote.Text = task.Content;
            dtpkStartTaskTime.Value = task.NotiTime;
            tpkStartTaskTime.Value = task.NotiTime;
            dtpkEndTaskTime.Value = task.EndTime;
            tpkEndTaskTime.Value = task.EndTime;
            if (task is LongTask)
            {
                LongTask temp = (LongTask)task;
                dtpkFromDay.Value = new DateTime(temp.FromDate.Year, temp.FromDate.Month, temp.FromDate.Day);
                dtpkToday.Value = new DateTime(temp.FromDate.Year, temp.FromDate.Month, temp.FromDate.Day);
            }
            if (IsUpdate)
            {
                button7.Text = "Update";
                label2.Text = "Update Task";
            }
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
            new frmCreate(frmCreate.CreateType.ShortTerm).ShowDialog();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                task.Update();
            }
            else
            {
                if (task is ShortTask)
                {
                    ShortTaskCRUD.Instance.Create(task);
                }
                else
                {
                    LongTaskCRUD.Instance.Create(task);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPlanS().ShowDialog();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            task.ToggleImportant();
            if (task.IsImportant)
            {
                pic.Image = Properties.Resources.star_fill;
            }
            else
            {
                pic.Image = Properties.Resources.star;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShortTask t = (ShortTask)task;
            PictureBox pic = (PictureBox)sender;
            t.ToggleRepeated();
            if (t.IsRepeated)
            {
                pic.BackColor = Color.AliceBlue;
            }
            else
            {
                pic.BackColor = Color.Transparent;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            task.ToggleIsNotificated();
            if (task.IsNotificated)
            {
                pic.Image = Properties.Resources.bell;
            }
            else
            {
                pic.Image = Properties.Resources.bell_mute;
            }
        }
    }
}
