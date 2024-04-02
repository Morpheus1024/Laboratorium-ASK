namespace Black_Jack
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
            Hit_Button = new Button();
            Stand_Button = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            menuStrip2 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(815, 231);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(815, 231);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(833, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 468);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1061, 24);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 537);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Stand_Button);
            Controls.Add(Hit_Button);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Hit_Button;
        private Button Stand_Button;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem graToolStripMenuItem;
        private ToolStripMenuItem starrtResetToolStripMenuItem;
        private ToolStripMenuItem grafikaToolStripMenuItem;
        private ToolStripMenuItem koniecToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem skin1ToolStripMenuItem;
        private ToolStripMenuItem skin2ToolStripMenuItem;
        private ToolStripMenuItem skin3ToolStripMenuItem;
        private MenuStrip menuStrip2;
    }
}
