using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinal_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float vize=0, final=0, ortalama=0;
        int vizeOran=1, finalOran=1, gecmeNotu=0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize = float.Parse(txtVizeNot.Text);
            final = float.Parse(txtFinalNot.Text);
            vizeOran = int.Parse(txtVizeOran.Text);
            finalOran = int.Parse(txtFinalOran.Text);
            gecmeNotu = int.Parse(txtGecmeNotu.Text);

            if (vizeOran + finalOran != 100)
                MessageBox.Show("Vize Ortalaması ve Final Ortalaması toplamı 100 olmalıdır.","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                ortalama = (vize * vizeOran / 100) + (final * finalOran / 100);
                groupBox1.Visible = true;
                lblOrt.Text = ortalama.ToString();
                if (ortalama < gecmeNotu)
                    lblDurum.Text = "Kaldı";
                else
                    lblDurum.Text = "Geçti";
            }
           
        }
    }
}
