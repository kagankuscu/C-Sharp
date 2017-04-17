using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ZamanSayacı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            tmrZaman.Enabled = false;
            txtDakika.ReadOnly = false;
            saniye = 59;
            lblSaniye.Text = lblDakika.Text = "0";
            lblMetin.Text = "";
        }
        int dakika = 0, saniye = 59;
       
        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblSaniye.Text = saniye.ToString();
            
            if (saniye==0)
            {
                saniye = 59;

                if (dakika == 0)
                {
                    lblDakika.Text = dakika.ToString();
                    tmrZaman.Enabled = false;
                    lblMetin.Text = "Bitti";

                    txtDakika.ReadOnly = false;

                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "//song7.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    dakika--;
                    lblDakika.Text = dakika.ToString();
                }
            }
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (txtDakika.Text == "")
            {
                lblMetin.Text = "Sayı Girin !";
                tmrZaman.Enabled = false;

                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "//error.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {
                int sayi = Convert.ToInt32(txtDakika.Text);

                if (sayi > 0)
                {
                    txtDakika.ReadOnly = true;

                    dakika = Convert.ToInt32(txtDakika.Text) - 1;

                    tmrZaman.Enabled = true;
                    lblDakika.Text = dakika.ToString();
                    lblSaniye.Text = saniye.ToString();

                    lblMetin.Text = "Çalışıyor...";
                }
                else
                {
                    lblMetin.Text = "Hatalı Sayı !";
                    tmrZaman.Enabled = false;

                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "//error.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
            }
        }
    }
}
