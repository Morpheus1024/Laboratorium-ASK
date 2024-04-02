using System.Numerics;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            curretSkin = 0;
            talia = new List<Karta>();
            stos = new Stack<Karta>();
            karty_playera = new List<Karta>();
            karty_dealera = new List<Karta>();
            talia =new List<Karta>();
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
                this.stos.Push(this.talia[i]);
            }

        }
        private void AddCardToPlayer(int ilosc, ref List<Karta> reka_gracza,Stack<Karta> stos)
        {
            for (int i = 0; i < ilosc; i++)
            {
                Karta karta = this.stos.Pop();
                reka_gracza.Add(karta);
            }
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
                    suma_A11+= karta.wartosc;
                    suma_A1 += karta.wartosc;
                }
            }   
            score.Text = ("Punkty - Duży AS:" + suma_A11 + ", Mały AS:"+ suma_A1);
        }   

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            score.Text = ("Punkty:");

            //reset skin�w
            curretSkin = 0;

            //�adowanie kart
            LoadCardsOnScreen(curretSkin, 2, 2);

            WriteScoreToLabel(karty_playera, true);

        }

        private void Hit_Button_Click(object sender, EventArgs e)
        {

        }

        private void LoadCardsOnScreen(int skin, int liczbna_kart_gracz, int liczba_kart_dealera)
        {   
            //karty dealear:
            AddCardToPlayer(liczba_kart_dealera, ref karty_dealera, stos);
            skin = skin + 1;
            for(int i = 1; i <= liczba_kart_dealera; i++)
            {
                if (i == 1)
                {
                    dealer_1.Image = Image.FromFile("assets/" + skin + "/hidden.png");
                    continue;
                }
                int kolor_karty = karty_dealera[i - 1].kolor;
                string kolor="";
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
                pb.Image = Image.FromFile("assets/" + skin + "/"+ kolor +"/"+wartosc+".png");
            }


            //karty gracza
            AddCardToPlayer(liczbna_kart_gracz, ref karty_playera, stos);
            for(int i = 0; i<+liczbna_kart_gracz; i++)
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

    }
}
