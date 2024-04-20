
namespace TODO.PL
{
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
                    IsShortTask = true;
                    break;
                case CreateType.LongTerm:
                    pictureBox4.Visible = false;
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

            if (task is ShortTask)
            {
                IsShortTask = true;
            }

            if (task != null)
            {
                IsUpdate = true;
                this.task = task;
                LoadTaskInfo(task);
            }
            else
            {
                this.task = createType == CreateType.ShortTerm ? new ShortTask() : new LongTask();
            }

            LoadForm(createType);
        }
        private void LoadTaskInfo(Task task)
        {
            txtTitle.Text = task.Title;
            txtNote.Text = task.Content;
            pictureBox3.Image = task.IsImportant ? Properties.Resources.star_fill : Properties.Resources.star;
            pictureBox5.Image = task.IsNotificated ? Properties.Resources.bell : Properties.Resources.bell_mute;

            if (!isEmptyDate(task.NotiTime))
            {
                dtpkStartTaskTime.Value = task.NotiTime;
                tpkStartTaskTime.Value = task.NotiTime;
            }

            if (!isEmptyDate(task.EndTime))
            {
                dtpkEndTaskTime.Value = task.EndTime;
                tpkEndTaskTime.Value = task.EndTime;
            }

            if (!IsShortTask)
            {
                LongTask temp = (LongTask)task;
                dtpkFromDay.Value = new DateTime(temp.FromDate.Year, temp.FromDate.Month, temp.FromDate.Day);
                dtpkToday.Value = new DateTime(temp.FromDate.Year, temp.FromDate.Month, temp.FromDate.Day);

                for (int i = 0; i < temp.Details.Count; i++)
                {
                    ListViewItem item = new ListViewItem("" + (i + 1));
                    item.SubItems.Add(temp.Details[i].Content);
                    listView1.Items.Add(item);
                }
            }
            else
            {
                if (((ShortTask)task).IsRepeated)
                {
                    pictureBox4.BackColor = Color.AliceBlue;
                }
                else
                {
                    pictureBox4.BackColor = Color.Transparent;
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

            task.NotiTime = new DateTime(dtpkNotiTimeValue.Year, dtpkNotiTimeValue.Month, dtpkNotiTimeValue.Day, tpkStartTaskTime.Value.Hour, tpkStartTaskTime.Value.Minute, 0);
            task.NotiTime = new DateTime(dtpkEndTimeValue.Year, dtpkEndTimeValue.Month, dtpkEndTimeValue.Day, tpkEndTaskTime.Value.Hour, tpkEndTaskTime.Value.Minute, 0);
            task.Title = txtTitle.Text;
            task.Content = txtNote.Text;
            if (!IsShortTask)
            {
                LongTask longTask = (LongTask)task;
                longTask.FromDate = DateOnly.FromDateTime(dtpkFromDay.Value);
                longTask.ToDate = DateOnly.FromDateTime(dtpkToday.Value);
            }

            if (IsUpdate)
            {
                task.Update();
            }
            else
            {
                if (IsShortTask)
                {
                    ShortTaskCRUD.Instance.Create(task);
                }
                else
                {
                    LongTaskCRUD.Instance.Create(task);
                    GlobalData.CurrentPlan.AddTask(task);
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
            TODO.DA.Detail detail = new TODO.DA.Detail()
            {
                Content = textBox2.Text
            };
            ((LongTask)task).Details.Add(detail);
            ListViewItem item = new ListViewItem("" + (listView1.Items.Count + 1));
            item.SubItems.Add((detail.Content));
            listView1.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            int index = listView1.SelectedIndices[0];
            LongTask longTask = ((LongTask)task);
            longTask.Details.RemoveAt(index);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            if (task is ShortTask)
            {
                new frmCreateLobby().ShowDialog();
            }
            else
                new frmCreatePlan().ShowDialog();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Task t in GlobalData.CurrentTasks)
            {
                if (t.CheckTime() && t.IsNotificated)
                {
                    MessageBox.Show(t.Content,t.Title);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
