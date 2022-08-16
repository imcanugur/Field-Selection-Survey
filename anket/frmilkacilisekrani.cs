using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anket
{
    public partial class frmilkacilisekrani : Form
    {
        public frmilkacilisekrani()
        {
            InitializeComponent();
        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 8)
            {
                Form1 a = new Form1();
                a.Show();
                this.Hide();
            }
        }

        private void frmilkacilisekrani_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
