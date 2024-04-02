using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class NoweOkno : Form
    {
        public NoweOkno()
        {
            InitializeComponent();
            this.OknoRodzic = null;
            this.ParametrInt = 100;
            this.label1.Text = this.ParametrInt.ToString();
        }
        public NoweOkno(int ParInt)
        {
            InitializeComponent();
            this.OknoRodzic = null;
            this.ParametrInt = ParInt;
            this.label1.Text = this.ParametrInt.ToString();
        }
        
        public NoweOkno(ProgramPierwszy OknoRodz)
        {
            InitializeComponent();
            this.OknoRodzic = OknoRodz;
            this.ParametrInt = 100;
            this.label1.Text = this.ParametrInt.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParametrInt++;
            this.label1.Text = this.ParametrInt.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.OknoRodzic != null)
            {
                this.OknoRodzic.label2.Text = this.ParametrInt.ToString();
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
