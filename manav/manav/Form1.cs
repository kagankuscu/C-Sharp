using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manav
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            decimal decFiyat = nmDomatesFiyat.Value * nmDomatesKilo.Value;
            nmDomatesToplamKilo.Value += nmDomatesKilo.Value;
            nmToplamfiyat.Value += decFiyat;

            decimal decfiyat2 = nmPatatesFiyat.Value * nmPatatesKilo.Value;
            nmPatatesToplamKilo.Value += nmPatatesKilo.Value;
            nmToplamfiyat.Value += decfiyat2;

            nmDomatesKilo.Value = 0;
            nmPatatesKilo.Value = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            nmDomatesKilo.Value = 0;
            nmPatatesKilo.Value = 0;

            nmDomatesToplamKilo.Value = 0;
            nmPatatesToplamKilo.Value = 0;

            nmToplamfiyat.Value = 0;

            nmOdenenPara.Value = 0;
            nmParaUstu.Value = 0;

            MessageBox.Show("Iyi günler dileriz");
        }

        private void form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kağan'ın Manavına Hoşgeldiniz !");
            DateTime dtTarih = DateTime.Now.Date;
            txtTarih.Text = dtTarih.ToString();
        }

        private void btnParaUstuHesaplama_Click(object sender, EventArgs e)
        {
            decimal ParaUstu = nmOdenenPara.Value - nmToplamfiyat.Value;
            if (nmOdenenPara.Value >= nmToplamfiyat.Value)
            {
                nmParaUstu.Value = ParaUstu;
            }
            else if (nmOdenenPara.Value == 0)
            {
                MessageBox.Show("Ödeneme Yapın.");
            }
            else
            {
                MessageBox.Show("Eksik verdiniz !!!");
            }
        }
    }
}

