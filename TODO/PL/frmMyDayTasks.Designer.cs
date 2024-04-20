namespace TODO.PL
{
    partial class frmMyDayTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyDayTasks));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button20 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel6 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel7 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            button8 = new Button();
            btnEdit = new Button();
            label8 = new Label();
            label7 = new Label();
            pictureBox11 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            panel8 = new Panel();
            label6 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1858, 972);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button20);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 972);
            panel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.Plans_white1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 662);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(368, 68);
            button1.TabIndex = 9;
            button1.Text = "Plans";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button20
            // 
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Image = Properties.Resources.plus_black11;
            button20.ImageAlign = ContentAlignment.MiddleLeft;
            button20.Location = new Point(-1, 576);
            button20.Margin = new Padding(8);
            button20.Name = "button20";
            button20.Size = new Size(368, 68);
            button20.TabIndex = 8;
            button20.Text = "Create";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = Properties.Resources.check_square;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1, 492);
            button5.Margin = new Padding(8);
            button5.Name = "button5";
            button5.Size = new Size(368, 68);
            button5.TabIndex = 6;
            button5.Text = "Tasks";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources.calendar_dots;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(4, 408);
            button4.Margin = new Padding(8);
            button4.Name = "button4";
            button4.Size = new Size(368, 68);
            button4.TabIndex = 5;
            button4.Text = "Planned";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.star;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(4, 325);
            button3.Margin = new Padding(8);
            button3.Name = "button3";
            button3.Size = new Size(368, 68);
            button3.TabIndex = 4;
            button3.Text = "Important";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.sun;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(4, 242);
            button2.Margin = new Padding(8);
            button2.Name = "button2";
            button2.Size = new Size(368, 68);
            button2.TabIndex = 3;
            button2.Text = "My Day";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gainsboro;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Image = Properties.Resources.magnifying_glass;
            button10.Location = new Point(306, 122);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(65, 59);
            button10.TabIndex = 2;
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 122);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 58);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(144, 9);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.background;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(375, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1482, 972);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(828, 179);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(606, 794);
            panel6.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(599, 479);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(779, 0);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(610, 418);
            panel7.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(49, 179);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(779, 794);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(11, 646);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 38);
            label9.TabIndex = 13;
            label9.Text = "from - to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(300, 554);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 38);
            label2.TabIndex = 12;
            label2.Text = "EndTime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 554);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 11;
            label1.Text = "Notitime";
            // 
            // button8
            // 
            button8.BackColor = Color.Gainsboro;
            button8.BackgroundImage = Properties.Resources.trash_bin;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Location = new Point(711, 502);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(56, 56);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(34, 34, 34);
            btnEdit.BackgroundImage = Properties.Resources.edit_white;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Location = new Point(648, 502);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 56);
            btnEdit.TabIndex = 9;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(11, 255);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(704, 180);
            label8.TabIndex = 8;
            label8.Text = resources.GetString("label8.Text");
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 217);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 38);
            label7.TabIndex = 7;
            label7.Text = "Note";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.star;
            pictureBox11.Location = new Point(700, 25);
            pictureBox11.Margin = new Padding(4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(55, 55);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 4;
            pictureBox11.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(725, 108);
            label4.TabIndex = 3;
            label4.Text = "Lorem ipsum dolor sit amet \r\nconsectetur adipisicing elit. Ea, sequi.\r\n";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(779, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(610, 418);
            panel5.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(10, 146);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(756, 68);
            panel8.TabIndex = 32;
            panel8.Paint += panel8_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(166, 21);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 32);
            label6.TabIndex = 0;
            label6.Text = "80%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(7, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 38);
            label5.TabIndex = 5;
            label5.Text = "Progress:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // frmMyDayTasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 979);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "frmMyDayTasks";
            Text = "frmMyDayTasks";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label9;
        private Button button17;
        private Button button16;
        private Button button9;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button20;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button10;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox11;
        private Label label7;
        private Label label8;
        private Button btnEdit;
        private Button button8;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel8;
        private Label label6;
    }
}