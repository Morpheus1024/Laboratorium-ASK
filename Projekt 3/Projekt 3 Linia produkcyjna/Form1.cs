namespace Projekt_3_Linia_produkcyjna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_UI();

            // Inicjalizacja obiektów


        }

        public void init_UI()
        {
            bufor_przed_malowaniem_label.Text = "0";
            bufor_przed_malowaniem_bar.Value = 0;
            bufor_przed_malowaniem_bar.Maximum = 15;

            malowanie_bar.Value = 0;
            malowanie_bar.Maximum = 15;

            piec_label.Text = "0";
            piec_bar.Value = 0;
            piec_bar.Maximum = 10;
            piec_temperatura_label.Text = "0";

            chlodnia_label.Text = "0";
            chlodnia_bar.Value = 0;
            chlodnia_bar.Maximum = 10;
            chlodnia_temeratura_label.Text = "0";

            zdejmowanie_bar.Value = 0;
            zdejmowanie_bar.Maximum = 5;

            bufor_przed_zawieszaniem_label.Text = "0";
            bufor_przed_zawieszaniem_bar.Value = 0;
            bufor_przed_zawieszaniem_bar.Maximum = 10;

            aktualna_ilosc_wieszakow = 0;

            czas_obecnosc_label.Text = czas_do_potwierdzenia_obecnosci.ToString() +"s";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_malowanie_Tick(object sender, EventArgs e)
        {
            tick_malowanie++;
            if (tick_malowanie == 10)
            {
                tick_malowanie = 0;
                if (bufor_przed_malowaniem.ilosc_wieszakow > 0)
                {
                    //bufor_przed_malowaniem.oddaj_wieszak_do_zawieszenia();
                }
            }
        }

        private void oknoZKomunikatamiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_zawieszanie.Start();
            timer_malowanie.Start();
        }

        private void timer_zawieszanie_Tick(object sender, EventArgs e)
        {
            if(bufor_przed_malowaniem.ilosc_wieszakow<15)
            {
                tick_zawieszanie++;
                zawieszanie_bar.Value++;
            }

            if (tick_zawieszanie==7)
            {
                tick_zawieszanie = 0;
                zawieszanie_bar.Value = 0;
                if (aktualna_ilosc_wieszakow < max_ilosc_wieszakow)
                {
                    //dodaj obiekt wieszak
                    aktualna_ilosc_wieszakow++;
                    Wieszak nowy_wieszak= new Wieszak();

                    bufor_przed_malowaniem.dodaj_wieszak(nowy_wieszak);


                    if (bufor_przed_malowaniem.ilosc_wieszakow < 15)
                    {
                        bufor_przed_malowaniem.dodaj_wieszak();
                    }
                }

            }
            
        }

        private void prêdkoœæ2xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predkosc_symulacji = 2;
            timer_zawieszanie.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 10000 / predkosc_symulacji;
        }

        private void prêdkoœæ4xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predkosc_symulacji = 4;
            timer_zawieszanie.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 10000 / predkosc_symulacji;
        }

        private void symulacja10xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predkosc_symulacji = 10;
            timer_zawieszanie.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 10000 / predkosc_symulacji;
        }

        private void timer_obecnoœæ_Tick(object sender, EventArgs e)
        {
            czas_do_potwierdzenia_obecnosci--;
            czas_obecnosc_label.Text = czas_do_potwierdzenia_obecnosci.ToString() + "s";

            if (czas_do_potwierdzenia_obecnosci ==0)
            {
                timer_obecnoœæ.Stop();
                timer_zawieszanie.Stop();
            }
        }
    }
}
