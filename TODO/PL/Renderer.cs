

namespace TODO.PL
{
    using static Util;
    internal class Renderer
    {
        public static void RenderListTask(IList<Task> tasks, FlowLayoutPanel container, string type, Form frmmyday)
        {
            for (int i=0;i<tasks.Count;i++)
            {            
                Task task = tasks[i];
                Label title = new Label();
                Label date = new Label();
                Panel panel = new Panel();
                PictureBox star = new PictureBox();
                PictureBox pen = new PictureBox();
                PictureBox trash = new PictureBox();
                // 
                // label3
                // 
                title.AutoSize = true;
                title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
                title.Location = new Point(45, 30);
                title.Margin = new Padding(0);
                title.Size = new Size(112, 32);
                title.TabIndex = 0;
                title.Text = task.Title;
                title.TextAlign = ContentAlignment.MiddleLeft;
                title.Tag = i.ToString();
                // 
                // pictureBox3
                // 
                star.Image = task.IsImportant ? Properties.Resources.star_fill : Properties.Resources.star;
                star.Location = new Point(850, 35);
                star.Margin = new Padding(4);
                star.Size = new Size(50, 50);
                star.SizeMode = PictureBoxSizeMode.StretchImage;
                star.TabIndex = 2;
                star.TabStop = false;
                star.Tag = i.ToString();
                star.Click += (object sender, EventArgs e) =>
                {
                    int index = int.Parse(((Control)sender).Tag.ToString())!;
                    tasks[index].ToggleImportant();
                    ((PictureBox)sender).Image = tasks[index].IsImportant ? Properties.Resources.star_fill : Properties.Resources.star;
                };
                //
                // pictureBoxPen
                // 
                pen.Image = Properties.Resources.edit;
                pen.Location = new Point(908, 35);
                pen.Margin = new Padding(4);
                pen.Size = new Size(50, 50);
                pen.SizeMode = PictureBoxSizeMode.StretchImage;
                pen.TabIndex = 2;
                pen.TabStop = false;
                pen.Tag = i.ToString();
                pen.Click += (object sender, EventArgs e) =>
                { 
                    
                    frmmyday.Hide();
                    if(task is ShortTask) 
                    new frmCreate(frmCreate.CreateType.ShortTerm, task).ShowDialog();
                    else
                    new frmCreate(frmCreate.CreateType.LongTerm, task).ShowDialog();

                    frmmyday.Close();
                };
                //
                // pictureBox trash
                //
                trash.Image = Properties.Resources.trash_bin;
                trash.Location = new Point(965, 35);
                trash.Margin = new Padding(4);
                trash.Size = new Size(50, 50);
                trash.SizeMode = PictureBoxSizeMode.StretchImage;
                trash.TabIndex = 2;
                trash.TabStop = false;
                trash.Tag = i.ToString();
                trash.Click += (object sender, EventArgs e) =>
                {
                    int index = int.Parse(((Control)sender).Tag.ToString())!;
                    tasks[index].Delete();
                    container.Controls.RemoveAt(index);
                };
                //
                // label7
                // 
                date.AutoSize = true;
                date.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
                date.ForeColor = SystemColors.WindowFrame;
                date.Location = new Point(52, 71);
                date.Margin = new Padding(0);
                date.Size = new Size(95, 28);
                date.TabIndex = 3;
                if (type == "importance")
                {
                    if(!isEmptyDate(task.NotiTime))
                        date.Text = TypeConverter.ExchangeToDMYHMS(task.NotiTime);
                    else if(task is LongTask)
                    {
                        LongTask longTask = (LongTask)task;
                        date.Text = TypeConverter.ExchangeToDMY(longTask.FromDate) +" - "+ TypeConverter.ExchangeToDMY(longTask.ToDate);
                    }
                }
                else if ( type == "myday")
                {
                    if(task is ShortTask)
                         date.Text = TypeConverter.GetHourTime( task.NotiTime);
                    else
                    {
                        LongTask longTask = (LongTask)task;
                        date.Text = TypeConverter.ExchangeToDMY(longTask.FromDate) + " - " + TypeConverter.ExchangeToDMY(longTask.ToDate);
                    }
                }
                date.TextAlign = ContentAlignment.MiddleLeft;
                date.Tag = i.ToString();
                // 
                // panel5
                // 
                panel.BackColor = Color.Transparent;
                panel.BackgroundImage = Properties.Resources.task;
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.Controls.Add(date);
                panel.Controls.Add(star);
                panel.Controls.Add(title);
                panel.Controls.Add(pen);
                panel.Controls.Add(trash);
                panel.Location = new Point(0, i*(124+20));
                panel.Margin = new Padding(0);
                panel.Size = new Size(1040, 124);
                panel.TabIndex = 7;
                container.Controls.Add(panel);
                panel.Tag = i.ToString();
                panel.Click += (object sender, EventArgs e) =>
                {
                    frmmyday.Hide();
                    new frmMyDayTasks().ShowDialog();
                    frmmyday.Close();
                };
            }
        }
        public static void RenderListTaskNotification(IList<Task> tasks, FlowLayoutPanel container)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = tasks[i];
                if (isEmptyDate(task.NotiTime))
                {
                    continue;
                }
                Label title = new Label();
                Label date = new Label();
                Panel panel = new Panel();
                // 
                // label4
                // 
                title.AutoSize = true;
                title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
                title.Location = new Point(54, 30);
                title.Margin = new Padding(0);
                title.Size = new Size(103, 30);
                title.TabIndex = 0;
                title.Text = task.Title;
                title.TextAlign = ContentAlignment.MiddleLeft;
                title.Tag = i.ToString();
                // 
                // button11 (today)
                // 
                date.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
                date.ForeColor = SystemColors.WindowFrame;
                date.Location = new Point(54, 65);
                date.Margin = new Padding(0);
                date.Size = new Size(243, 41);
                date.TabIndex = 3;
                date.Text = TypeConverter.ExchangeToDMYHMS(task.NotiTime);
                date.TextAlign = ContentAlignment.MiddleLeft;
                date.Tag = i.ToString();
                date.FlatStyle = FlatStyle.Flat;
                //date.FlatAppearance.BorderSize = 0;
                if (task is ShortTask && ((ShortTask)task).IsRepeated)
                {
                    date.Image = Properties.Resources.repeat;
                    date.ImageAlign = ContentAlignment.MiddleRight;
                }
                // 
                // panel9
                // 
                panel.BackColor = Color.Transparent;
                panel.BackgroundImage = Properties.Resources.notificationPanel;
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.Controls.Add(date);
                panel.Controls.Add(title);
                panel.Location = new Point(0, i * (124 + 20));
                panel.Margin = new Padding(0);
                panel.Size = new Size(326, 124);
                panel.TabIndex = 7;
                container.Controls.Add(panel);
                panel.Tag = i.ToString();
            }
        }
    }
}
