namespace Projekt_3_Linia_produkcyjna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_UI();

        // Inicjalizacja obiektów
            Bufor bufor_przed_malowaniem_bar = new Bufor();
            Bufor bufor_przed_zawieszaniem = new Bufor();
            Opoznienie_transportowe malowanie = new Opoznienie_transportowe();
            Opoznienie_transportowe zdejmowanie = new Opoznienie_transportowe();
            Opoznienie_transportowe zawieszanie = new Opoznienie_transportowe();
            Piec_i_chlodnia piec_i_chlodnia = new Piec_i_chlodnia();
            

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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void oknoZKomunikatamiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
