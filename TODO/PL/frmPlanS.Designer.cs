namespace TODO.PL
{
    partial class frmPlanS
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
            label1 = new Label();
            button11 = new Button();
            panel9 = new Panel();
            label4 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
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
            label9 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            label3 = new Label();
            panel9.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
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
            // button11
            // 
            button11.Image = Properties.Resources.repeat;
            button11.ImageAlign = ContentAlignment.MiddleRight;
            button11.Location = new Point(54, 65);
            button11.Margin = new Padding(0);
            button11.Name = "button11";
            button11.Size = new Size(110, 41);
            button11.TabIndex = 1;
            button11.Text = "Today";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = Properties.Resources.notificationPanel;
            panel9.BackgroundImageLayout = ImageLayout.Stretch;
            panel9.Controls.Add(button11);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(342, 138);
            panel9.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 30);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 0;
            label4.Text = "To do list";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Location = new Point(19, 242);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(354, 594);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(flowLayoutPanel2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(1481, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 972);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
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
            button1.Location = new Point(0, 658);
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
            button20.Location = new Point(-1, 574);
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
            button5.Location = new Point(-1, 490);
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
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Location = new Point(375, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1106, 972);
            panel4.TabIndex = 3;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.plans_white;
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
            label2.Location = new Point(70, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 76);
            label2.TabIndex = 4;
            label2.Text = "Plans";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(16, 311);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1087, 561);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.ttttttttttttt;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(4, 4);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1075, 180);
            panel5.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SpringGreen;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(30, 84);
            panel6.Margin = new Padding(30);
            panel6.Name = "panel6";
            panel6.Size = new Size(1015, 41);
            panel6.TabIndex = 1;
            panel6.Paint += panel6_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(452, 5);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 0;
            label5.Text = "100%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 32);
            label3.TabIndex = 0;
            label3.Text = "This is a plan name";
            // 
            // frmPlanS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 979);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "frmPlanS";
            Text = "frmPlanS";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button11;
        private Panel panel9;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
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
        private Label label9;
        private PictureBox pictureBox2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private Panel panel6;
        private Label label5;
        private Label label3;
    }
}