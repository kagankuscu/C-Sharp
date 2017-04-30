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

        Sure zaman = new Sure();
        
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (chkb1.Checked != false || chkb2.Checked != false || chkb3.Checked != false || chkb4.Checked != false)
            {
                if (txtCalismaDakika.Text != "" && txtDinlenmeDakika.Text != "")
                {
                    txtCalismaDakika.ReadOnly = true;
                    txtDinlenmeDakika.ReadOnly = true;

                    zaman.Dakika = Convert.ToInt32(txtCalismaDakika.Text);
                    zaman.DinlenmeDakika = Convert.ToInt32(txtDinlenmeDakika.Text);

                    tmrCalisma.Enabled = true;

                    lblDakika.Text = zaman.Dakika.ToString();
                    lblSaniye.Text = zaman.Saniye.ToString();

                    btnBaslat.BackColor = Color.GreenYellow;
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Çalışma veya Dinlenme Dakikası Girilmedi ! ");
                }
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            txtCalismaDakika.ReadOnly = false;
            txtDinlenmeDakika.ReadOnly = false;

            tmrCalisma.Enabled = false;
            tmrDinlenme.Enabled = false;

            zaman.Dakika=0;
            zaman.DinlenmeDakika=0;
            zaman.Saniye = 0;

            txtCalismaDakika.Text = "";
            txtDinlenmeDakika.Text = "";

            lblDakika.ForeColor = Color.Black;
            lblSaniye.ForeColor = Color.Black;
            btnBaslat.BackColor = Color.Lime;

            lblDakika.Text = "00";
            lblSaniye.Text = "00";

            chkb1.Checked = false;
            chkb2.Checked = false;
            chkb3.Checked = false;
            chkb4.Checked = false;
        }
        
        private void tmrCalisma_Tick(object sender, EventArgs e)
        {
            switch (zaman.Saniye)
            {
                case 0:
                    {
                        zaman.Saniye = 60;
                        zaman.Dakika--;
                        lblDakika.Text = zaman.Dakika.ToString();
                        break;
                    }
            }

                zaman.Saniye--;
                lblSaniye.Text = zaman.Saniye.ToString();
                
            switch (zaman.Dakika)
            {
                case -1:
                    {
                        lblDakika.Text = "0";
                        lblSaniye.Text = "0";

                        tmrCalisma.Enabled = false;
                        zaman.Dakika = 0;
                        zaman.Saniye = 0;

                        SystemSounds.Beep.Play();
                        MessageBox.Show("Biraz Dinlence Zamanı");
                        tmrDinlenme.Enabled = true;

                        this.BackColor = Color.SkyBlue;

                        lblDakika.ForeColor = Color.Red;
                        lblSaniye.ForeColor = Color.Red;

                        lblDakika.Text = zaman.DinlenmeDakika.ToString();
                        lblSaniye.Text = zaman.Saniye.ToString();

                        break;
                    }
            }
        }

        private void tmrDinlenme_Tick(object sender, EventArgs e)
        {
            switch (zaman.Saniye)
            {
                case 0:
                    {
                        zaman.Saniye = 60;
                        zaman.DinlenmeDakika--;
                        lblDakika.Text = zaman.DinlenmeDakika.ToString();
                        break;
                    }
            }

            zaman.Saniye--;
            lblSaniye.Text = zaman.Saniye.ToString();

            switch (zaman.DinlenmeDakika)
            {
                case -1:
                    {
                        tmrDinlenme.Enabled = false;
                        zaman.Dakika = 0;
                        zaman.DinlenmeDakika = 0;
                        zaman.Saniye = 0;

                        lblDakika.Text = "00";
                        lblSaniye.Text = "00";

                        //txtCalismaDakika.Text = "" ;
                        //txtDinlenmeDakika.Text = "" ;

                        txtCalismaDakika.ReadOnly = false;
                        txtDinlenmeDakika.ReadOnly = false;

                        this.BackColor = Color.White;
                        lblDakika.ForeColor = Color.Black;
                        lblSaniye.ForeColor = Color.Black;
                        btnBaslat.BackColor = Color.Lime;

                        SystemSounds.Beep.Play();
                        MessageBox.Show("Pomodoro'yu Bitirdiğiniz");

                        break;
                    }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb1.Checked == true)
            {
                chkbPomodoro1.Enabled = true;
                chkbPomodoro2.Enabled = false;
                chkbPomodoro3.Enabled = false;
                chkbPomodoro4.Enabled = false;
            }
            else
            {
                chkbPomodoro1.Enabled = false;
            }

            if (chkb1.Checked == true)
            {
                chkb2.Enabled = false;
                chkb3.Enabled = false;
                chkb4.Enabled = false;
            }
            else
            {
                chkb2.Enabled = true;
                chkb3.Enabled = true;
                chkb4.Enabled = true;

                chkbPomodoro1.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb2.Checked == true)
            {
                chkbPomodoro1.Enabled = true;
                chkbPomodoro2.Enabled = true;
                chkbPomodoro3.Enabled = false;
                chkbPomodoro4.Enabled = false;
            }
            else
            {
                chkbPomodoro1.Enabled = false;
                chkbPomodoro2.Enabled = false;
            }

            if (chkb2.Checked == true)
            {
                chkb1.Enabled = false;
                chkb3.Enabled = false;
                chkb4.Enabled = false;
            }
            else
            {
                chkb1.Enabled = true;
                chkb3.Enabled = true;
                chkb4.Enabled = true;

                chkbPomodoro1.Checked = false;
                chkbPomodoro2.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb3.Checked == true)
            {
                chkbPomodoro3.Enabled = true;
                chkbPomodoro2.Enabled = true;
                chkbPomodoro1.Enabled = true;
                chkbPomodoro4.Enabled = false;
            }
            else
            {
                chkbPomodoro1.Enabled = false;
                chkbPomodoro2.Enabled = false;
                chkbPomodoro3.Enabled = false;
            }

            if (chkb3.Checked == true)
            {
                chkb2.Enabled = false;
                chkb1.Enabled = false;
                chkb4.Enabled = false;
            }
            else
            {
                chkb2.Enabled = true;
                chkb1.Enabled = true;
                chkb4.Enabled = true;

                chkbPomodoro1.Checked = false;
                chkbPomodoro2.Checked = false;
                chkbPomodoro3.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb4.Checked == true)
            {
                chkbPomodoro4.Enabled = true;
                chkbPomodoro2.Enabled = true;
                chkbPomodoro3.Enabled = true;
                chkbPomodoro1.Enabled = true;
            }
            else
            {
                chkbPomodoro1.Enabled = false;
                chkbPomodoro2.Enabled = false;
                chkbPomodoro3.Enabled = false;
                chkbPomodoro4.Enabled = false;
            }

            if (chkb4.Checked == true)
            {
                chkb2.Enabled = false;
                chkb3.Enabled = false;
                chkb1.Enabled = false;
            }
            else
            {
                chkb2.Enabled = true;
                chkb3.Enabled = true;
                chkb1.Enabled = true;

                chkbPomodoro1.Checked = false;
                chkbPomodoro2.Checked = false;
                chkbPomodoro3.Checked = false;
                chkbPomodoro4.Checked = false;
            }
        }

        private void chkbPomodoro1_CheckedChanged(object sender, EventArgs e)
        {
            if (zaman.DinlenmeDakika == 0)
            {
                if (chkb1.Checked == true)
                {
                    txtCalismaDakika.Text = "";
                    txtDinlenmeDakika.Text = "";

                    chkb1.Checked = false;
                }
            }
        }

        private void chkbPomodoro2_CheckedChanged(object sender, EventArgs e)
        {
            if (zaman.DinlenmeDakika == 0)
            {
                if (chkb2.Checked == true)
                {
                    if (chkbPomodoro1.Checked == true)
                    {
                        txtCalismaDakika.Text = "";
                        txtDinlenmeDakika.Text = "";

                        chkb2.Checked = false;
                    }
                }
            }
        }

        private void chkbPomodoro3_CheckedChanged(object sender, EventArgs e)
        {
            if (zaman.DinlenmeDakika == 0)
            {
                if (chkb3.Checked == true)
                {
                    if (chkbPomodoro1.Checked == true && chkbPomodoro2.Checked == true)
                    {
                        txtCalismaDakika.Text = "";
                        txtDinlenmeDakika.Text = "";
                    }
                }
            }
        }

        private void chkbPomodoro4_CheckedChanged(object sender, EventArgs e)
        {
            if (zaman.DinlenmeDakika == 0)
            {
                if (chkb4.Checked == true)
                {
                    if (chkbPomodoro1.Checked == true && chkbPomodoro2.Checked == true && chkbPomodoro3.Checked == true)
                    {
                        txtCalismaDakika.Text = "";
                        txtDinlenmeDakika.Text = "";
                    }
                }
            }
        }
    }
}
