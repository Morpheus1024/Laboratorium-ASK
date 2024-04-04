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
            curretSkin = 0;
            this.talia = new List<Karta>();
            this.stos = new LinkedList<Karta>();
            this.karty_playera = new List<Karta>();
            this.karty_dealera = new List<Karta>();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1KeyDown);
            this.Stand_Button.Enabled = false;
            this.Hit_Button.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            //generowanie talii
            for (int i = 0; i < 52; i++)
            {
                this.talia.Add(new Karta());
                this.talia[i].wartosc = (i % 13) + 1;

                if (i % 13 == 0 && i != 0) kolor++;
                this.talia[i].kolor = kolor;
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
            //dodanie kart na stos
            for (int i = 0; i < 52; i++)
            {
                this.stos.AddFirst(this.talia[i]);
            }

        }
        private List<Karta> AddCardToPlayer(int ilosc, ref List<Karta> reka_gracza)
        {
            for (int i = 0; i < ilosc; i++)
            {
                //Karta karta = stos.Peek();
                //stos.Pop();

                reka_gracza.Add(this.stos.First());
                this.stos.RemoveFirst();
            }
            return reka_gracza;
        }

        private void WriteScoreToLabel(List<Karta> reka_gracza, bool zerowanie)
        {
            int suma_A11 = 0; //Asa liczymy jako 11
            int suma_A1 = 0; //Asa liczymy jako 1
            if (zerowanie)
            {
                suma_A11 = 0;
                suma_A1 = 0;
            }

            foreach (Karta karta in reka_gracza)
            {
                if (karta.wartosc == 1)
                {
                    suma_A11 += 11;
                    suma_A1 += 1;
                }
                else if (karta.wartosc >= 10)
                {
                    suma_A11 += 10;
                    suma_A1 += 10;
                }
                else
                {
                    suma_A11 += karta.wartosc;
                    suma_A1 += karta.wartosc;
                }
            }
            score.Text = ("Punkty - Duży AS:" + suma_A11 + ", Mały AS:" + suma_A1);
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Stand_Button.Enabled = true;
            this.Hit_Button.Enabled = true;
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

            //reset labelu ze scorem
            this.score.Text = ("Punkty:");

            //reset skin�w
            this.curretSkin = 0;

            //�adowanie kart
            LoadCardsOnScreen(this.curretSkin, 2, 2);

            WriteScoreToLabel(karty_playera, true);

        }

        private void Hit_Button_Click(object sender, EventArgs e)
        {
            int ilosc_kart = 0;
            this.karty_playera = AddCardToPlayer(1, ref karty_playera);
            //for(int i=0;i<1; i++) this.stos.Pop();


            ilosc_kart = this.karty_playera.Count;

            if (ilosc_kart > 6)
            {
                MessageBox.Show("Nie możesz mieć więcej niż 6 kart");
                return;
            }
            else
            {
                int kolor_karty = karty_playera[ilosc_kart - 1].kolor;
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
                int wartosc_karty = karty_playera[ilosc_kart - 1].wartosc;
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

                PictureBox pb = (PictureBox)this.Controls.Find("player_" + ilosc_kart, true)[0];
                pb.Image = Image.FromFile("assets/" + (this.curretSkin + 1) + "/" + kolor + "/" + wartosc + ".png");
            }


        }

        private void LoadCardsOnScreen(int skin, int liczbna_kart_gracz, int liczba_kart_dealera)
        {
            //karty dealear:
            this.karty_dealera = AddCardToPlayer(liczba_kart_dealera, ref karty_dealera);
            //for(int i=0;i<liczba_kart_dealera; i++) this.stos.Pop();

            skin = skin + 1;
            for (int i = 1; i <= liczba_kart_dealera; i++)
            {
                if (i == 1)
                {
                    dealer_1.Image = Image.FromFile("assets/" + skin + "/hidden.png");
                    continue;
                }
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
                pb.Image = Image.FromFile("assets/" + skin + "/" + kolor + "/" + wartosc + ".png");
            }


            //karty gracza
            this.karty_playera = AddCardToPlayer(liczbna_kart_gracz, ref karty_playera);
            //for(int i=0;i<liczbna_kart_gracz; i++) this.stos.Pop();

            for (int i = 0; i < +liczbna_kart_gracz; i++)
            {
                int kolor_karty = karty_dealera[i].kolor;
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

                int wartosc_karty = karty_dealera[i].wartosc;
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
                PictureBox pb = (PictureBox)this.Controls.Find("player_" + (i + 1), true)[0];
                pb.Image = Image.FromFile("assets/" + skin + "/" + kolor + "/" + wartosc + ".png");
            }

        }

        private void oknoPomocyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wyświetlenie messageboxa z textem podpowiedzi
            MessageBox.Show("Skróty klawiszowe: \n" +
                            "F1 - wyświetlenie okna pomocy\n" +
                            "N - nowa gra\n" +
                            "H - przycisk Hit\n" +
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
            if ((e.KeyCode == Keys.H)&&(this.Hit_Button.Enabled == true))
            {
                Hit_Button_Click(this, new EventArgs());
            }
            if ((e.KeyCode == Keys.S)&&(this.Stand_Button.Enabled == true))
            {
                Stand_Button_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
        }

        private void Stand_Button_Click(object sender, EventArgs e)
        {
            //przyciski wyłączają się po kliknięciu
            this.Stand_Button.Enabled = false;
            this.Hit_Button.Enabled = false;

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
                if (karta.wartosc == 1)
                {
                    suma_A11_dealer += 11;
                    suma_A1_dealer += 1;
                }
                else if (karta.wartosc >= 10)
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
                else if (karta.wartosc >= 10)
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

            //MessageBox.Show("Punkty dealera - Duży AS: " + suma_A11_dealer + ", Mały AS: " + suma_A1_dealer +
            //              "\nPunkty gracz - Duży AS: "+ suma_A11_gracza+", Mały AS: "+ suma_A1_gracza);

        }
    }
}
