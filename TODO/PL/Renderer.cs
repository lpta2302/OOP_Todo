

namespace TODO.PL
{
    internal class Renderer
    {
        public static void RenderListTask(IList<Task> tasks, FlowLayoutPanel container)
        {
            for (int i=0;i<tasks.Count;i++)
            {            
                Task task = tasks[i];
                Label title = new Label();
                Label date = new Label();
                Panel panel = new Panel();
                PictureBox star = new PictureBox();
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
                star.Location = new Point(969, 35);
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
                // label7
                // 
                date.AutoSize = true;
                date.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
                date.ForeColor = SystemColors.WindowFrame;
                date.Location = new Point(52, 71);
                date.Margin = new Padding(0);
                date.Size = new Size(95, 28);
                date.TabIndex = 3;
                date.Text = task.NotiTime.ToString("dd/MM/yyyy");
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
                panel.Location = new Point(0, i*(124+20));
                panel.Margin = new Padding(0);
                panel.Size = new Size(1040, 124);
                panel.TabIndex = 7;
                container.Controls.Add(panel);
                panel.Tag = i.ToString();
            }
        }
        public static void RenderListTaskNotification(IList<Task> tasks, FlowLayoutPanel container)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = tasks[i];
                Label title = new Label();
                Button date = new Button();
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
                date.Size = new Size(110, 41);
                date.TabIndex = 3;
                date.Text = "Today"; //task.NotiTime.ToString("dd/MM/yyyy");
                date.TextAlign = ContentAlignment.MiddleLeft;
                date.Tag = i.ToString();
                // 
                // panel9
                // 
                panel.BackColor = Color.Transparent;
                panel.BackgroundImage = Properties.Resources.task;
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
