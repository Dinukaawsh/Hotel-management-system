namespace WinFormsApp11
{
    partial class Manage_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Reservation));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 31);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Resavation Form";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FloralWhite;
            textBox1.Location = new Point(268, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(268, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(268, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 316);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(682, 309);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(240, 27);
            textBox6.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 8;
            label2.Text = "ID Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 191);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 250);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 10;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 316);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Mobile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(556, 222);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 12;
            label6.Text = "Reservation data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 316);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 13;
            label7.Text = "Non OF PAX";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(401, 362);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 15;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(682, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Location = new Point(268, 425);
            button2.Name = "button2";
            button2.Size = new Size(117, 35);
            button2.TabIndex = 17;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Plum;
            button3.Location = new Point(452, 425);
            button3.Name = "button3";
            button3.Size = new Size(117, 35);
            button3.TabIndex = 18;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Location = new Point(796, 425);
            button4.Name = "button4";
            button4.Size = new Size(117, 35);
            button4.TabIndex = 19;
            button4.Text = "cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGreen;
            button5.Location = new Point(89, 425);
            button5.Name = "button5";
            button5.Size = new Size(117, 35);
            button5.TabIndex = 20;
            button5.Text = "Download File";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Pink;
            button6.Location = new Point(626, 425);
            button6.Name = "button6";
            button6.Size = new Size(117, 35);
            button6.TabIndex = 22;
            button6.Text = "Setting";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Manage_Reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(965, 516);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Manage_Reservation";
            Text = "Manage Reservation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button6;
    }
}