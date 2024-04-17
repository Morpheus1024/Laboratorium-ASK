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

        public void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.okno1 = new Form2(this);
            this.okno1.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.okno2 = new Form3(this);
            this.okno2.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            this.okno3 = new Form4(this);
            this.okno3.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
