using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ask2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            stopwatch = new Stopwatch();
            InitializeComponent();
            czy_pierwsza = 1;
            wystapienia = 0;
            MessageBox.Show($"W tym zadaniu należy wcisnąc przycisk 'Start' w momencie, w którym usłyszy się dźwięk oraz zapali kolor zielony.");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Ustawienie interwału timera na 1000 ms (czyli 1 sekunda)      
            MessageBox.Show($"To jest pierwsza próba, teraz punkty nie będą zliczane, gra rozpocznie się automatycznie.");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Ścieżka do pliku dźwiękowego
            string sciezkaDoDzwieku = @"C:\Users\Mateusz\Desktop\l1\ask2\ask2\bin\Debug\click-button-166324.wav";

            // Tworzenie obiektu SoundPlayer z podaną ścieżką dźwiękową
            SoundPlayer player = new SoundPlayer(sciezkaDoDzwieku);

            Random dioda = new Random();
            int randomNumber = dioda.Next(1, 9);
            this.licznik_czasu++;
            if (randomNumber == 1 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("zielony.png");
                this.zmienna = 1;
            }
            else if (randomNumber == 2 && this.licznik_czasu < 11)
            {
                this.pictureBox1.Load("zielony.png");
                player.Play();
                stopwatch.Start();
                this.zmienna = 2;
                this.wystapienia++;
            }
            else if (randomNumber == 3 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("czerwony.png");
                this.zmienna = 1;
            }
            else if (randomNumber == 4 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("czerwony.png");
                player.Play();
                this.zmienna = 1;
            }
            else if (randomNumber == 5 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("niebieski.png");
              
                this.zmienna = 1;

            }
            else if (randomNumber == 6 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("niebieski.png");
                player.Play();

                this.zmienna = 1;
            }
            else if (randomNumber == 7 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("fioletowy.png");

                this.zmienna = 1;
            }
            else if (randomNumber == 8 && this.licznik_czasu < 11)
            {
                stopwatch.Stop();
                this.pictureBox1.Load("fioletowy.png");
                player.Play();

                this.zmienna = 1;
            }
            else if(this.czy_pierwsza == 1)
            {
                stopwatch.Stop();
                this.czy_pierwsza++;
                timer1.Stop();
            }

            if (this.czy_pierwsza > 1)
            {
                if (this.licznik_czasu == 11)
                {
                    stopwatch.Stop();
                    MessageBox.Show($"Test ze zliczanymi punktami rozpocznie sie po zamknieciu tego okienka.");
                    timer1.Start();
                }
                if (randomNumber == 1 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("zielony.png");
                    this.zmienna = 1;
                }
                else if (randomNumber == 2 && this.licznik_czasu < 31)
                {
                    this.pictureBox1.Load("zielony.png");
                    player.Play();
                    stopwatch.Start();
                    this.zmienna = 2;
                    this.wystapienia++;
                }
                else if (randomNumber == 3 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("czerwony.png");
                    this.zmienna = 1;
                }
                else if (randomNumber == 4 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("czerwony.png");
                    player.Play();
                    this.zmienna = 1;
                }
                else if (randomNumber == 5 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("niebieski.png");
                    this.zmienna = 1;

                }
                else if (randomNumber == 6 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("niebieski.png");
                    player.Play();
                    this.zmienna = 1;
                }
                else if (randomNumber == 7 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("fioletowy.png");
                    this.zmienna = 1;
                }
                else if (randomNumber == 8 && this.licznik_czasu < 31)
                {
                    stopwatch.Stop();
                    this.pictureBox1.Load("fioletowy.png");
                    player.Play();
                    this.zmienna = 1;
                }
                else if (this.licznik_czasu == 31)
                {
                    timer1.Stop();
                    MessageBox.Show($"Skuteczność wynosi:." + (float)this.licznik_dobrych_ruchow / (float)this.wystapienia * 100 + "% a średni czas reakcji wynosi: " + this.sredni_czas / this.licznik_dobrych_ruchow + "sek.");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            if (przycisk_X.Text == "Start")
            {
                this.button1.BackColor = Color.LightBlue;
                if (this.czy_pierwsza != 1)
                {
                    if (this.pictureBox1.ImageLocation == "zielony.png" && zmienna == 2)
                    {
                        this.licznik_dobrych_ruchow++;
                        SprawdzZliczanieCzasu(pictureBox1);
                    }
                    else
                    {
                        this.licznik_dobrych_ruchow--;
                    }
                }
            }
        }
                
        private void SprawdzZliczanieCzasu(PictureBox pictureBox)
        {
            if (pictureBox.ImageLocation == "zielony.png" && zmienna == 2)
            {
                if (czy_pierwsza != 1)
                {
                    stopwatch.Stop();
                    TimeSpan elapsed = stopwatch.Elapsed;
                    float elapsedTimeInSeconds = (float)elapsed.TotalSeconds;
                    czasy_reakcji.Add(elapsedTimeInSeconds);
                    float sumaCzasow = czasy_reakcji.Sum();
                    this.sredni_czas = sumaCzasow / czasy_reakcji.Count;
                }
            }
        }
    }
}
