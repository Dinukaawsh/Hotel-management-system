namespace WinFormsApp11
{
    partial class Manage_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_staff));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label7 = new Label();
            label9 = new Label();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(481, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(481, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(481, 393);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 27);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 176);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 282);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 7;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 400);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Department";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 176);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 9;
            label4.Text = "Addess";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 279);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 10;
            label5.Text = "Cuntact number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 400);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(343, 476);
            button1.Name = "button1";
            button1.Size = new Size(132, 46);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mail", "FreeMail" });
            comboBox2.Location = new Point(151, 276);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 393);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(798, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Location = new Point(798, 229);
            button2.Name = "button2";
            button2.Size = new Size(123, 35);
            button2.TabIndex = 16;
            button2.Text = "Add Photo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightYellow;
            button3.Location = new Point(702, 365);
            button3.Name = "button3";
            button3.Size = new Size(118, 44);
            button3.TabIndex = 17;
            button3.Text = "Cretificate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightYellow;
            button4.Location = new Point(853, 364);
            button4.Name = "button4";
            button4.Size = new Size(118, 45);
            button4.TabIndex = 18;
            button4.Text = "Police Report";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGreen;
            button5.Location = new Point(702, 476);
            button5.Name = "button5";
            button5.Size = new Size(106, 37);
            button5.TabIndex = 19;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Salmon;
            button6.Location = new Point(853, 476);
            button6.Name = "button6";
            button6.Size = new Size(106, 37);
            button6.TabIndex = 20;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(840, 52);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 21;
            label7.Text = "Photo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(444, 27);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 23;
            label9.Text = "Manage staff";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.HighlightText;
            button7.Location = new Point(353, 86);
            button7.Name = "button7";
            button7.Size = new Size(104, 45);
            button7.TabIndex = 25;
            button7.Text = "0";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(729, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(879, 294);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 98);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 28;
            label8.Text = "Search";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(384, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Manage_staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1026, 561);
            Controls.Add(pictureBox4);
            Controls.Add(label8);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button7);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "Manage_staff";
            Text = "Manage_staff";
            Load += Manage_staff_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label7;
        private Label label9;
        private Button button7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label8;
        private PictureBox pictureBox4;
    }
}