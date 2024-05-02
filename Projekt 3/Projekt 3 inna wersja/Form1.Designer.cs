using System;
using System.Management;

namespace Projekt_3_inna_wersja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// 
        class Piec
        {
            public short piec_temperatura = 0;
            public short piec_max_temperatura = 200;
            public short piec_max_pojemnosc = 20;
            public short piec_wieszaki = 0;
            public bool czy_piec_nagrzany = false;

            public short chlodnia_wentylatory_RPM = 0;
            public short chlodnia_max_pojemnosc = 20;
            public short chlodnia_temperatura = 0;
            public short chlodnia_wieszaki = 0;

        }

        Piec piec = new Piec();


        public short time_potwierdzenie_obecnosci = 30;

        public short piec_timer_tick = 0;
        public short chlodnia_timer_tick = 0;
        public short oddanie_timer_tick = 0;
        public short obecnosc_timer_tick = 0;
        public bool czy_obecny = true;
        public short czas_nieobecnosci = 0;
        public bool czy_wylaczac_piec = false;

        Random rand = new Random();
        public short random_wieszak = 0;




        //public ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT * FROM Win32_Fan");


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
            piec_label = new Label();
            piec_bar = new ProgressBar();
            log_window = new TextBox();
            obecnosc_button = new Button();
            obecnosc_timer = new System.Windows.Forms.Timer(components);
            chlodnia_bar = new ProgressBar();
            chlodnia_label = new Label();
            piec_temp_label = new Label();
            chlodnia_temp_label = new Label();
            chlodnia_wentylatory_rpm = new Label();
            chlodnia_wieszaki = new Label();
            piec_wieszaki = new Label();
            start_button = new Button();
            stop_button = new Button();
            chlodnia_timer = new System.Windows.Forms.Timer(components);
            piec_timer = new System.Windows.Forms.Timer(components);
            oddanie_timer = new System.Windows.Forms.Timer(components);
            chlodnia_progress_bar = new ProgressBar();
            piec_progress_bar = new ProgressBar();
            obecnosc_label = new Label();
            add_button = new Button();
            SuspendLayout();
            // 
            // piec_label
            // 
            piec_label.AutoSize = true;
            piec_label.Font = new Font("Segoe UI", 15F);
            piec_label.Location = new Point(361, 9);
            piec_label.Name = "piec_label";
            piec_label.Size = new Size(47, 28);
            piec_label.TabIndex = 0;
            piec_label.Text = "Piec";
            piec_label.TextAlign = ContentAlignment.MiddleCenter;
            piec_label.Click += label1_Click;
            // 
            // piec_bar
            // 
            piec_bar.Location = new Point(361, 117);
            piec_bar.Maximum = 20;
            piec_bar.Name = "piec_bar";
            piec_bar.Size = new Size(275, 25);
            piec_bar.Step = 1;
            piec_bar.TabIndex = 1;
            // 
            // log_window
            // 
            log_window.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            log_window.Location = new Point(12, 176);
            log_window.Multiline = true;
            log_window.Name = "log_window";
            log_window.ReadOnly = true;
            log_window.ScrollBars = ScrollBars.Vertical;
            log_window.Size = new Size(624, 162);
            log_window.TabIndex = 3;
            // 
            // obecnosc_button
            // 
            obecnosc_button.Location = new Point(12, 344);
            obecnosc_button.Name = "obecnosc_button";
            obecnosc_button.Size = new Size(230, 48);
            obecnosc_button.TabIndex = 4;
            obecnosc_button.Text = "Obecność";
            obecnosc_button.UseVisualStyleBackColor = true;
            obecnosc_button.Click += obecnosc_button_Click;
            // 
            // obecnosc_timer
            // 
            obecnosc_timer.Interval = 1000;
            obecnosc_timer.Tick += obecnosc_timer_Tick;
            // 
            // chlodnia_bar
            // 
            chlodnia_bar.Location = new Point(12, 117);
            chlodnia_bar.Maximum = 20;
            chlodnia_bar.Name = "chlodnia_bar";
            chlodnia_bar.Size = new Size(275, 25);
            chlodnia_bar.Step = 1;
            chlodnia_bar.TabIndex = 6;
            // 
            // chlodnia_label
            // 
            chlodnia_label.AutoSize = true;
            chlodnia_label.Font = new Font("Segoe UI", 15F);
            chlodnia_label.Location = new Point(12, 9);
            chlodnia_label.Name = "chlodnia_label";
            chlodnia_label.Size = new Size(90, 28);
            chlodnia_label.TabIndex = 5;
            chlodnia_label.Text = "Chłodnia";
            chlodnia_label.TextAlign = ContentAlignment.MiddleCenter;
            chlodnia_label.Click += chlodnia_label_Click;
            // 
            // piec_temp_label
            // 
            piec_temp_label.AutoSize = true;
            piec_temp_label.Font = new Font("Segoe UI", 15F);
            piec_temp_label.Location = new Point(361, 43);
            piec_temp_label.Name = "piec_temp_label";
            piec_temp_label.Size = new Size(125, 28);
            piec_temp_label.TabIndex = 7;
            piec_temp_label.Text = "Temp.: 200°C";
            piec_temp_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chlodnia_temp_label
            // 
            chlodnia_temp_label.AutoSize = true;
            chlodnia_temp_label.Font = new Font("Segoe UI", 15F);
            chlodnia_temp_label.Location = new Point(12, 43);
            chlodnia_temp_label.Name = "chlodnia_temp_label";
            chlodnia_temp_label.Size = new Size(114, 28);
            chlodnia_temp_label.TabIndex = 8;
            chlodnia_temp_label.Text = "Temp.: 30°C";
            chlodnia_temp_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chlodnia_wentylatory_rpm
            // 
            chlodnia_wentylatory_rpm.AutoSize = true;
            chlodnia_wentylatory_rpm.Font = new Font("Segoe UI", 15F);
            chlodnia_wentylatory_rpm.Location = new Point(135, 43);
            chlodnia_wentylatory_rpm.Name = "chlodnia_wentylatory_rpm";
            chlodnia_wentylatory_rpm.Size = new Size(152, 28);
            chlodnia_wentylatory_rpm.TabIndex = 9;
            chlodnia_wentylatory_rpm.Text = "Went: 1000RPM";
            chlodnia_wentylatory_rpm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chlodnia_wieszaki
            // 
            chlodnia_wieszaki.AutoSize = true;
            chlodnia_wieszaki.Font = new Font("Segoe UI", 15F);
            chlodnia_wieszaki.Location = new Point(12, 145);
            chlodnia_wieszaki.Name = "chlodnia_wieszaki";
            chlodnia_wieszaki.Size = new Size(138, 28);
            chlodnia_wieszaki.TabIndex = 10;
            chlodnia_wieszaki.Text = "Wieszaki: 0/20";
            chlodnia_wieszaki.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // piec_wieszaki
            // 
            piec_wieszaki.AutoSize = true;
            piec_wieszaki.Font = new Font("Segoe UI", 15F);
            piec_wieszaki.Location = new Point(361, 145);
            piec_wieszaki.Name = "piec_wieszaki";
            piec_wieszaki.Size = new Size(138, 28);
            piec_wieszaki.TabIndex = 11;
            piec_wieszaki.Text = "Wieszaki: 0/20";
            piec_wieszaki.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // start_button
            // 
            start_button.Location = new Point(370, 344);
            start_button.Name = "start_button";
            start_button.Size = new Size(110, 48);
            start_button.TabIndex = 12;
            start_button.Text = "Włącz";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // stop_button
            // 
            stop_button.Location = new Point(484, 344);
            stop_button.Name = "stop_button";
            stop_button.Size = new Size(110, 48);
            stop_button.TabIndex = 13;
            stop_button.Text = "Wyłącz";
            stop_button.UseVisualStyleBackColor = true;
            stop_button.Click += stop_button_Click;
            // 
            // chlodnia_timer
            // 
            chlodnia_timer.Interval = 1000;
            chlodnia_timer.Tick += chlodnia_timer_Tick;
            // 
            // piec_timer
            // 
            piec_timer.Interval = 1000;
            piec_timer.Tick += piec_timer_Tick;
            // 
            // oddanie_timer
            // 
            oddanie_timer.Interval = 1000;
            oddanie_timer.Tick += oddanie_timer_Tick;
            // 
            // chlodnia_progress_bar
            // 
            chlodnia_progress_bar.Location = new Point(12, 86);
            chlodnia_progress_bar.Maximum = 14;
            chlodnia_progress_bar.Name = "chlodnia_progress_bar";
            chlodnia_progress_bar.Size = new Size(275, 25);
            chlodnia_progress_bar.Step = 1;
            chlodnia_progress_bar.TabIndex = 14;
            // 
            // piec_progress_bar
            // 
            piec_progress_bar.Location = new Point(361, 86);
            piec_progress_bar.Maximum = 12;
            piec_progress_bar.Name = "piec_progress_bar";
            piec_progress_bar.Size = new Size(275, 25);
            piec_progress_bar.Step = 1;
            piec_progress_bar.Style = ProgressBarStyle.Continuous;
            piec_progress_bar.TabIndex = 15;
            // 
            // obecnosc_label
            // 
            obecnosc_label.AutoSize = true;
            obecnosc_label.Font = new Font("Segoe UI", 15F);
            obecnosc_label.Location = new Point(248, 350);
            obecnosc_label.Name = "obecnosc_label";
            obecnosc_label.Size = new Size(71, 28);
            obecnosc_label.TabIndex = 16;
            obecnosc_label.Text = "60 sek.";
            obecnosc_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add_button
            // 
            add_button.Location = new Point(600, 344);
            add_button.Name = "add_button";
            add_button.Size = new Size(36, 48);
            add_button.TabIndex = 17;
            add_button.Text = "+";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 409);
            Controls.Add(add_button);
            Controls.Add(obecnosc_label);
            Controls.Add(piec_progress_bar);
            Controls.Add(chlodnia_progress_bar);
            Controls.Add(stop_button);
            Controls.Add(start_button);
            Controls.Add(piec_wieszaki);
            Controls.Add(chlodnia_wieszaki);
            Controls.Add(chlodnia_wentylatory_rpm);
            Controls.Add(chlodnia_temp_label);
            Controls.Add(piec_temp_label);
            Controls.Add(chlodnia_bar);
            Controls.Add(chlodnia_label);
            Controls.Add(obecnosc_button);
            Controls.Add(log_window);
            Controls.Add(piec_bar);
            Controls.Add(piec_label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label piec_label;
        private ProgressBar piec_bar;
        private TextBox log_window;
        private Button obecnosc_button;
        private System.Windows.Forms.Timer obecnosc_timer;
        private ProgressBar chlodnia_bar;
        private Label chlodnia_label;
        private Label piec_temp_label;
        private Label chlodnia_wentylatory_rpm;
        private Label chlodnia_wieszaki;
        private Label piec_wieszaki;
        private Button start_button;
        private Button stop_button;
        private System.Windows.Forms.Timer chlodnia_timer;
        private System.Windows.Forms.Timer piec_timer;
        public Label chlodnia_temp_label;
        private ProgressBar chlodnia_progress_bar;
        private ProgressBar piec_progress_bar;
        public System.Windows.Forms.Timer oddanie_timer;
        private Label obecnosc_label;
        private Button add_button;

        public short Random_wieszak { get => random_wieszak; set => random_wieszak = value; }
    }
}
