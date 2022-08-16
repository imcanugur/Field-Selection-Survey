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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bil = 0, rtv = 0, halk = 0, gaz = 0, mhsb = 0;


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmkapat a = new frmkapat();
            a.Show();
        }

        private void bil1_OnChange(object sender, EventArgs e)
        {

        }

        private void tamamla_Click(object sender, EventArgs e)
        {
            //------------------------true Değerler
            //bilişim
            if (bil1.Checked == true)
            {
                bil++;
            }
            if (bil2.Checked == true)
            {
                bil++;
            }
            if (bil3.Checked == true)
            {
                bil++;
            }
            if (bil4.Checked == true)
            {
                bil++;
            }
            if (bil5.Checked == true)
            {
                bil++;
            }
            //rtv
            if (rtv1.Checked == true)
            {
                rtv++;
            }
            if (rtv2.Checked == true)
            {
                rtv++;
            }
            if (rtv3.Checked == true)
            {
                rtv++;
            }
            if (rtv4.Checked == true)
            {
                rtv++;
            }
            if (rtv5.Checked == true)
            {
                rtv++;
            }
            //halkla ilişkiler
            if (halk1.Checked == true)
            {
                halk++;
            }
            if (halk2.Checked == true)
            {
                halk++;
            }
            if (halk3.Checked == true)
            {
                halk++;
            }
            if (halk4.Checked == true)
            {
                halk++;
            }
            if (halk5.Checked == true)
            {
                halk++;
            }
            //muhasebe
            if (mhsb1.Checked == true)
            {
                mhsb++;
            }
            if (mhsb2.Checked == true)
            {
                mhsb++;
            }
            if (mhsb3.Checked == true)
            {
                mhsb++;
            }
            if (mhsb4.Checked == true)
            {
                mhsb++;
            }
            if (mhsb5.Checked == true)
            {
                mhsb++;
            }
            //gazete
            if (gaz1.Checked == true)
            {
                gaz++;
            }
            if (gaz2.Checked == true)
            {
                gaz++;
            }
            if (gaz3.Checked == true)
            {
                gaz++;
            }
            if (gaz4.Checked == true)
            {
                gaz++;
            }
            if (gaz5.Checked == true)
            {
                gaz++;
            }
            for (int i = 1; i <= 1; i++)
            {

                //------------------------hesaplama
                if (gaz == 0 && bil == 0 && halk == 0 && mhsb == 0 && rtv == 0)
                {
                    MessageBox.Show("Öncelikle En Az Bir Adet Soru Seçin!!!", "Cans SoftWare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (bil >= gaz && bil >= halk && bil >= rtv && bil >= mhsb)
                {
                    frmbil a = new frmbil();
                    a.Show();
                    this.Hide();
                    break;
                }
                if (rtv >= gaz && rtv >= halk && rtv >= bil && rtv >= mhsb)
                {
                    frmrtv a = new frmrtv();
                    a.Show();
                    this.Hide();
                    break;
                }
                if (halk >= gaz && halk >= rtv && halk >= bil && halk >= mhsb)
                {
                    frmhalk a = new frmhalk();
                    a.Show();
                    this.Hide();
                    break;
                }
                if (gaz >= rtv && gaz >= halk && gaz >= bil && gaz >= mhsb)
                {
                    frmgaz a = new frmgaz();
                    a.Show();
                    this.Hide();
                    break;
                }
                if (mhsb >= gaz && mhsb >= halk && mhsb >= bil && mhsb >= rtv)
                {
                    frmmhsb a = new frmmhsb();
                    a.Show();
                    this.Hide();
                    break;
                }
                gaz = 0;
                bil = 0;
                halk = 0;
                mhsb = 0;
                rtv = 0;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
            this.Hide();
        }
    }
}
