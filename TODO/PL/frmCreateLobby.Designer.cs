namespace TODO.PL
{
    partial class frmCreateLobby
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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            button20 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button16 = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.sun;
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
            label2.Size = new Size(387, 76);
            label2.TabIndex = 4;
            label2.Text = "Create Lobby";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 122);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 58);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // button16
            // 
            button16.BackColor = Color.FromArgb(34, 34, 34);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(372, 135);
            button16.Margin = new Padding(4);
            button16.Name = "button16";
            button16.Size = new Size(270, 62);
            button16.TabIndex = 9;
            button16.Text = "Plan";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1858, 972);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.background;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(button16);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button6);
            panel4.Location = new Point(375, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1483, 972);
            panel4.TabIndex = 3;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(34, 34, 34);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(803, 135);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(270, 62);
            button6.TabIndex = 0;
            button6.Text = "Short Task";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // frmCreateLobby
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 979);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "frmCreateLobby";
            Text = "frmCreate";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel2;
        private Button button20;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button16;
        private Panel panel1;
        private Panel panel4;
        private Button button6;
    }
}