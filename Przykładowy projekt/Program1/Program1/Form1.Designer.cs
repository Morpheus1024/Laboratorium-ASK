using System.Drawing;     // Dla zmiennej typu Color

namespace Program1
{
    partial class ProgramPierwszy
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        private bool xb;
        private NoweOkno Okno2;
        private NoweOkno Okno2Dial;
        private Color KolorTla_1;
        private Color KolorTla_2;
        private Color KolorTla_3;
        private OknoInfo OknoHelp;
        private Form4 Okno4;


        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rysujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Przycisk_1 = new System.Windows.Forms.Button();
            this.Przycisk_2 = new System.Windows.Forms.Button();
            this.Przycisk_3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Otwórz Okno2 jako dialogowe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Otwórz Okno2 jako zwykłe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Program1.Properties.Resources.xd2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(29, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rysujToolStripMenuItem,
            this.kasujToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // rysujToolStripMenuItem
            // 
            this.rysujToolStripMenuItem.Name = "rysujToolStripMenuItem";
            this.rysujToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rysujToolStripMenuItem.Text = "Rysuj";
            // 
            // kasujToolStripMenuItem
            // 
            this.kasujToolStripMenuItem.Name = "kasujToolStripMenuItem";
            this.kasujToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.kasujToolStripMenuItem.Text = "Kasuj";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(327, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Otwórz Okno2 i przekaż wskazanie do okna głównego";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Próba dzielenia przez zero";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            // 
            // Przycisk_1
            // 
            this.Przycisk_1.Location = new System.Drawing.Point(42, 39);
            this.Przycisk_1.Name = "Przycisk_1";
            this.Przycisk_1.Size = new System.Drawing.Size(50, 49);
            this.Przycisk_1.TabIndex = 9;
            this.Przycisk_1.Text = "1";
            this.Przycisk_1.UseVisualStyleBackColor = true;
            this.Przycisk_1.Click += new System.EventHandler(this.Przycisk_Click);
            this.Przycisk_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            this.Przycisk_1.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.Przycisk_1.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // Przycisk_2
            // 
            this.Przycisk_2.Location = new System.Drawing.Point(121, 39);
            this.Przycisk_2.Name = "Przycisk_2";
            this.Przycisk_2.Size = new System.Drawing.Size(49, 49);
            this.Przycisk_2.TabIndex = 10;
            this.Przycisk_2.Text = "2";
            this.Przycisk_2.UseVisualStyleBackColor = true;
            this.Przycisk_2.Click += new System.EventHandler(this.Przycisk_Click);
            this.Przycisk_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            this.Przycisk_2.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.Przycisk_2.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // Przycisk_3
            // 
            this.Przycisk_3.Location = new System.Drawing.Point(200, 39);
            this.Przycisk_3.Name = "Przycisk_3";
            this.Przycisk_3.Size = new System.Drawing.Size(49, 49);
            this.Przycisk_3.TabIndex = 11;
            this.Przycisk_3.Text = "3";
            this.Przycisk_3.UseVisualStyleBackColor = true;
            this.Przycisk_3.Click += new System.EventHandler(this.Przycisk_Click);
            this.Przycisk_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            this.Przycisk_3.MouseLeave += new System.EventHandler(this.Przycisk_MouseLeave);
            this.Przycisk_3.MouseHover += new System.EventHandler(this.Przycisk_MouseHover);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(633, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Otwórz okno 4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Program1.Properties.Resources.xd2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(42, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Program1.Properties.Resources.xd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(429, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ProgramPierwszy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program1.Properties.Resources._060908_175501;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Przycisk_3);
            this.Controls.Add(this.Przycisk_2);
            this.Controls.Add(this.Przycisk_1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProgramPierwszy";
            this.Text = "Program nr 1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramPierwszy_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rysujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button Przycisk_1;
        public System.Windows.Forms.Button Przycisk_2;
        public System.Windows.Forms.Button Przycisk_3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
    }
}

