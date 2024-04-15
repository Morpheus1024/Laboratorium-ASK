using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ask2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            licznik_dobrych_ruchow = 0;
            this.licznik_czasu = 0;
            stopwatch = new Stopwatch();
            this.czy_pierwsza = 1;
            this.sredni_czas = 0;
            this.zliczanie = 0;
            czasy_reakcji.Add(0);
            MessageBox.Show($"W tym teście należy wcisnąć (obojętnie czy z klawiatury czy z myszki) przycisk odpowiadający zapalonej diodzie nad nim.");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Ustawienie interwału timera na 1000 ms (czyli 1 sekunda)      
            MessageBox.Show($"To jest pierwsza próba, teraz punkty nie będą zliczane, gra rozpocznie się automatycznie.");
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random dioda = new Random();
            int randomNumber = dioda.Next(1, 5);
            this.licznik_czasu++;
            if (randomNumber < 2 && this.licznik_czasu < 11)
            {
                this.pictureBox1.Load("zielony.png");
                this.pictureBox2.Load("czerwony.png");
                this.pictureBox3.Load("czerwony.png");
                this.pictureBox4.Load("czerwony.png");
                this.label1.Text = this.licznik_czasu.ToString();
            }
            else if (randomNumber < 3 && this.licznik_czasu < 11)
            {
                this.pictureBox1.Load("czerwony.png");
                this.pictureBox2.Load("zielony.png");
                this.pictureBox3.Load("czerwony.png");
                this.pictureBox4.Load("czerwony.png");
                this.label1.Text = this.licznik_czasu.ToString();
            }
            else if (randomNumber < 4 && this.licznik_czasu < 11)
            {
                this.pictureBox1.Load("czerwony.png");
                this.pictureBox2.Load("czerwony.png");
                this.pictureBox3.Load("zielony.png");
                this.pictureBox4.Load("czerwony.png");
                this.label1.Text = this.licznik_czasu.ToString();
            }
            else if (randomNumber < 5 && this.licznik_czasu < 11)
            {
                this.pictureBox1.Load("czerwony.png");
                this.pictureBox2.Load("czerwony.png");
                this.pictureBox3.Load("czerwony.png");
                this.pictureBox4.Load("zielony.png");
                this.label1.Text = this.licznik_czasu.ToString();
            }
            else
            {
                this.czy_pierwsza++;
                timer1.Stop();
            }


            if (this.czy_pierwsza > 1)
            {
                if (this.licznik_czasu == 11)
                {
                    MessageBox.Show($"Test ze zliczanymi punktami rozpocznie sie po zamknieciu tego okienka.");
                }
                timer1.Start();
                stopwatch.Start();

                if (randomNumber < 2 && this.licznik_czasu < 21)
                {
                    this.pictureBox1.Load("zielony.png");
                    this.pictureBox2.Load("czerwony.png");
                    this.pictureBox3.Load("czerwony.png");
                    this.pictureBox4.Load("czerwony.png");
                    this.label1.Text = this.licznik_czasu.ToString();
                }
                else if (randomNumber < 3 && this.licznik_czasu < 21)
                {
                    this.pictureBox1.Load("czerwony.png");
                    this.pictureBox2.Load("zielony.png");
                    this.pictureBox3.Load("czerwony.png");
                    this.pictureBox4.Load("czerwony.png");
                    this.label1.Text = this.licznik_czasu.ToString();
                }
                else if (randomNumber < 4 && this.licznik_czasu < 21)
                {
                    this.pictureBox1.Load("czerwony.png");
                    this.pictureBox2.Load("czerwony.png");
                    this.pictureBox3.Load("zielony.png");
                    this.pictureBox4.Load("czerwony.png");
                    this.label1.Text = this.licznik_czasu.ToString();
                }
                else if (randomNumber < 5 && this.licznik_czasu < 21)
                {
                    this.pictureBox1.Load("czerwony.png");
                    this.pictureBox2.Load("czerwony.png");
                    this.pictureBox3.Load("czerwony.png");
                    this.pictureBox4.Load("zielony.png");
                    this.label1.Text = this.licznik_czasu.ToString();
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show($"ilość dobrych ruchów:" + this.licznik_dobrych_ruchow + $"; skuteczność wyniosła:{(float)this.licznik_dobrych_ruchow / 10 * 100}%" +
                        $"; średni czas reakcji wyniósł:{(this.sredni_czas) / 10} sekundy");
                }
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                this.button1.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.button2.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.button3.PerformClick();
            }
            if (e.KeyChar == '4')
            {
                this.button4.PerformClick();
            }
            if (this.czy_pierwsza == 1)
            {
                licznik_dobrych_ruchow = 0;
                this.label2.Text = "Ruchy nie zostają zliczane";
            }
            else
                // Aktualizacja wyświetlanego licznika
                this.label2.Text = "Liczba dobrych ruchów: " + this.licznik_dobrych_ruchow;
        }

        private void Przycisk_Click(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            if (przycisk_X.Text == "1")
            {
                this.button1.BackColor = Color.Green;
                this.button2.BackColor = Color.LightGray;
                this.button3.BackColor = Color.LightGray;
                this.button4.BackColor = Color.LightGray;
                if (this.pictureBox1.ImageLocation == "zielony.png")
                {
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pictureBox1);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "2")
            {
                this.button1.BackColor = Color.LightGray;
                this.button2.BackColor = Color.Green;
                this.button3.BackColor = Color.LightGray;
                this.button4.BackColor = Color.LightGray;
                if (this.pictureBox2.ImageLocation == "zielony.png")
                {
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pictureBox2);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "3")
            {
                this.button1.BackColor = Color.LightGray;
                this.button2.BackColor = Color.LightGray;
                this.button3.BackColor = Color.Green;
                this.button4.BackColor = Color.LightGray;
                if (this.pictureBox3.ImageLocation == "zielony.png")
                {
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pictureBox3);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "4")
            {
                this.button1.BackColor = Color.LightGray;
                this.button2.BackColor = Color.LightGray;
                this.button3.BackColor = Color.LightGray;
                this.button4.BackColor = Color.Green;
                if (this.pictureBox4.ImageLocation == "zielony.png")
                {
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pictureBox4);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (this.czy_pierwsza == 1)
            {
                licznik_dobrych_ruchow = 0;
                this.label2.Text = "Ruchy nie zostają zliczane";
            }
            else
                // Aktualizacja wyświetlanego licznika
                this.label2.Text = "Liczba dobrych ruchów: " + this.licznik_dobrych_ruchow;
        }

        private void SprawdzZliczanieCzasu(PictureBox pictureBox)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }
            else
            {
                stopwatch.Stop();
            }

            if (pictureBox.ImageLocation == "zielony.png")
            {
                if (czy_pierwsza != 1)
                {
                    TimeSpan elapsed = stopwatch.Elapsed;
                    float elapsedTimeInSeconds = (float)elapsed.TotalSeconds;
                    czasy_reakcji.Add(elapsedTimeInSeconds);
                    float sumaCzasow = czasy_reakcji.Sum();
                    this.sredni_czas = sumaCzasow / czasy_reakcji.Count;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
