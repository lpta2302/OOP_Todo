namespace TODO.PL
{
    partial class frmCreate
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
            label2 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            button20 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            btnBack = new Button();
            tpkEndTaskTime = new DateTimePicker();
            tpkStartTaskTime = new DateTimePicker();
            dtpkEndTaskTime = new DateTimePicker();
            dtpkStartTaskTime = new DateTimePicker();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            txtNote = new TextBox();
            txtTitle = new TextBox();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dtpkToday = new DateTimePicker();
            dtpkFromDay = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            listView1 = new ListView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
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
            label2.Size = new Size(338, 76);
            label2.TabIndex = 4;
            label2.Text = "Create Task";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button6);
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
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = Properties.Resources.Plans_white1;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(4, 665);
            button6.Margin = new Padding(8);
            button6.Name = "button6";
            button6.Size = new Size(368, 68);
            button6.TabIndex = 10;
            button6.Text = "Plans";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.background;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(btnBack);
            panel4.Controls.Add(tpkEndTaskTime);
            panel4.Controls.Add(tpkStartTaskTime);
            panel4.Controls.Add(dtpkEndTaskTime);
            panel4.Controls.Add(dtpkStartTaskTime);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtNote);
            panel4.Controls.Add(txtTitle);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(375, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1482, 972);
            panel4.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(34, 34, 34);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(16, 122);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 62);
            btnBack.TabIndex = 32;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // tpkEndTaskTime
            // 
            tpkEndTaskTime.CustomFormat = "hh:mm";
            tpkEndTaskTime.Format = DateTimePickerFormat.Custom;
            tpkEndTaskTime.Location = new Point(332, 669);
            tpkEndTaskTime.Margin = new Padding(2);
            tpkEndTaskTime.Name = "tpkEndTaskTime";
            tpkEndTaskTime.Size = new Size(83, 31);
            tpkEndTaskTime.TabIndex = 26;
            // 
            // tpkStartTaskTime
            // 
            tpkStartTaskTime.CustomFormat = "hh:mm";
            tpkStartTaskTime.Format = DateTimePickerFormat.Custom;
            tpkStartTaskTime.Location = new Point(332, 576);
            tpkStartTaskTime.Margin = new Padding(2);
            tpkStartTaskTime.Name = "tpkStartTaskTime";
            tpkStartTaskTime.Size = new Size(83, 31);
            tpkStartTaskTime.TabIndex = 25;
            // 
            // dtpkEndTaskTime
            // 
            dtpkEndTaskTime.CustomFormat = "\"dd/MM/yyyy hh:mm\"";
            dtpkEndTaskTime.Location = new Point(26, 669);
            dtpkEndTaskTime.Margin = new Padding(2);
            dtpkEndTaskTime.Name = "dtpkEndTaskTime";
            dtpkEndTaskTime.Size = new Size(300, 31);
            dtpkEndTaskTime.TabIndex = 22;
            // 
            // dtpkStartTaskTime
            // 
            dtpkStartTaskTime.CustomFormat = "\"dd/MM/yyyy hh:mm\"";
            dtpkStartTaskTime.Location = new Point(26, 576);
            dtpkStartTaskTime.Margin = new Padding(2);
            dtpkStartTaskTime.Name = "dtpkStartTaskTime";
            dtpkStartTaskTime.Size = new Size(300, 31);
            dtpkStartTaskTime.TabIndex = 21;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.repeat;
            pictureBox4.Location = new Point(94, 882);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.star;
            pictureBox3.Location = new Point(16, 882);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(16, 629);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(198, 37);
            label9.TabIndex = 16;
            label9.Text = "End Task Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 536);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 37);
            label8.TabIndex = 15;
            label8.Text = "Start Task Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 318);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 37);
            label7.TabIndex = 14;
            label7.Text = "Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 209);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 37);
            label3.TabIndex = 13;
            label3.Text = "Title";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(16, 362);
            txtNote.Margin = new Padding(4);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(799, 155);
            txtNote.TabIndex = 12;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(16, 251);
            txtTitle.Margin = new Padding(4);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(802, 50);
            txtTitle.TabIndex = 11;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(326, 774);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(270, 62);
            button7.TabIndex = 10;
            button7.Text = "Create";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(16, 35);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpkToday);
            panel3.Controls.Add(dtpkFromDay);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(472, 521);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 245);
            panel3.TabIndex = 31;
            // 
            // dtpkToday
            // 
            dtpkToday.Location = new Point(16, 148);
            dtpkToday.Margin = new Padding(2);
            dtpkToday.Name = "dtpkToday";
            dtpkToday.Size = new Size(300, 31);
            dtpkToday.TabIndex = 24;
            // 
            // dtpkFromDay
            // 
            dtpkFromDay.Location = new Point(16, 55);
            dtpkFromDay.Margin = new Padding(2);
            dtpkFromDay.Name = "dtpkFromDay";
            dtpkFromDay.Size = new Size(300, 31);
            dtpkFromDay.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(16, 14);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(141, 37);
            label10.TabIndex = 17;
            label10.Text = "From Day";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(16, 108);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(105, 37);
            label11.TabIndex = 20;
            label11.Text = "To Day";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(listView1);
            panel5.Location = new Point(890, 120);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(562, 792);
            panel5.TabIndex = 33;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(302, 710);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 62);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(302, 616);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 62);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(52, 616);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 62);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(52, 131);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(426, 454);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 979);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "frmCreate";
            Text = "frmCreate";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel1;
        private Panel panel4;
        private TextBox txtNote;
        private TextBox txtTitle;
        private Button button7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label11;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private DateTimePicker dtpkStartTaskTime;
        private DateTimePicker dtpkToday;
        private DateTimePicker dtpkFromDay;
        private DateTimePicker dtpkEndTaskTime;
        protected DateTimePicker tpkStartTaskTime;
        protected DateTimePicker tpkEndTaskTime;
        private PictureBox pictureBox2;
        private Button btnDelete;
        private Button btnAdd;
        private ListView listView1;
        private Button btnUpdate;
        private Panel panel3;
        private Button btnBack;
        private Panel panel5;
        private Button button6;
    }
}