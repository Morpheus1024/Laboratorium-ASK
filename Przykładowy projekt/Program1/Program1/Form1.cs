using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class ProgramPierwszy : Form
    {
        public ProgramPierwszy()
        {
            InitializeComponent();
            xb = true;
            OknoHelp = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Okno2 = new NoweOkno(1500);
            this.Okno2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Okno2Dial = new NoweOkno();
            this.Okno2Dial.ShowDialog();

            //           this.pictureBox1.Load("E:\\VStudio2017\\Obraz 036.jpg");
            //           this.label1.Text = "E:\\VStudio2017\\Obraz 036.jpg";
            //           this.label1.Text = "E:/VStudio2017/Obraz 036.jpg";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (xb == true)
            {
                xb = false; ;
                this.pictureBox1.Load("Obraz 082.jpg");
                this.label1.Text = "Obraz 082.jpg";
            }
            else
            {
                xb = true;
                this.pictureBox1.Load("Obraz 089.jpg");
                this.label1.Text = "Obraz 089.jpg";
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.ShowDialog();
            try
            {
                this.pictureBox2.Load(this.openFileDialog1.FileName);
                this.label2.Text = this.openFileDialog1.FileName;
            }
            catch (System.IO.FileNotFoundException ex2)
            {
                //                this.label2.Text = ex1.Message;
                MessageBox.Show(ex2.Message);
            }
            catch (Exception ex1)
            {
                //                this.label2.Text = ex1.Message;
                MessageBox.Show(ex1.Message);
            }
//            catch
//            {
//                this.label2.Text = "wystapił nieznany błąd";
//            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Okno2 = new NoweOkno(this);
            this.Okno2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = 4;
            y = 0;
            try
            {
                z = x / y;
            }
            catch (System.DivideByZeroException ex3)
            {
                MessageBox.Show(ex3.Message);
            }
        }
        private void Przycisk_Click(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            if (przycisk_X.Text == "1")
            {
                this.label2.Text = "Wcisnięto przycisk 1";
                this.Przycisk_1.BackColor = Color.Red;
                this.Przycisk_2.BackColor = Color.LightGray;
                this.Przycisk_3.BackColor = Color.LightGray;
                KolorTla_1 = przycisk_X.BackColor;    // Na potrzeby funkcji ->   Przycisk_MouseLeave()
            }
            if (przycisk_X.Text == "2")
            {
                this.label2.Text = "Wcisnięto przycisk 2";
                this.Przycisk_2.BackColor = Color.Red;
                this.Przycisk_1.BackColor = Color.LightGray;
                this.Przycisk_3.BackColor = Color.LightGray;
                KolorTla_2 = przycisk_X.BackColor;    // Na potrzeby funkcji ->   Przycisk_MouseLeave()
            }
            if (przycisk_X.Text == "3")
            {
                this.label2.Text = "Wcisnięto przycisk 3";
                this.Przycisk_3.BackColor = Color.Red;
                this.Przycisk_2.BackColor = Color.LightGray;
                this.Przycisk_1.BackColor = Color.LightGray;
                KolorTla_3 = przycisk_X.BackColor;    // Na potrzeby funkcji ->   Przycisk_MouseLeave()
            }
            if (OknoHelp != null) OknoHelp.Close();
        }

        private void ProgramPierwszy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                this.Przycisk_1.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.Przycisk_2.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.Przycisk_3.PerformClick();
            }


        }

        private void Przycisk_MouseHover(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            Point PolozeniePrzycisku = przycisk_X.Location;
            Point PolozenieOknaHelp;
            PolozenieOknaHelp = this.Location;
            PolozenieOknaHelp.X += PolozeniePrzycisku.X + 60;
            PolozenieOknaHelp.Y += PolozeniePrzycisku.Y + 100;
            switch (przycisk_X.Text)  {
                case "1":  KolorTla_1 = przycisk_X.BackColor;  break;
                case "2":  KolorTla_2 = przycisk_X.BackColor;  break;
                case "3":  KolorTla_3 = przycisk_X.BackColor;  break;
            }
            przycisk_X.BackColor = Color.Green;
            this.label2.Text = "Informacja dla przycisku nr " + przycisk_X.Text;
            OknoHelp = new OknoInfo(this, "Informacja dla przycisku nr " + przycisk_X.Text);
            OknoHelp.Show();
            OknoHelp.Location = PolozenieOknaHelp;
        }

        private void Przycisk_MouseLeave(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            switch (przycisk_X.Text)
            {
                case "1": przycisk_X.BackColor = KolorTla_1; break;
                case "2": przycisk_X.BackColor = KolorTla_2; break;
                case "3": przycisk_X.BackColor = KolorTla_3; break;
            }
            this.label2.Text = "";
            if (OknoHelp != null)    OknoHelp.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Okno4 = new Form4();
            this.Okno4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}