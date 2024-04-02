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
    public partial class OknoInfo : Form
    {
        public OknoInfo()
        {
            InitializeComponent();
        }

        public OknoInfo(ProgramPierwszy OknGl, String TekstInfo)
        {
            InitializeComponent();
            OknoGl = OknGl;
            this.label1.Text = TekstInfo;
        }

        private void OknoInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                OknoGl.Przycisk_1.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                OknoGl.Przycisk_2.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                OknoGl.Przycisk_3.PerformClick();
            }

        }
    }
}
