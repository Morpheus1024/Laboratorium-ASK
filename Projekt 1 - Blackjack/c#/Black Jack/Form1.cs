using System.Numerics;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            curretSkin = 0;
            talia = new Karta[52];
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
            Shuffle(talia);

            //reset labelu ze scorem
            score.Text = ("Punkty:");

            //reset skinów
            curretSkin = 0;

            //³adowanie kart
            LoadCards(curretSkin, 2, 2);

            


        }

        private void Hit_Button_Click(object sender, EventArgs e)
        {

        }

        private void LoadCards(int skin, int liczbna_kart_gracz, int liczba_kart_dealera)
        {   
            this.kart
            //karty dealear:
            dealer_1.Image = Image.FromFile("skins/" + skin + "/hidden.png");
            for(int i = 1; i <= liczba_kart_dealera; i++)
            {
             //   tabulacja upa dupa
            }

            //karty gracza

            for(int i = 0; i<+liczbna_kart_gracz; i++)
            {
                PictureBox pb = (PictureBox)this.Controls.Find("player_" + (i + 1), true)[0];
                pb.Image = Image.FromFile("skins/" + skin + "/jakies.png");
            }

        }

        //private void Shuffle(Karta[] talia)
        //{
        //    //tasowanie kart
        //    Random rnd = new Random();

        //    //przypisanie wartoœci i koloru do talii
        //    for(int i = 0; i < 13; i++)
        //    {
        //        for(int kolor = 0; kolor<4; kolor++)
        //        {
        //            talia[i].kolor = kolor;
        //            talia[i].wartosc = (i%13)+1;
        //            // AS = 1
        //            // 2-10 = 2-10
        //            // walet = 11
        //            // dama = 12
        //            // król = 13
        //        }
        //    }
        //    for (int i = 0; i < 52; i++)
        //    {
        //        int r = rnd.Next(52);
        //        Karta temp = talia[i];
        //        talia[i] = talia[r];
        //        talia[r] = temp;
        //    }

        //}   
        public void Shuffle()
        {
            this.talia = new Karta[52];
            Random rnd = new Random();
            for (int i = 0; i < 52; i++)
            {
                this.talia[i].wartosc = i % 4+1;
                this.talia[i].kolor = i % 13;
                // AS = 1
                //            // 2-10 = 2-10
                //            // walet = 11
                //            // dama = 12
                //            // król = 13
            }
        }


    }
}
