namespace Projekt_3_Linia_produkcyjna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_UI();

            init_wieszaki();

            // Inicjalizacja obiektów


        }

        public void init_UI()
        {
            bufor_przed_malowaniem_label.Text = "0";
            bufor_przed_malowaniem_bar.Value = 0;
            bufor_przed_malowaniem_bar.Maximum = 15;
            bufor_przed_malowaniem.ilosc_wieszakow = 0;
            bufor_przed_malowaniem.max_pojemnosc = 15;

            malowanie_bar.Value = 0;
            malowanie_bar.Maximum = 11;

            piec_label.Text = "0";
            piec_bar.Value = 0;
            piec_bar.Maximum = 10;
            piec_temperatura_label.Text = "0";

            chlodnia_label.Text = "0";
            chlodnia_bar.Value = 0;
            chlodnia_bar.Maximum = 11;
            chlodnia_temeratura_label.Text = "0";

            zdejmowanie_bar.Value = 0;
            zdejmowanie_bar.Maximum = 10;

            bufor_przed_zawieszaniem_label.Text = "0";
            bufor_przed_zawieszaniem_bar.Value = 0;
            bufor_przed_zawieszaniem_bar.Maximum = 10;
            bufor_przed_zawieszaniem.ilosc_wieszakow = 0;
            bufor_przed_zawieszaniem.max_pojemnosc = 10;

            aktualna_ilosc_wieszakow = 0;

            czas_obecnosc_label.Text = czas_do_potwierdzenia_obecnosci.ToString() + "s";

            piec_temperatura_label.Text = piec_i_chlodnia.temperatura_piec.ToString() + "°C";
            chlodnia_temeratura_label.Text = piec_i_chlodnia.temperatura_chlodnia.ToString() + "°C";

        }

        public void init_wieszaki()
        {
            for (int i = 0; i < max_ilosc_wieszakow; i++)
            {
                Wieszak nowy_wieszak = new Wieszak();
                nowy_wieszak.ID = (short)(20 - i);
                stos_wieszakow.Push(nowy_wieszak);
            }

            zawieszanie.stos.Push(stos_wieszakow.Pop()); //pierwszy wieszak ju¿ jest na zawieszaniu
            aktualna_ilosc_wieszakow++;
            label_console.Text = stos_wieszakow.Count.ToString();

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
            if (malowanie.stos.Count() == 1)
            {
                malowanie_bar.Value++;
            }
            if (tick_malowanie == 11)
            {
                tick_malowanie = 0;
                if (malowanie.stos.Count() == 1)
                {
                    //oddanie wieszaka
                    if ((piec_i_chlodnia.ilosc_wieszakow_pieca < piec_i_chlodnia.max_pojemnosc_pieca) && (piec_i_chlodnia.piec_nagrzany))
                    {
                        malowanie_bar.Value = 0;
                        piec_i_chlodnia.dodaj_wieszak_do_pieca(malowanie.stos.Pop());
                        piec_bar.Value++;
                        piec_label.Text = piec_i_chlodnia.ilosc_wieszakow_pieca.ToString();
                    }
                }
                else if (malowanie.stos.Count == 0)
                {
                    if (bufor_przed_malowaniem.ilosc_wieszakow > 0)
                    {
                        bufor_przed_malowaniem.oddaj_wieszak_do_malowania(malowanie);
                        bufor_przed_malowaniem_bar.Value--;
                        bufor_przed_malowaniem_label.Text = bufor_przed_malowaniem.ilosc_wieszakow.ToString();
                    }
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
            timer_obecnoœæ.Start();
            timer_zdejmowanie.Start();
            timer_piec.Start();
            timer_chlodnia.Start();
        }

        private void timer_zawieszanie_Tick(object sender, EventArgs e)
        {

            if (bufor_przed_malowaniem.ilosc_wieszakow < 15)
            {
                tick_zawieszanie++;
                if ((stos_wieszakow.Count > 0) || (bufor_przed_zawieszaniem.ilosc_wieszakow > 0)) zawieszanie_bar.Value++;
            }

            if (tick_zawieszanie == 7)
            {
                tick_zawieszanie = 0;
                zawieszanie_bar.Value = 0;
                if (aktualna_ilosc_wieszakow < max_ilosc_wieszakow)
                {
                    Wieszak zawieszany_wieszak = zawieszanie.stos.Pop();
                    bufor_przed_malowaniem.dodaj_wieszak_do_bufora(zawieszany_wieszak);
                    bufor_przed_malowaniem_bar.Value++;
                }
                else
                {
                    if (bufor_przed_zawieszaniem.ilosc_wieszakow > 0)
                    {
                        bufor_przed_zawieszaniem.oddaj_wieszak_do_zawieszenia(zawieszanie);
                        bufor_przed_zawieszaniem_label.Text = bufor_przed_zawieszaniem.ilosc_wieszakow.ToString();
                        bufor_przed_zawieszaniem_bar.Value--;
                    }
                }

                if (aktualna_ilosc_wieszakow < max_ilosc_wieszakow)
                {
                    //dodaj nowy wieszak do zawieszania ze stosu
                    aktualna_ilosc_wieszakow++;
                    label_console.Text = stos_wieszakow.Count.ToString();
                    zawieszanie.stos.Push(stos_wieszakow.Pop());
                    bufor_przed_malowaniem_label.Text = bufor_przed_malowaniem.ilosc_wieszakow.ToString();
                }
                else
                {
                    if (bufor_przed_zawieszaniem.ilosc_wieszakow > 0)
                    {
                        //
                    }
                }

            }

        }

        private void prêdkoœæ2xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predkosc_symulacji = 2;
            timer_zawieszanie.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 1000 / predkosc_symulacji;
            timer_obecnoœæ.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 1000 / predkosc_symulacji;
            timer_piec.Interval = 1000 / predkosc_symulacji;
            timer_chlodnia.Interval = 1000 / predkosc_symulacji;
        }

        private void prêdkoœæ4xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predkosc_symulacji = 4;
            timer_zawieszanie.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 1000 / predkosc_symulacji;
            timer_obecnoœæ.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 1000 / predkosc_symulacji;
            timer_piec.Interval = 1000 / predkosc_symulacji;
            timer_chlodnia.Interval = 1000 / predkosc_symulacji;
        }

        private void symulacja10xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            predkosc_symulacji = 10;
            timer_zawieszanie.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 1000 / predkosc_symulacji;
            timer_obecnoœæ.Interval = 1000 / predkosc_symulacji;
            timer_malowanie.Interval = 1000 / predkosc_symulacji;
            timer_piec.Interval = 1000 / predkosc_symulacji;
            timer_chlodnia.Interval = 1000 / predkosc_symulacji;
        }

        private void timer_obecnoœæ_Tick(object sender, EventArgs e)
        {
            if (obecnosc == true)
            {
                czas_do_potwierdzenia_obecnosci--;
                czas_obecnosc_label.Text = czas_do_potwierdzenia_obecnosci.ToString() + "s";

            }

            if (czas_do_potwierdzenia_obecnosci == 0)
            {
                obecnosc = false;
                timer_zawieszanie.Stop();
                timer_malowanie.Stop();
                timer_zdejmowanie.Stop();
                timer_chlodnia.Stop();
            }

            if (obecnosc == false)
            {
                if (obecnosc_button.BackColor == Color.Green) obecnosc_button.BackColor = Color.Red;

                else obecnosc_button.BackColor = Color.Green;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer_obecnoœæ.Stop();
            czas_do_potwierdzenia_obecnosci = 30;
            czas_obecnosc_label.Text = czas_do_potwierdzenia_obecnosci.ToString() + "s";
            obecnosc = true;
            timer_malowanie.Start();
            timer_zawieszanie.Start();
            timer_zdejmowanie.Start();
            timer_piec.Start();


            obecnosc_button.BackColor = Color.Green;
            timer_obecnoœæ.Start();

        }

        private void timer_piec_Tick(object sender, EventArgs e)
        {
            //obs³uga temperatury pieca
            if ((!piec_i_chlodnia.piec_nagrzany) && (piec_i_chlodnia.temperatura_piec > piec_i_chlodnia.max_temperatura_piec)) piec_i_chlodnia.piec_nagrzany = true;

            if ((!piec_i_chlodnia.piec_nagrzany) && (piec_i_chlodnia.temperatura_piec < piec_i_chlodnia.max_temperatura_piec + 1))
            {
                piec_i_chlodnia.temperatura_piec += 15;
            }
            else if ((piec_i_chlodnia.piec_nagrzany) && (piec_i_chlodnia.temperatura_piec > piec_i_chlodnia.max_temperatura_piec))
            {
                piec_i_chlodnia.temperatura_piec -= 4;

            }
            else if ((piec_i_chlodnia.piec_nagrzany) && (piec_i_chlodnia.temperatura_piec < piec_i_chlodnia.max_temperatura_piec + 1))
            {
                piec_i_chlodnia.temperatura_piec += 3;
            }
            piec_temperatura_label.Text = piec_i_chlodnia.temperatura_piec.ToString() + "°C";

            //obs³uga temperatury chlodni
            if (piec_i_chlodnia.temperatura_chlodnia > 20) piec_i_chlodnia.temperatura_chlodnia -= 1;

            chlodnia_temeratura_label.Text = piec_i_chlodnia.temperatura_chlodnia.ToString() + "°C";
            //przekazanie wieszaka z pieca do chlodni
            if (tick_piec < 13)
            {
                tick_piec++;
            }

            if (tick_piec == 13)
            {
                tick_piec = 0;
                if ((piec_i_chlodnia.ilosc_wieszakow_chlodni < piec_i_chlodnia.max_pojemnosc_chlodni) && (piec_i_chlodnia.ilosc_wieszakow_pieca > 0))
                {
                    piec_i_chlodnia.przekaz_wieszak_do_chlodni();
                    piec_label.Text = piec_i_chlodnia.ilosc_wieszakow_pieca.ToString();
                    piec_bar.Value--;
                    chlodnia_label.Text = piec_i_chlodnia.ilosc_wieszakow_chlodni.ToString();
                    chlodnia_bar.Value++;
                }
            }

            //przekazywanie wieszaków z ch³odni do zdejmowania

            
        }

        private void timer_zdejmowanie_Tick(object sender, EventArgs e)
        {

            if (zdejmowanie.stos.Count > 0)
            {
                tick_zdejmowanie++;
                zdejmowanie_bar.Value++;
            }


            if (tick_zdejmowanie == 10)
            {
                tick_zdejmowanie = 0;
                if (zdejmowanie.stos.Count > 0)
                {
                    bufor_przed_zawieszaniem.dodaj_wieszak_do_bufora(zdejmowanie.stos.Pop());
                    zdejmowanie_bar.Value = 0;
                    bufor_przed_zawieszaniem_label.Text = bufor_przed_zawieszaniem.ilosc_wieszakow.ToString();
                    bufor_przed_zawieszaniem_bar.Value++;
                }
            }

        }

        private void timer_chlodnia_Tick(object sender, EventArgs e)
        {
            if(piec_i_chlodnia.ilosc_wieszakow_chlodni > 0)
            {
                tick_chlodnia++;
            }

            if (tick_chlodnia == 12)
            {
                tick_chlodnia = 0;
                if ((piec_i_chlodnia.ilosc_wieszakow_chlodni > 0) && (zdejmowanie.stos.Count == 0))
                {
                    piec_i_chlodnia.oddaj_wieszak_do_zdejmowania(zdejmowanie);
                    chlodnia_label.Text = piec_i_chlodnia.ilosc_wieszakow_chlodni.ToString();
                    chlodnia_bar.Value--;
                    piec_i_chlodnia.temperatura_chlodnia -= 10;
                    chlodnia_temeratura_label.Text = piec_i_chlodnia.temperatura_chlodnia.ToString() + "°C";
                }
            }
        }
    }
}
