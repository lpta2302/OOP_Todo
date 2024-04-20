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
using static TODO.PL.frmCreate;

namespace TODO.PL
{
    using static Util;
    public partial class frmCreate : Form
    {
        private bool IsUpdate = false;
        private bool IsShortTask = false;
        Task task;
        public enum CreateType
        {
            ShortTerm,
            LongTerm
        }
        public void LoadForm(CreateType createType)
        {
            switch (createType)
            {
                case CreateType.ShortTerm:
                    panel5.Visible = false;
                    listView1.Visible = false;
                    panel3.Visible = false;
                    IsShortTask = true;
                    task = new ShortTask();
                    IsShortTask = true;
                    break;
                case CreateType.LongTerm:
                    pictureBox4.Visible = false;
                    task = new LongTask();
                    break;
            }


            if (IsUpdate)
            {
                button7.Text = "Update";
                label2.Text = "Update Task";
            }

        }
        public frmCreate(CreateType createType, Task task = null)
        {
            InitializeComponent();

            if (task != null)
            {
                IsUpdate = true;
                LoadTaskInfo(task);
            }

            LoadForm(createType);
        }
        private void LoadTaskInfo(Task task)
        {
            txtTitle.Text = task.Title;
            txtNote.Text = task.Content;

            if (isEmptyDate(task.NotiTime))
            {
                dtpkStartTaskTime.Value = task.NotiTime;
                tpkStartTaskTime.Value = task.NotiTime;
            }

            if (isEmptyDate(task.EndTime))
            {
                dtpkEndTaskTime.Value = task.EndTime;
                tpkEndTaskTime.Value = task.EndTime;
            }

            if (!IsShortTask)
            {
                LongTask temp = (LongTask)task;
                dtpkFromDay.Value = new DateTime(temp.FromDate.Year, temp.FromDate.Month, temp.FromDate.Day);
                dtpkToday.Value = new DateTime(temp.FromDate.Year, temp.FromDate.Month, temp.FromDate.Day);

                int i = 1;
                foreach (Detail detail in temp.Details)
                {
                    ListViewItem item = new ListViewItem("" + 1);
                    item.SubItems.Add(detail.Content);
                }
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
            DateTime dtpkNotiTimeValue = dtpkStartTaskTime.Value;
            DateTime dtpkEndTimeValue = dtpkEndTaskTime.Value;

                task.NotiTime = new DateTime(dtpkNotiTimeValue.Hour, dtpkNotiTimeValue.Minute, dtpkNotiTimeValue.Second, tpkStartTaskTime.Value.Hour, tpkStartTaskTime.Value.Minute, 0);
                task.NotiTime = new DateTime(dtpkEndTimeValue.Hour, dtpkEndTimeValue.Minute, dtpkEndTimeValue.Second, tpkEndTaskTime.Value.Hour, tpkEndTaskTime.Value.Minute, 0);
            if(!IsShortTask)
            {
                LongTask longTask = (LongTask)task;
                longTask.FromDate = DateOnly.FromDateTime(dtpkFromDay.Value);
                longTask.ToDate = DateOnly.FromDateTime(dtpkToday.Value);
            }

            if (IsUpdate)
            {
                if(IsShortTask)
                    shortTask.Update();
                else 
                    longTask.Update();
            }
            else
            {
                if (IsShortTask)
                {
                    ShortTaskCRUD.Instance.Create(shortTask);
                }
                else
                {
                    LongTaskCRUD.Instance.Create(longTask);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length == 0)
            {
                return;
            }
            Detail detail = new Detail()
            {
                Content = textBox2.Text,
            };
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            task.Title = txtTitle.Text;
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            task.Content = txtNote.Text;
        }
    }
}
