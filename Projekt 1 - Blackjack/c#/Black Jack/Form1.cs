namespace Black_Jack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            curretSkin = 0;
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

            //reset labelu ze scorem

            score.Text = ("Punkty:");

            //reset skinów
            curretSkin = 0;

            //³adowanie kart

            LoadCards(curretSkin);

            


        }

        private void Hit_Button_Click(object sender, EventArgs e)
        {

        }

        private void LoadCards(int skin)
        {

        }
    }
}
