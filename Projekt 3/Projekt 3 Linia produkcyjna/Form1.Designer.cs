namespace Projekt_3_Linia_produkcyjna
{
    partial class Form1
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
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            menuStrip1 = new MenuStrip();
            oknoZKomunikatamiToolStripMenuItem = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            timer_malowanie = new System.Windows.Forms.Timer(components);
            progressBar2 = new ProgressBar();
            timer_zawieszanie = new System.Windows.Forms.Timer(components);
            progressBar3 = new ProgressBar();
            timer_zdejmowanie = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(799, 251);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F);
            label5.Location = new Point(52, 83);
            label5.Name = "label5";
            label5.Size = new Size(109, 46);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F);
            label6.Location = new Point(52, 251);
            label6.Name = "label6";
            label6.Size = new Size(109, 46);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(773, 383);
            label8.Name = "label8";
            label8.Size = new Size(160, 37);
            label8.TabIndex = 7;
            label8.Text = "Zawieszanie";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(709, 214);
            label9.Name = "label9";
            label9.Size = new Size(314, 37);
            label9.TabIndex = 8;
            label9.Text = "Bufor przed malowaniem";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(312, 46);
            label10.Name = "label10";
            label10.Size = new Size(409, 37);
            label10.TabIndex = 9;
            label10.Text = "Pomieszczenie z natryskiem farby";
            label10.Click += label10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(70, 46);
            label4.Name = "label4";
            label4.Size = new Size(65, 37);
            label4.TabIndex = 10;
            label4.Text = "Piec";
            label4.Click += label4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F);
            label11.Location = new Point(46, 214);
            label11.Name = "label11";
            label11.Size = new Size(124, 37);
            label11.TabIndex = 11;
            label11.Text = "Chłodnia";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F);
            label12.Location = new Point(46, 383);
            label12.Name = "label12";
            label12.Size = new Size(178, 37);
            label12.TabIndex = 12;
            label12.Text = "Zdejmowanie";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 25F);
            label13.Location = new Point(419, 420);
            label13.Name = "label13";
            label13.Size = new Size(127, 46);
            label13.TabIndex = 13;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20F);
            label14.Location = new Point(336, 383);
            label14.Name = "label14";
            label14.Size = new Size(324, 37);
            label14.TabIndex = 14;
            label14.Text = "Bufor przed zawieszaniem";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F);
            label15.Location = new Point(46, 137);
            label15.Name = "label15";
            label15.Size = new Size(63, 28);
            label15.TabIndex = 15;
            label15.Text = "Temp:";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F);
            label16.Location = new Point(113, 137);
            label16.Name = "label16";
            label16.Size = new Size(70, 28);
            label16.TabIndex = 16;
            label16.Text = "{temp}";
            label16.Click += label16_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oknoZKomunikatamiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1107, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // oknoZKomunikatamiToolStripMenuItem
            // 
            oknoZKomunikatamiToolStripMenuItem.Name = "oknoZKomunikatamiToolStripMenuItem";
            oknoZKomunikatamiToolStripMenuItem.Size = new Size(136, 20);
            oknoZKomunikatamiToolStripMenuItem.Text = "Okno z komunikatami";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(373, 86);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(238, 23);
            progressBar1.TabIndex = 18;
            // 
            // timer_malowanie
            // 
            timer_malowanie.Tick += timer1_Tick;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(740, 433);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(238, 23);
            progressBar2.TabIndex = 19;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 433);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(238, 23);
            progressBar3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(119, 314);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 22;
            label1.Text = "{temp}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(52, 314);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 21;
            label3.Text = "Temp:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 570);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oknoZKomunikatamiToolStripMenuItem;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer_malowanie;
        private ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer_zawieszanie;
        private ProgressBar progressBar3;
        private System.Windows.Forms.Timer timer_zdejmowanie;
        private Label label1;
        private Label label3;
    }
}
