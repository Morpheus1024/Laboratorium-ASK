using System.Management;


namespace Projekt_3_inna_wersja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initUI();
        }

        public void initUI()
        {
            piec_bar.Value = 0;
            chlodnia_bar.Value = 0;

            piec.piec_temperatura = 30;
            piec_temp_label.Text = "Temp.: " + piec.piec_temperatura.ToString() + "°C";
            piec.chlodnia_temperatura = 30;
            chlodnia_temp_label.Text = "Temp.: " + piec.chlodnia_temperatura.ToString() + "°C";

            piec_wieszaki.Text = "Wieszaki: " + piec.piec_wieszaki.ToString() + "/" + piec.piec_max_pojemnosc.ToString();
            chlodnia_wieszaki.Text = "Wieszaki: " + piec.chlodnia_wieszaki.ToString() + "/" + piec.chlodnia_max_pojemnosc.ToString();

            obecnosc_label.Text = (60 - obecnosc_timer_tick).ToString() + " sek.";

            stop_button.Enabled = false;
            obecnosc_button.Enabled = false;

            add_button.Enabled = false;

            log_window.ScrollBars = ScrollBars.Vertical;
            addLog("Uruchomiono program");
        }

        public void addLog(string text)
        {
            log_window.AppendText(text + Environment.NewLine);
            log_window.SelectionStart = log_window.Text.Length;
            log_window.ScrollToCaret();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chlodnia_label_Click(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            addLog("Uruchomiono maszyne");
            obecnosc_timer.Start();
            chlodnia_timer.Start();
            piec_timer.Start();
            oddanie_timer.Start();
            stop_button.Enabled = true;
            start_button.Enabled = false;
            obecnosc_button.Enabled = true;
        }

        private void piec_timer_Tick(object sender, EventArgs e)
        {

            piec_timer_tick++;

            if ((piec.piec_temperatura < piec.piec_max_temperatura) && (piec.czy_piec_nagrzany == false) && (czy_wylaczac_piec == false))
            {
                piec.piec_temperatura += 23;
            }
            else if (piec.piec_temperatura > piec.piec_max_temperatura)
            {
                if (!piec.czy_piec_nagrzany) addLog("Piec nagrzany");

                if (czas_nieobecnosci == 0)
                {
                    piec.czy_piec_nagrzany = true;
                    add_button.Enabled = true;
                }
                piec.piec_temperatura -= 4;
            }
            else if ((piec.piec_temperatura <= piec.piec_max_temperatura) && (piec.czy_piec_nagrzany == true))
            {
                piec.piec_temperatura += 3;
            }
            else if (czy_wylaczac_piec == true)
            {
                if (piec.piec_temperatura > 30) piec.piec_temperatura -= 10;
                else if (piec.piec_temperatura <= 30) piec.piec_temperatura++;
            }

            piec_temp_label.Text = "Temp.: " + piec.piec_temperatura.ToString() + "°C";

            if ((piec.czy_piec_nagrzany == true) && (czy_obecny == true))
            {
                short random_wieszak = (short)rand.Next(0, 21);

                if ((piec_timer_tick < 10) && (piec.piec_wieszaki < piec.piec_max_pojemnosc) && (random_wieszak > 10))
                {
                    piec_timer_tick = 0;
                    piec.piec_wieszaki++;
                    piec_bar.Value++;
                    piec_wieszaki.Text = "Wieszaki: " + piec.piec_wieszaki.ToString() + "/" + piec.piec_max_pojemnosc.ToString();
                    addLog("Dodano wieszak do pieca");
                }
            }
        }

        private void chlodnia_timer_Tick(object sender, EventArgs e)
        {
            if ((piec.piec_wieszaki > 0)&& (czy_wylaczac_piec == false))
            {
                chlodnia_timer_tick++;
                piec_progress_bar.Value++;
            }

            if (piec.chlodnia_temperatura > 30) piec.chlodnia_temperatura -= 1;
            else if (piec.chlodnia_temperatura < 33) piec.chlodnia_temperatura += 3;

            chlodnia_temp_label.Text = "Temp.: " + piec.chlodnia_temperatura.ToString() + "°C";

            if ((chlodnia_timer_tick == 12) && (czy_wylaczac_piec==false))
            {
                short random_chlodnia = (short)rand.Next(0, 11);
                chlodnia_timer_tick = 0;
                piec_progress_bar.Value = 0;

                if ((piec.czy_piec_nagrzany) && (piec.piec_wieszaki > 0) && (piec.chlodnia_wieszaki < piec.chlodnia_max_pojemnosc) && (czy_obecny == true))
                {
                    piec.piec_wieszaki--;
                    piec_bar.Value--;
                    piec_wieszaki.Text = "Wieszaki: " + piec.piec_wieszaki.ToString() + "/" + piec.piec_max_pojemnosc.ToString();
                    piec.chlodnia_wieszaki++;
                    chlodnia_bar.Value++;
                    chlodnia_wieszaki.Text = "Wieszaki: " + piec.chlodnia_wieszaki.ToString() + "/" + piec.chlodnia_max_pojemnosc.ToString();
                    addLog(Text = "Przeniesiono wieszak z pieca do chlodni");
                    piec.chlodnia_temperatura += 15;
                    piec.piec_temperatura -= 5;
                    piec.chlodnia_temperatura += random_chlodnia;
                }
            }
            chlodnia_temp_label.Text = "Temp.: " + piec.chlodnia_temperatura.ToString() + "°C";

        }

        private void oddanie_timer_Tick(object sender, EventArgs e)
        {
            if (piec.chlodnia_wieszaki > 0)
            {
                oddanie_timer_tick++;
                if (chlodnia_progress_bar.Value < 14) chlodnia_progress_bar.Value++;

            }

            if (oddanie_timer_tick == 14)
            {
                if ((piec.chlodnia_wieszaki > 0) && (czy_obecny == true))
                {
                    oddanie_timer_tick = 0;
                    chlodnia_progress_bar.Value = 0;
                    piec.chlodnia_wieszaki--;
                    chlodnia_bar.Value--;
                    chlodnia_wieszaki.Text = "Wieszaki: " + piec.chlodnia_wieszaki.ToString() + "/" + piec.chlodnia_max_pojemnosc.ToString();
                    addLog("Oddano wieszak z chlodni");
                }
            }
        }

        private void obecnosc_timer_Tick(object sender, EventArgs e)
        {
            if (obecnosc_timer_tick < 60)
            {
                obecnosc_timer_tick++;
            }
            else if (obecnosc_timer_tick == 60)
            {
                if (czy_obecny == true) addLog("BRAK OBECNOSCI OPERATORA");

                czy_obecny = false;

                if (czas_nieobecnosci == 0) addLog("Wymagana weryfikacja obecnoœci - 10sek");

                if (czas_nieobecnosci < 10) czas_nieobecnosci++;

                if (obecnosc_button.BackColor != Color.Red)
                {
                    obecnosc_button.BackColor = Color.Red;
                }
                else
                {
                    obecnosc_button.BackColor = Color.White;
                }

                if (czas_nieobecnosci == 10)
                {
                    addLog(Text = "Za dluga nieobecnosc operatora - wy³¹czanie maszyny");
                    piec.czy_piec_nagrzany = false;
                    czy_wylaczac_piec = true;
                    chlodnia_timer.Stop();
                    oddanie_timer.Stop();
                    piec_timer_tick = 0;
                    stop_button.Enabled = true;
                    start_button.Enabled = false;
                }
            }
            obecnosc_label.Text = (60 - obecnosc_timer_tick).ToString() + " sek.";
        }

        private void obecnosc_button_Click(object sender, EventArgs e)
        {
            if (czy_wylaczac_piec == true)
            {
                stop_button.Enabled = false;
                start_button.Enabled = true;
            }
            czy_obecny = true;
            czy_wylaczac_piec = false;
            obecnosc_timer_tick = 0;
            czas_nieobecnosci = 0;
            piec_timer.Start();
            obecnosc_timer.Start();
            chlodnia_timer.Start();
            oddanie_timer.Start();
            obecnosc_button.BackColor = Color.White;
            addLog(Text = "Obecnoœæ operatora potwierdzona");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            piec.piec_wieszaki++;
            piec_bar.Value++;
            addLog("SYMULACJA - dodano wieszak do pieca");
            piec_wieszaki.Text = "Wieszaki: " + piec.piec_wieszaki.ToString() + "/" + piec.piec_max_pojemnosc.ToString();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            obecnosc_timer.Stop();
            oddanie_timer.Stop();
            czy_wylaczac_piec= true;
            obecnosc_button.Enabled = false;
            stop_button.Enabled = false;
            start_button.Enabled = true;
            addLog("Zatrzymano maszyne");
            add_button.Enabled = false;
        }
    }
}
