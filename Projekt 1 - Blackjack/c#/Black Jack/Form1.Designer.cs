using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Black_Jack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        ///  
        public class Karta
        {
            public int wartosc;
            public int kolor;
        }

        public int curretSkin;

        public List<Karta> talia = new List<Karta>();
        public List<Karta> karty_playera = new List<Karta>();
        public List<Karta> karty_dealera = new List<Karta>();
        public bool koniec_gry;


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
            Hit_Button = new Button();
            Stand_Button = new Button();
            dealer_1 = new PictureBox();
            player_1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            graToolStripMenuItem = new ToolStripMenuItem();
            nowaGraToolStripMenuItem = new ToolStripMenuItem();
            wyjdźZGryToolStripMenuItem = new ToolStripMenuItem();
            oknoPomocyToolStripMenuItem = new ToolStripMenuItem();
            grafikaToolStripMenuItem = new ToolStripMenuItem();
            skin1ToolStripMenuItem = new ToolStripMenuItem();
            skin2ToolStripMenuItem = new ToolStripMenuItem();
            skin3ToolStripMenuItem = new ToolStripMenuItem();
            player_2 = new PictureBox();
            player_3 = new PictureBox();
            player_4 = new PictureBox();
            player_5 = new PictureBox();
            player_6 = new PictureBox();
            dealer_2 = new PictureBox();
            score = new Label();
            ((System.ComponentModel.ISupportInitialize)dealer_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer_2).BeginInit();
            SuspendLayout();
            // 
            // Hit_Button
            // 
            Hit_Button.Location = new Point(12, 502);
            Hit_Button.Name = "Hit_Button";
            Hit_Button.Size = new Size(220, 23);
            Hit_Button.TabIndex = 0;
            Hit_Button.Text = "Hit";
            Hit_Button.UseVisualStyleBackColor = true;
            Hit_Button.Click += Hit_Button_Click;
            // 
            // Stand_Button
            // 
            Stand_Button.Location = new Point(238, 502);
            Stand_Button.Name = "Stand_Button";
            Stand_Button.Size = new Size(220, 23);
            Stand_Button.TabIndex = 1;
            Stand_Button.Text = "Stand";
            Stand_Button.UseVisualStyleBackColor = true;
            Stand_Button.Click += Stand_Button_Click;
            // 
            // dealer_1
            // 
            dealer_1.Location = new Point(12, 28);
            dealer_1.Name = "dealer_1";
            dealer_1.Size = new Size(154, 231);
            dealer_1.TabIndex = 2;
            dealer_1.TabStop = false;
            // 
            // player_1
            // 
            player_1.Location = new Point(12, 265);
            player_1.Name = "player_1";
            player_1.Size = new Size(154, 231);
            player_1.TabIndex = 3;
            player_1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { graToolStripMenuItem, grafikaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(983, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            graToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowaGraToolStripMenuItem, wyjdźZGryToolStripMenuItem, oknoPomocyToolStripMenuItem });
            graToolStripMenuItem.Name = "graToolStripMenuItem";
            graToolStripMenuItem.Size = new Size(37, 20);
            graToolStripMenuItem.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem
            // 
            nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            nowaGraToolStripMenuItem.Size = new Size(150, 22);
            nowaGraToolStripMenuItem.Text = "Nowa gra";
            nowaGraToolStripMenuItem.Click += nowaGraToolStripMenuItem_Click;
            // 
            // wyjdźZGryToolStripMenuItem
            // 
            wyjdźZGryToolStripMenuItem.Name = "wyjdźZGryToolStripMenuItem";
            wyjdźZGryToolStripMenuItem.Size = new Size(150, 22);
            wyjdźZGryToolStripMenuItem.Text = "Wyjdź z gry";
            // 
            // oknoPomocyToolStripMenuItem
            // 
            oknoPomocyToolStripMenuItem.Name = "oknoPomocyToolStripMenuItem";
            oknoPomocyToolStripMenuItem.Size = new Size(150, 22);
            oknoPomocyToolStripMenuItem.Text = "Okno pomocy";
            oknoPomocyToolStripMenuItem.Click += oknoPomocyToolStripMenuItem_Click;
            // 
            // grafikaToolStripMenuItem
            // 
            grafikaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { skin1ToolStripMenuItem, skin2ToolStripMenuItem, skin3ToolStripMenuItem });
            grafikaToolStripMenuItem.Name = "grafikaToolStripMenuItem";
            grafikaToolStripMenuItem.Size = new Size(56, 20);
            grafikaToolStripMenuItem.Text = "Grafika";
            // 
            // skin1ToolStripMenuItem
            // 
            skin1ToolStripMenuItem.Name = "skin1ToolStripMenuItem";
            skin1ToolStripMenuItem.Size = new Size(105, 22);
            skin1ToolStripMenuItem.Text = "Skin 1";
            skin1ToolStripMenuItem.Click += skin1ToolStripMenuItem_Click;
            // 
            // skin2ToolStripMenuItem
            // 
            skin2ToolStripMenuItem.Name = "skin2ToolStripMenuItem";
            skin2ToolStripMenuItem.Size = new Size(105, 22);
            skin2ToolStripMenuItem.Text = "Skin 2";
            skin2ToolStripMenuItem.Click += skin2ToolStripMenuItem_Click;
            // 
            // skin3ToolStripMenuItem
            // 
            skin3ToolStripMenuItem.Name = "skin3ToolStripMenuItem";
            skin3ToolStripMenuItem.Size = new Size(105, 22);
            skin3ToolStripMenuItem.Text = "Skin 3";
            skin3ToolStripMenuItem.Click += skin3ToolStripMenuItem_Click;
            // 
            // player_2
            // 
            player_2.Location = new Point(172, 265);
            player_2.Name = "player_2";
            player_2.Size = new Size(154, 231);
            player_2.TabIndex = 6;
            player_2.TabStop = false;
            // 
            // player_3
            // 
            player_3.Location = new Point(332, 264);
            player_3.Name = "player_3";
            player_3.Size = new Size(154, 231);
            player_3.TabIndex = 7;
            player_3.TabStop = false;
            // 
            // player_4
            // 
            player_4.Location = new Point(492, 265);
            player_4.Name = "player_4";
            player_4.Size = new Size(154, 231);
            player_4.TabIndex = 8;
            player_4.TabStop = false;
            // 
            // player_5
            // 
            player_5.Location = new Point(652, 264);
            player_5.Name = "player_5";
            player_5.Size = new Size(154, 231);
            player_5.TabIndex = 9;
            player_5.TabStop = false;
            // 
            // player_6
            // 
            player_6.Location = new Point(812, 263);
            player_6.Name = "player_6";
            player_6.Size = new Size(154, 231);
            player_6.TabIndex = 10;
            player_6.TabStop = false;
            // 
            // dealer_2
            // 
            dealer_2.Location = new Point(172, 27);
            dealer_2.Name = "dealer_2";
            dealer_2.Size = new Size(154, 231);
            dealer_2.TabIndex = 11;
            dealer_2.TabStop = false;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Location = new Point(464, 506);
            score.Name = "score";
            score.Size = new Size(47, 15);
            score.TabIndex = 16;
            score.Text = "Punkty:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 537);
            Controls.Add(score);
            Controls.Add(dealer_2);
            Controls.Add(player_6);
            Controls.Add(player_5);
            Controls.Add(player_4);
            Controls.Add(player_3);
            Controls.Add(player_2);
            Controls.Add(player_1);
            Controls.Add(dealer_1);
            Controls.Add(Stand_Button);
            Controls.Add(Hit_Button);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dealer_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hit_Button;
        private Button Stand_Button;
        private PictureBox dealer_1;
        private PictureBox player_1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem graToolStripMenuItem;
        private ToolStripMenuItem starrtResetToolStripMenuItem;
        private ToolStripMenuItem grafikaToolStripMenuItem;
        private ToolStripMenuItem koniecToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem skin1ToolStripMenuItem;
        private ToolStripMenuItem skin2ToolStripMenuItem;
        private ToolStripMenuItem skin3ToolStripMenuItem;
        private ToolStripMenuItem nowaGraToolStripMenuItem;
        private ToolStripMenuItem wyjdźZGryToolStripMenuItem;
        private ToolStripMenuItem oknoPomocyToolStripMenuItem;
        private PictureBox player_2;
        private PictureBox player_3;
        private PictureBox player_4;
        private PictureBox player_5;
        private PictureBox player_6;
        private PictureBox dealer_2;
        private Label score;
    }
}
