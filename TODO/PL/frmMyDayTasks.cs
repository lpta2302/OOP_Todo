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
    public partial class frmMyDayTasks : Form
    {
        bool IsShortTask;
        public frmMyDayTasks(Task task)
        {
            InitializeComponent();
            label4.Text = task.Title;
            pictureBox11.Image = task.IsImportant ? Properties.Resources.star_fill : Properties.Resources.star;
            label8.Text = task.Content;
            label1.Text = Util.isEmptyDate(task.NotiTime) ? "" : $" {TypeConverter.ExchangeToDMYHMS(task.NotiTime)}";
            label2.Text = Util.isEmptyDate(task.EndTime) ? "" : $" {TypeConverter.ExchangeToDMYHMS(task.EndTime)}";
            if (task is ShortTask)
            {
                IsShortTask = true;
                label9.Visible = false;
                flowLayoutPanel1.Controls.Clear();
                panel8.Visible = false;
            }
            else
            {
                LongTask lt = task as LongTask;
                label9.Text = $"From: {TypeConverter.ExchangeToDMY(lt.FromDate)} - To: {TypeConverter.ExchangeToDMY(lt.ToDate)}";
                label6.Text = lt.CalculateCurrentProgress().ToString()+"%";
                Renderer.RenderTaskDetail(lt.Details, flowLayoutPanel1);
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Hide();
            new frmCreate(frmCreate.CreateType.ShortTerm).ShowDialog();
            Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
