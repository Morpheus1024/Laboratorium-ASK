using System.Drawing;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.curretSkin = 0;
            this.karty_playera = new List<Karta>();
            this.karty_dealera = new List<Karta>();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1KeyDown);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Stand_Button.Enabled = false;
            this.Hit_Button.Enabled = false;
            this.curretSkin = 0;
            this.talia.Clear();
            this.koniec_gry = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void starrtResetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oknoPonocyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void Shuffle()
        {

            Random rnd = new Random();
            Int16 kolor = 0;
            int wartosc = 0;
            //generowanie talii
            for (int i = 0; i < 52; i++)
            {   wartosc = (i % 13) + 1;
                if (i % 13 == 0 && i != 0) kolor++;

                Karta karta = new Karta();
                karta.wartosc = wartosc;
                karta.kolor = kolor;
                this.talia.Add(karta);
                // AS = 1
                // 2-10 = 2-10
                //alet = 11
                //dama = 12
                //kr�l = 13
            }

            //tasowanie kart
            for (int i = 0; i < 52; i++)
            {
                int r = rnd.Next(52);
                Karta temp = this.talia[i];
                this.talia[i] = this.talia[r];
                this.talia[r] = temp;
            }
        }
        private void AddCardToPlayer(int ilosc, List<Karta> reka_gracza)
        {
            for (int i = 0; i < ilosc; i++)
            {
                reka_gracza.Add(this.talia.First());
                this.talia.Remove(this.talia.First());

            }
        }

        private void WriteScoreToLabel(List<Karta> reka_gracza)
        {
            int suma_A11 = 0; //Asa liczymy jako 11
            int suma_A1 = 0; //Asa liczymy jako 1


            for (int i = 0; i < reka_gracza.Count(); i++)
            {
                if (reka_gracza[i].wartosc == 1)//gdy jest AS
                {
                    suma_A11 += 11;
                    suma_A1 += 1;
                }
                else if (reka_gracza[i].wartosc>10)//gdy jest walet, dama, król
                {
                    suma_A11 += 10;
                    suma_A1 += 10;
                }
                else if (reka_gracza[i].wartosc <= 10)//gdy jest 2-10
                {
                    suma_A11 += reka_gracza[i].wartosc;
                    suma_A1 += reka_gracza[i].wartosc;
                }   
            }
            score.Text = ("Punkty - Duży AS:" + suma_A11 + ", Mały AS:" + suma_A1);
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Stand_Button.Enabled = true;
            this.Hit_Button.Enabled = true;

            this.karty_dealera.Clear();
            this.karty_playera.Clear();
            this.talia.Clear();
            //rest grafiki
            dealer_1.Image = null;
            dealer_2.Image = null;
            dealer_3.Image = null;
            dealer_4.Image = null;
            dealer_5.Image = null;
            dealer_6.Image = null;

            player_1.Image = null;
            player_2.Image = null;
            player_3.Image = null;
            player_4.Image = null;
            player_5.Image = null;
            player_6.Image = null;

            //tasowanie kart
            Shuffle();
            AddCardToPlayer(2, karty_playera);

            //dodane kart do reki dealera
            AddCardToPlayer(2, karty_dealera); 

            //�adowanie kart
            LoadCardsOnScreen(this.curretSkin, 2, 2);

            WriteScoreToLabel(this.karty_playera);

        }

        private void Hit_Button_Click(object sender, EventArgs e)
        {

            int ilosc_kart = this.karty_playera.Count;

            if (ilosc_kart > 6)
            {
                MessageBox.Show("Nie możesz mieć więcej niż 6 kart");
                return;
            }
            else
            {
                AddCardToPlayer(1, karty_playera);
                int kolor_karty = karty_playera[ilosc_kart].kolor;
                string kolor = "";
                switch (kolor_karty)
                {
                    case 0:
                        kolor = "karo";
                        break;
                    case 1:
                        kolor = "kier";
                        break;
                    case 2:
                        kolor = "pik";
                        break;
                    case 3:
                        kolor = "trefl";
                        break;
                }
                int wartosc_karty = karty_playera[ilosc_kart].wartosc;
                string wartosc = "";
                switch (wartosc_karty)
                {
                    case 1:
                        wartosc = "A";
                        break;
                    case 11:
                        wartosc = "J";
                        break;
                    case 12:
                        wartosc = "Q";
                        break;
                    case 13:
                        wartosc = "K";
                        break;
                    default:
                        wartosc = wartosc_karty.ToString();
                        break;
                }

                PictureBox pb = (PictureBox)this.Controls.Find("player_" + (ilosc_kart+1), true)[0];
                //dostosowanie rozmiaru grafiki do rozmiaru pictureboxa
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromFile("assets/" + (this.curretSkin + 1) + "/" + kolor + "/" + wartosc + ".png");

                //aktualizacja score
                WriteScoreToLabel(karty_playera);
            }


        }

        private void LoadCardsOnScreen(int skin, int liczbna_kart_gracz, int liczba_kart_dealera)
        {
            //karty dealear:
            skin = skin + 1;

            for (int i = 1; i <= liczba_kart_dealera; i++)
            {
                if (i == 1)
                {
                    dealer_1.SizeMode = PictureBoxSizeMode.StretchImage;
                    dealer_1.Image = Image.FromFile("assets/" + skin + "/hidden.png");
                    continue;
                }
                int kolor_karty = this.karty_dealera[i - 1].kolor;
                string kolor = "";
                switch (kolor_karty)
                {
                    case 0:
                        kolor = "karo";
                        break;
                    case 1:
                        kolor = "kier";
                        break;
                    case 2:
                        kolor = "pik";
                        break;
                    case 3:
                        kolor = "trefl";
                        break;
                }

                int wartosc_karty = this.karty_dealera[i - 1].wartosc;
                string wartosc = "";
                switch (wartosc_karty)
                {
                    case 1:
                        wartosc = "A";
                        break;
                    case 11:
                        wartosc = "J";
                        break;
                    case 12:
                        wartosc = "Q";
                        break;
                    case 13:
                        wartosc = "K";
                        break;
                    default:
                        wartosc = wartosc_karty.ToString();
                        break;
                }
                PictureBox pb = (PictureBox)this.Controls.Find("dealer_" + i, true)[0];
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromFile("assets/" + (this.curretSkin + 1) + "/" + kolor + "/" + wartosc + ".png");
            }


            //karty gracza
            for (int i = 0; i < +liczbna_kart_gracz; i++)
            {
                int kolor_karty = this.karty_playera[i].kolor;
                string kolor = "";
                switch (kolor_karty)
                {
                    case 0:
                        kolor = "karo";
                        break;
                    case 1:
                        kolor = "kier";
                        break;
                    case 2:
                        kolor = "pik";
                        break;
                    case 3:
                        kolor = "trefl";
                        break;
                }

                int wartosc_karty = karty_playera[i].wartosc;
                string wartosc = "";
                switch (wartosc_karty)
                {
                    case 1:
                        wartosc = "A";
                        break;
                    case 11:
                        wartosc = "J";
                        break;
                    case 12:
                        wartosc = "Q";
                        break;
                    case 13:
                        wartosc = "K";
                        break;
                    default:
                        wartosc = wartosc_karty.ToString();
                        break;
                }
                PictureBox pb = (PictureBox)this.Controls.Find("player_" + (i+1), true)[0];
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromFile("assets/" + (this.curretSkin + 1) + "/" + kolor + "/" + wartosc + ".png");
            }

        }

        private void oknoPomocyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wyświetlenie messageboxa z textem podpowiedzi
            MessageBox.Show("Skróty klawiszowe: \n" +
                            "F1 - wyświetlenie okna pomocy\n" +
                            "N - nowa gra\n" +
                            "H - przycisk Hit\n" +
                            "1 - Skin 1\n" +
                            "2 - Skin 2\n" +
                            "3 - Skin 3\n" +
                            "Q - wyjście z gry\n");
        }
        void Form1KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                oknoPomocyToolStripMenuItem_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.N)
            {
                nowaGraToolStripMenuItem_Click(this, new EventArgs());
            }
            if ((e.KeyCode == Keys.H) && (this.Hit_Button.Enabled == true))
            {
                Hit_Button_Click(this, new EventArgs());
            }
            if ((e.KeyCode == Keys.S) && (this.Stand_Button.Enabled == true))
            {
                Stand_Button_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.D1)
            {
                skin1ToolStripMenuItem_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.D2)
            {
                skin2ToolStripMenuItem_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.D3)
            {
                skin3ToolStripMenuItem_Click(this, new EventArgs());
            }
        }

        private void Stand_Button_Click(object sender, EventArgs e)
        {   
            //przyciski wyłączają się po kliknięciu
            this.Stand_Button.Enabled = false;
            this.Hit_Button.Enabled = false;

            this.koniec_gry = true;

            //wyświetlenie kart dealera
            int ilosc_kart = 0;
            ilosc_kart = this.karty_dealera.Count;
            for (int i = 1; i <= ilosc_kart; i++)
            {
                int kolor_karty = karty_dealera[i - 1].kolor;
                string kolor = "";
                switch (kolor_karty)
                {
                    case 0:
                        kolor = "karo";
                        break;
                    case 1:
                        kolor = "kier";
                        break;
                    case 2:
                        kolor = "pik";
                        break;
                    case 3:
                        kolor = "trefl";
                        break;
                }

                int wartosc_karty = karty_dealera[i - 1].wartosc;
                string wartosc = "";
                switch (wartosc_karty)
                {
                    case 1:
                        wartosc = "A";
                        break;
                    case 11:
                        wartosc = "J";
                        break;
                    case 12:
                        wartosc = "Q";
                        break;
                    case 13:
                        wartosc = "K";
                        break;
                    default:
                        wartosc = wartosc_karty.ToString();
                        break;
                }
                PictureBox pb = (PictureBox)this.Controls.Find("dealer_" + i, true)[0];
                pb.Image = Image.FromFile("assets/" + (this.curretSkin + 1) + "/" + kolor + "/" + wartosc + ".png");
            }

            //obliczenie punktów dealera
            int suma_A11_dealer = 0; //Asa liczymy jako 11
            int suma_A1_dealer = 0; //Asa liczymy jako 1
            foreach (Karta karta in karty_dealera)
            {
                if (karta.wartosc == 'A')
                {
                    suma_A11_dealer += 11;
                    suma_A1_dealer += 1;
                }
                else if ((karta.wartosc == 'K')||(karta.wartosc=='Q')||(karta.wartosc=='J'))
                {
                    suma_A11_dealer += 10;
                    suma_A1_dealer += 10;
                }
                else
                {
                    suma_A11_dealer += karta.wartosc;
                    suma_A1_dealer += karta.wartosc;
                }
            }

            //obliczenie punktów gracza
            int suma_A11_gracza = 0; //Asa liczymy jako 11
            int suma_A1_gracza = 0; //Asa liczymy jako 1
            foreach (Karta karta in karty_playera)
            {
                if (karta.wartosc == 1)
                {
                    suma_A11_gracza += 11;
                    suma_A1_gracza += 1;
                }
                else if ((karta.wartosc == 'K') || (karta.wartosc == 'Q') || (karta.wartosc == 'J'))
                {
                    suma_A11_gracza += 10;
                    suma_A1_gracza += 10;
                }
                else
                {
                    suma_A11_gracza += karta.wartosc;
                    suma_A1_gracza += karta.wartosc;
                }
            }

            //sprawdzenie kto wygrał
            if (suma_A11_dealer > 21 && suma_A1_dealer > 21)
            {
                MessageBox.Show("Gracz wygrywa! Dealer przekroczył 21 punktów");
            }
            else if (suma_A11_gracza > 21 && suma_A1_gracza > 21)
            {
                MessageBox.Show("Dealer wygrywa! Gracz przekroczył 21 punktów");
            }
            else if (suma_A11_dealer > suma_A11_gracza && suma_A11_dealer <= 21)
            {
                MessageBox.Show("Dealer wygrywa! Dealer ma więcej punktów");
            }
            else if (suma_A1_dealer > suma_A1_gracza && suma_A1_dealer <= 21)
            {
                MessageBox.Show("Dealer wygrywa! Dealer ma więcej punktów");
            }
            else if (suma_A11_dealer == suma_A11_gracza)
            {
                MessageBox.Show("Remis! Obaj mają tyle samo punktów");
            }
            else if (suma_A1_dealer == suma_A1_gracza)
            {
                MessageBox.Show("Remis! Obaj mają tyle samo punktów");
            }
            else
            {
                MessageBox.Show("Gracz wygrywa! Gracz ma więcej punktów");
            }
        }

        private void skin1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.koniec_gry == false)
            {
                this.curretSkin = 0;
                this.BackColor = Color.FromName("Control");
                LoadCardsOnScreen(this.curretSkin, this.karty_playera.Count(), this.karty_dealera.Count());
            }

        }

        private void skin2ToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (this.koniec_gry == false)
            {
                this.curretSkin = 1;
                this.BackColor = Color.FromArgb(23, 146, 153);
                LoadCardsOnScreen(this.curretSkin, this.karty_playera.Count(), this.karty_dealera.Count());
            }
        }

        private void skin3ToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if (this.koniec_gry==false)
            { 
                this.curretSkin = 2;
                this.BackColor = Color.FromArgb(64, 160, 43);
                LoadCardsOnScreen(this.curretSkin, this.karty_playera.Count(), this.karty_dealera.Count()); 
            }


        }

        private void player_3_Click(object sender, EventArgs e)
        {

        }
    }
}