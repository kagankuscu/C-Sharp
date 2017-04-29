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
namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            tmrCalisma.Enabled = true;

            lblDakika.Text = Dakika.ToString();
            lblSaniye.Text = Saniye.ToString();

            btnBaslat.BackColor = Color.Gainsboro;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            tmrCalisma.Enabled = false;
            tmrDinlenme.Enabled = false;

            Dakika = 2;
            DinlenmeDakika = 1;

            lblDakika.ForeColor = Color.Black;
            lblSaniye.ForeColor = Color.Black;
            btnBaslat.BackColor = Color.Lime;

            lblDakika.Text = "00";
            lblSaniye.Text = "00";
        }

        int Dakika = 2, Saniye, DinlenmeDakika = 1;
        private void tmrCalisma_Tick(object sender, EventArgs e)
        {
            switch (Saniye)
            {
                case 0:
                    {
                        Saniye = 60;
                        Dakika--;
                        lblDakika.Text = Dakika.ToString();
                        break;
                    }
            }

                Saniye--;
                lblSaniye.Text = Saniye.ToString();
                //if (Saniye == 0)
                //{
                    //Dakika--;
                    lblDakika.Text = Dakika.ToString();
                    //Saniye = 59;

                if (Dakika < 0)
                    {
                        lblDakika.Text = "0";

                        tmrCalisma.Enabled = false;
                        Dakika = 2;

                        SystemSounds.Beep.Play();
                        MessageBox.Show("Biraz Dinlence Zamanı");
                        tmrDinlenme.Enabled = true;

                        this.BackColor = Color.SkyBlue;

                        lblDakika.ForeColor = Color.Red;
                        lblSaniye.ForeColor = Color.Red;

                        lblDakika.Text = DinlenmeDakika.ToString();
                        lblSaniye.Text = Saniye.ToString();
                    }

                //}
        }

        private void tmrDinlenme_Tick(object sender, EventArgs e)
        {
            switch (Saniye)
            {
                case 0:
                    {
                        Saniye = 60;
                        Dakika--;
                        lblDakika.Text = Dakika.ToString();
                        break;
                    }
            }

            Saniye--;
            lblSaniye.Text = Saniye.ToString();
            if (Saniye == 0)
            {
                DinlenmeDakika--;
                lblDakika.Text = DinlenmeDakika.ToString();
                Saniye = 59;

                if (DinlenmeDakika < 0)
                {
                    tmrDinlenme.Enabled = false;
                    DinlenmeDakika = 1;

                    lblDakika.Text = "00";
                    lblSaniye.Text = "00";
                    lblDakika.ForeColor = Color.Black;
                    lblSaniye.ForeColor = Color.Black;
                    btnBaslat.BackColor = Color.Lime;

                    SystemSounds.Beep.Play();
                    MessageBox.Show("Pomodoro'yu Bitirdiğiniz");
                }
            }
        }
    }
}
