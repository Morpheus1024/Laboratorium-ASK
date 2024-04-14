using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.okno1 = new Form2();
            this.okno1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.okno2 = new Form3();
            this.okno2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.okno3 = new Form4();
            this.okno3.Show();
        }

    }
}
