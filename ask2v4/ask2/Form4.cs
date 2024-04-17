using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ask2
{
    public partial class Form4 : Form
    {
        public Form4(Form1 OknoRodz)
        {
            this.OknoRodzic = OknoRodz;
            MessageBox.Show($"Test polega na wciskaniu przycisku w miejscu w którym przecinają się wiersze i kolumny zapalonych diod.");
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1300; // Ustawienie interwału timera na 1000 ms (czyli 1 sekunda)      
            MessageBox.Show($"To jest pierwsza próba, teraz punkty nie będą zliczane, gra rozpocznie się automatycznie.");
            timer1.Start();
            stopwatch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random dioda = new Random();
            int wiersze = dioda.Next(1, 6);
            int kolumny = dioda.Next(6, 11);
            this.licznik_czasu++;
            this.button1.BackColor = Color.LightGray;
            this.button2.BackColor = Color.LightGray;
            this.button3.BackColor = Color.LightGray;
            this.button4.BackColor = Color.LightGray;
            this.button5.BackColor = Color.LightGray;
            this.button6.BackColor = Color.LightGray;
            this.button7.BackColor = Color.LightGray;
            this.button8.BackColor = Color.LightGray;
            this.button9.BackColor = Color.LightGray;
            this.button10.BackColor = Color.LightGray;
            this.button11.BackColor = Color.LightGray;
            this.button12.BackColor = Color.LightGray;
            this.button13.BackColor = Color.LightGray;
            this.button14.BackColor = Color.LightGray;
            this.button15.BackColor = Color.LightGray;
            this.button16.BackColor = Color.LightGray;
            this.button17.BackColor = Color.LightGray;
            this.button18.BackColor = Color.LightGray;
            this.button19.BackColor = Color.LightGray;
            this.button20.BackColor = Color.LightGray;
            this.button21.BackColor = Color.LightGray;
            this.button22.BackColor = Color.LightGray;
            this.button23.BackColor = Color.LightGray;
            this.button24.BackColor = Color.LightGray;
            this.button25.BackColor = Color.LightGray;
            if(licznik_czasu < 11)
            {
                this.licznik_dobrych_ruchow = 0;
                switch (wiersze)
                {
                    case 1:
                        pb1.Load("czerwony.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");             
                        break;
                    case 2:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("czerwony.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 3:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("czerwony.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 4:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("czerwony.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 5:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        pb5.Load("czerwony.png");
                        break;
                }

                switch (kolumny)
                {
                    case 6:
                        pb6.Load("czerwony.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("pomaranczowy.png");
                        break;
                    case 7:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("czerwony.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("pomaranczowy.png");
                        break;
                    case 8:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("czerwony.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("pomaranczowy.png"); ;
                        break;
                    case 9:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("czerwony.png");
                        pb10.Load("pomaranczowy.png");
                        break;
                    case 10:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("czerwony.png");
                        break;
                }
            }
            else if (licznik_czasu == 11)
            {
                this.licznik_dobrych_ruchow = 0;
                timer1.Stop();
                MessageBox.Show($"Test ze zliczanymi punktami rozpocznie sie po zamknieciu tego okienka.");
                zmienna++;
                timer1.Start();
            }
            else if (licznik_czasu > 11 && licznik_czasu < 38)
            { 
                zmienna++;
                stopwatch.Start();
                switch (wiersze)
                {
                    case 1:
                        pb1.Load("czerwony.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 2:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("czerwony.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 3:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("czerwony.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 4:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("czerwony.png");
                        pb5.Load("pomaranczowy.png");
                        break;
                    case 5:
                        pb1.Load("pomaranczowy.png");
                        pb2.Load("pomaranczowy.png");
                        pb3.Load("pomaranczowy.png");
                        pb4.Load("pomaranczowy.png");
                        pb5.Load("pomaranczowy.png");
                        pb5.Load("czerwony.png");
                        break;
                }

                switch (kolumny)
                {
                    case 6:
                        pb6.Load("czerwony.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("pomaranczowy.png");
                        break;
                    case 7:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("czerwony.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("pomaranczowy.png");
                        break;
                    case 8:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("czerwony.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("pomaranczowy.png"); ;
                        break;
                    case 9:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("czerwony.png");
                        pb10.Load("pomaranczowy.png");
                        break;
                    case 10:
                        pb6.Load("pomaranczowy.png");
                        pb7.Load("pomaranczowy.png");
                        pb8.Load("pomaranczowy.png");
                        pb9.Load("pomaranczowy.png");
                        pb10.Load("czerwony.png");
                        break;
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"ilość dobrych ruchów:" + this.licznik_dobrych_ruchow + $"; skuteczność wyniosła:{(float)this.licznik_dobrych_ruchow / zmienna * 100}%" +
                        $"; średni czas reakcji wyniósł:{((float)this.sredni_czas) / this.licznik_dobrych_ruchow} sekundy");
                this.Close();

                licznik3 = licznik_dobrych_ruchow / zmienna * 100;
                czas3 = this.sredni_czas/this.licznik_dobrych_ruchow;
                this.OknoRodzic.label5.Text = this.licznik3.ToString();
                this.OknoRodzic.label6.Text = this.czas3.ToString();
            }
        }

        private void Przycisk_Click(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender; 
            if (przycisk_X.Text == "1")
            {
                if (this.pb1.ImageLocation == "czerwony.png" && this.pb6.ImageLocation == "czerwony.png")
                {
                    this.button1.BackColor = Color.Green;  
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb1);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "2")
            {  
                if (this.pb2.ImageLocation == "czerwony.png" && this.pb6.ImageLocation == "czerwony.png")
                {
                    this.button2.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb2);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "3")
            {
                if (this.pb3.ImageLocation == "czerwony.png" && this.pb6.ImageLocation == "czerwony.png")
                {
                    this.button3.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb3);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "4")
            {
                if (this.pb4.ImageLocation == "czerwony.png" && this.pb6.ImageLocation == "czerwony.png")
                {
                    this.button4.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb4);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "5")
            {
                if (this.pb5.ImageLocation == "czerwony.png" && this.pb6.ImageLocation == "czerwony.png")
                {
                    this.button5.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb5);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "6")
            {
                if (this.pb1.ImageLocation == "czerwony.png" && this.pb7.ImageLocation == "czerwony.png")
                { 
                    this.button6.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb1);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "7")
            {
                if (this.pb2.ImageLocation == "czerwony.png" && this.pb7.ImageLocation == "czerwony.png")
                {
                    this.button7.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb2);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "8")
            {
                if (this.pb3.ImageLocation == "czerwony.png" && this.pb7.ImageLocation == "czerwony.png")
                {
                    this.button8.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb3);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "9")
            {
                if (this.pb4.ImageLocation == "czerwony.png" && this.pb7.ImageLocation == "czerwony.png")
                {
                    this.button9.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb4);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "10")
            {
                if (this.pb5.ImageLocation == "czerwony.png" && this.pb7.ImageLocation == "czerwony.png")
                {
                    this.button10.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb5);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "11")
            {
                if (this.pb1.ImageLocation == "czerwony.png" && this.pb8.ImageLocation == "czerwony.png")
                {
                    this.button11.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb1);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "12")
            {
                if (this.pb2.ImageLocation == "czerwony.png" && this.pb8.ImageLocation == "czerwony.png")
                {
                    this.button12.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb2);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "13")
            {
                if (this.pb3.ImageLocation == "czerwony.png" && this.pb8.ImageLocation == "czerwony.png")
                {
                    this.button13.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb3);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "14")
            {
                if (this.pb4.ImageLocation == "czerwony.png" && this.pb8.ImageLocation == "czerwony.png")
                {
                    this.button14.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb4);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "15")
            {
                if (this.pb5.ImageLocation == "czerwony.png" && this.pb8.ImageLocation == "czerwony.png")
                {
                    this.button15.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb5);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "16")
            {
                if (this.pb1.ImageLocation == "czerwony.png" && this.pb9.ImageLocation == "czerwony.png")
                {
                    this.button16.BackColor = Color.Green;
                    SprawdzZliczanieCzasu(pb1);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "17")
            {
                if (this.pb2.ImageLocation == "czerwony.png" && this.pb9.ImageLocation == "czerwony.png")
                {
                    this.button17.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb2);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "18")
            {
                if (this.pb3.ImageLocation == "czerwony.png" && this.pb9.ImageLocation == "czerwony.png")
                {
                    this.button18.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb3);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "19")
            {
                if (this.pb4.ImageLocation == "czerwony.png" && this.pb9.ImageLocation == "czerwony.png")
                {
                    this.button19.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb4);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "20")
            {
                if (this.pb5.ImageLocation == "czerwony.png" && this.pb9.ImageLocation == "czerwony.png")
                {
                    this.button20.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb5);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "21")
            {
                if (this.pb1.ImageLocation == "czerwony.png" && this.pb10.ImageLocation == "czerwony.png")
                {
                    this.button21.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb1);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "22")
            {
                if (this.pb2.ImageLocation == "czerwony.png" && this.pb10.ImageLocation == "czerwony.png")
                {
                    this.button22.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb2);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "23")
            {
                if (this.pb3.ImageLocation == "czerwony.png" && this.pb10.ImageLocation == "czerwony.png")
                {
                    this.button23.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb3);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "24")
            {
                if (this.pb4.ImageLocation == "czerwony.png" && this.pb10.ImageLocation == "czerwony.png")
                {
                    this.button24.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb4);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
            if (przycisk_X.Text == "25")
            {
                if (this.pb5.ImageLocation == "czerwony.png" && this.pb10.ImageLocation == "czerwony.png")
                {
                    this.button25.BackColor = Color.Green;
                    this.licznik_dobrych_ruchow++;
                    SprawdzZliczanieCzasu(pb5);
                }
                else
                {
                    this.licznik_dobrych_ruchow--;
                }
            }
        }
        private void SprawdzZliczanieCzasu(PictureBox pictureBox)
        {
            if (pictureBox.ImageLocation == "czerwony.png")
            {
                if (this.licznik_czasu > 11)
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
