namespace STUDENT_RECORD_MANAGEMENT_SYSTEM
{
    partial class Main
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Fuchsia;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 66);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-1, 15);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 0;
            label2.Text = "CREATIVE SCHOOL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(185, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 66);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 15);
            label1.Name = "label1";
            label1.Size = new Size(588, 38);
            label1.TabIndex = 0;
            label1.Text = "STUDENT RECORD MANAGEMENT SYSTEM";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(1, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 296);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(41, 250);
            button5.Name = "button5";
            button5.Size = new Size(106, 38);
            button5.TabIndex = 4;
            button5.Text = "TUITION FEE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(41, 190);
            button4.Name = "button4";
            button4.Size = new Size(106, 38);
            button4.TabIndex = 3;
            button4.Text = "SECTION";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(41, 127);
            button3.Name = "button3";
            button3.Size = new Size(106, 38);
            button3.TabIndex = 2;
            button3.Text = "TEACHER";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(41, 70);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 1;
            button2.Text = "COURSE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 13);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 0;
            button1.Text = "STUDENT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Fuchsia;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 377);
            panel4.Name = "panel4";
            panel4.Size = new Size(179, 88);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 26);
            label4.Name = "label4";
            label4.Size = new Size(155, 31);
            label4.TabIndex = 0;
            label4.Text = "THANK YOU!";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SRMS;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(927, 484);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Label label4;
    }
}