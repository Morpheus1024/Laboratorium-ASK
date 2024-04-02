namespace Black_Jack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        public int curretSkin;
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
            card_stack = new PictureBox();
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
            dealer_3 = new PictureBox();
            dealer_4 = new PictureBox();
            dealer_5 = new PictureBox();
            dealer_6 = new PictureBox();
            score = new Label();
            ((System.ComponentModel.ISupportInitialize)dealer_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card_stack).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealer_6).BeginInit();
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
            // 
            // dealer_1
            // 
            dealer_1.Location = new Point(12, 28);
            dealer_1.Name = "dealer_1";
            dealer_1.Size = new Size(126, 231);
            dealer_1.TabIndex = 2;
            dealer_1.TabStop = false;
            // 
            // player_1
            // 
            player_1.Location = new Point(12, 265);
            player_1.Name = "player_1";
            player_1.Size = new Size(126, 231);
            player_1.TabIndex = 3;
            player_1.TabStop = false;
            // 
            // card_stack
            // 
            card_stack.Location = new Point(804, 28);
            card_stack.Name = "card_stack";
            card_stack.Size = new Size(245, 468);
            card_stack.TabIndex = 4;
            card_stack.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { graToolStripMenuItem, grafikaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1061, 24);
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
            // 
            // skin2ToolStripMenuItem
            // 
            skin2ToolStripMenuItem.Name = "skin2ToolStripMenuItem";
            skin2ToolStripMenuItem.Size = new Size(105, 22);
            skin2ToolStripMenuItem.Text = "Skin 2";
            // 
            // skin3ToolStripMenuItem
            // 
            skin3ToolStripMenuItem.Name = "skin3ToolStripMenuItem";
            skin3ToolStripMenuItem.Size = new Size(105, 22);
            skin3ToolStripMenuItem.Text = "Skin 3";
            // 
            // player_2
            // 
            player_2.Location = new Point(144, 265);
            player_2.Name = "player_2";
            player_2.Size = new Size(126, 231);
            player_2.TabIndex = 6;
            player_2.TabStop = false;
            // 
            // player_3
            // 
            player_3.Location = new Point(276, 265);
            player_3.Name = "player_3";
            player_3.Size = new Size(126, 231);
            player_3.TabIndex = 7;
            player_3.TabStop = false;
            // 
            // player_4
            // 
            player_4.Location = new Point(408, 265);
            player_4.Name = "player_4";
            player_4.Size = new Size(126, 231);
            player_4.TabIndex = 8;
            player_4.TabStop = false;
            // 
            // player_5
            // 
            player_5.Location = new Point(540, 265);
            player_5.Name = "player_5";
            player_5.Size = new Size(126, 231);
            player_5.TabIndex = 9;
            player_5.TabStop = false;
            // 
            // player_6
            // 
            player_6.Location = new Point(672, 265);
            player_6.Name = "player_6";
            player_6.Size = new Size(126, 231);
            player_6.TabIndex = 10;
            player_6.TabStop = false;
            // 
            // dealer_2
            // 
            dealer_2.Location = new Point(144, 27);
            dealer_2.Name = "dealer_2";
            dealer_2.Size = new Size(126, 231);
            dealer_2.TabIndex = 11;
            dealer_2.TabStop = false;
            // 
            // dealer_3
            // 
            dealer_3.Location = new Point(276, 28);
            dealer_3.Name = "dealer_3";
            dealer_3.Size = new Size(126, 231);
            dealer_3.TabIndex = 12;
            dealer_3.TabStop = false;
            // 
            // dealer_4
            // 
            dealer_4.Location = new Point(408, 27);
            dealer_4.Name = "dealer_4";
            dealer_4.Size = new Size(126, 231);
            dealer_4.TabIndex = 13;
            dealer_4.TabStop = false;
            // 
            // dealer_5
            // 
            dealer_5.Location = new Point(540, 27);
            dealer_5.Name = "dealer_5";
            dealer_5.Size = new Size(126, 231);
            dealer_5.TabIndex = 14;
            dealer_5.TabStop = false;
            // 
            // dealer_6
            // 
            dealer_6.Location = new Point(672, 28);
            dealer_6.Name = "dealer_6";
            dealer_6.Size = new Size(126, 231);
            dealer_6.TabIndex = 15;
            dealer_6.TabStop = false;
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
            ClientSize = new Size(1061, 537);
            Controls.Add(score);
            Controls.Add(dealer_6);
            Controls.Add(dealer_5);
            Controls.Add(dealer_4);
            Controls.Add(dealer_3);
            Controls.Add(dealer_2);
            Controls.Add(player_6);
            Controls.Add(player_5);
            Controls.Add(player_4);
            Controls.Add(player_3);
            Controls.Add(player_2);
            Controls.Add(card_stack);
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
            ((System.ComponentModel.ISupportInitialize)card_stack).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)player_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealer_6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hit_Button;
        private Button Stand_Button;
        private PictureBox dealer_1;
        private PictureBox player_1;
        private PictureBox card_stack;
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
        private PictureBox dealer_3;
        private PictureBox dealer_4;
        private PictureBox dealer_5;
        private PictureBox dealer_6;
        private Label score;
    }
}
