namespace TODO
{
    partial class frmMyDay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyDay));
            panel1 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            label9 = new Label();
            button17 = new Button();
            button16 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel2 = new Panel();
            button10 = new Button();
            button20 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1858, 972);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.background;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(button17);
            panel4.Controls.Add(button16);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Location = new Point(375, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1106, 972);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(78, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(248, 76);
            label3.TabIndex = 13;
            label3.Text = "Planned";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(81, 99);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(222, 32);
            label9.TabIndex = 11;
            label9.Text = "Wednesday, April 3";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(34, 34, 34);
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = Color.White;
            button17.Location = new Point(299, 201);
            button17.Margin = new Padding(4);
            button17.Name = "button17";
            button17.Size = new Size(192, 51);
            button17.TabIndex = 10;
            button17.Text = "Long Task";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(34, 34, 34);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(99, 201);
            button16.Margin = new Padding(4);
            button16.Name = "button16";
            button16.Size = new Size(192, 51);
            button16.TabIndex = 9;
            button16.Text = "Short Task";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.sun_white;
            pictureBox2.Location = new Point(16, 35);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(1240, -214);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 76);
            label2.TabIndex = 4;
            label2.Text = "My Day";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(34, 34, 34);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(1035, 125);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(56, 56);
            button9.TabIndex = 3;
            button9.Text = "+";
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(34, 34, 34);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(899, 201);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(192, 51);
            button8.TabIndex = 2;
            button8.Text = "Uncompleted";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(34, 34, 34);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(699, 201);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(192, 51);
            button7.TabIndex = 1;
            button7.Text = "Completed";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(34, 34, 34);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(499, 201);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(192, 51);
            button6.TabIndex = 0;
            button6.Text = "All";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(16, 373);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1075, 480);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel8);
            panel3.Location = new Point(1481, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 972);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 54);
            label1.TabIndex = 0;
            label1.Text = "Notification";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(flowLayoutPanel2);
            panel8.Location = new Point(0, 254);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(375, 603);
            panel8.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Location = new Point(6, 119);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(366, 480);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(16, 8);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button20);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 972);
            panel2.TabIndex = 0;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Image = Properties.Resources.Plans_white1;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(4, 656);
            button10.Margin = new Padding(8);
            button10.Name = "button10";
            button10.Size = new Size(368, 68);
            button10.TabIndex = 10;
            button10.Text = "Plans";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button20
            // 
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Image = Properties.Resources.plus_black11;
            button20.ImageAlign = ContentAlignment.MiddleLeft;
            button20.Location = new Point(4, 572);
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
            button5.Location = new Point(4, 490);
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
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.magnifying_glass;
            button1.Location = new Point(306, 122);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(65, 59);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // frmMyDay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1864, 979);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmMyDay";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Label label1;
        private Panel panel8;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button20;
        private Button button17;
        private Button button16;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label3;
    }
}