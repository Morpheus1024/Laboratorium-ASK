using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ask2
{
    partial class Form4
    {
        /// <summary>

        private int licznik_czasu;
        private int licznik_dobrych_ruchow;
        private Stopwatch stopwatch;
        private double sumaCzasowReakcji = 0;
        private double iloscDobrychRuchow = 0;
        private int random;
        private int czy_pierwsza = 0;
        private float sredni_czas;
        private int zliczanie;
        private PictureBox[] pb;
        private List<float> czasy_reakcji = new List<float>();

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
            this.components = new System.ComponentModel.Container();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(66, 320);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(82, 83);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb7.TabIndex = 7;
            this.pb7.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(66, 173);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(82, 83);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb6.TabIndex = 8;
            this.pb6.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.SystemColors.Control;
            this.pb9.Location = new System.Drawing.Point(66, 637);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(82, 83);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb9.TabIndex = 9;
            this.pb9.TabStop = false;
            // 
            // pb10
            // 
            this.pb10.Location = new System.Drawing.Point(66, 777);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(82, 83);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb10.TabIndex = 10;
            this.pb10.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(66, 474);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(82, 83);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb8.TabIndex = 12;
            this.pb8.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(260, 46);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(82, 83);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(465, 46);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(82, 83);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb2.TabIndex = 14;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(676, 46);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(82, 83);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb3.TabIndex = 15;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(876, 46);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(82, 83);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb4.TabIndex = 16;
            this.pb4.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(1073, 46);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(82, 83);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb5.TabIndex = 17;
            this.pb5.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 83);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 83);
            this.button2.TabIndex = 19;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 83);
            this.button3.TabIndex = 20;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(876, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 83);
            this.button4.TabIndex = 21;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1073, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 83);
            this.button5.TabIndex = 22;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 83);
            this.button6.TabIndex = 23;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(465, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 83);
            this.button7.TabIndex = 24;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(676, 320);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 83);
            this.button8.TabIndex = 25;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(876, 320);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 83);
            this.button9.TabIndex = 26;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1073, 320);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 83);
            this.button10.TabIndex = 27;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(260, 474);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 83);
            this.button11.TabIndex = 28;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(465, 474);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 83);
            this.button12.TabIndex = 29;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(676, 474);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 83);
            this.button13.TabIndex = 30;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(876, 474);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 83);
            this.button14.TabIndex = 31;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1073, 474);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 83);
            this.button15.TabIndex = 32;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(260, 637);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 83);
            this.button16.TabIndex = 33;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(465, 637);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 83);
            this.button17.TabIndex = 34;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(676, 637);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 83);
            this.button18.TabIndex = 35;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(876, 637);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 83);
            this.button19.TabIndex = 36;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(1073, 637);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(82, 83);
            this.button20.TabIndex = 37;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(260, 777);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(82, 83);
            this.button21.TabIndex = 38;
            this.button21.Text = "21";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(465, 777);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(82, 83);
            this.button22.TabIndex = 39;
            this.button22.Text = "22";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(676, 777);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(82, 83);
            this.button23.TabIndex = 40;
            this.button23.Text = "23";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(876, 777);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(82, 83);
            this.button24.TabIndex = 41;
            this.button24.Text = "24";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(1073, 777);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(82, 83);
            this.button25.TabIndex = 42;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 922);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb10);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb7);
            this.Name = "Form4";
            this.Text = "TEST 3";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Timer timer1;
    }
}