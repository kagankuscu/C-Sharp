using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarKapatmaZamanlayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ToplamSaniye = 0;
        int sayi = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (txtDakika.Text == "")
            {
                lblMetin.Text = "Sayı Girilmedi";
            }
            else
            {
                kapat = true;

                ToplamSaniye = Convert.ToInt32(txtDakika.Text) * 60;

            DialogResult soru;
            soru=MessageBox.Show("Bilgisayar Kapatılsın mı?","Uyarı",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    if (txtDakika.Text == "")
                    {
                        lblMetin.Text = "Hatalı Sayı";
                        tmrZaman.Enabled = false;
                    }
                    else
                    {
                        sayi = Convert.ToInt32(txtDakika.Text);

                        if (sayi > 0)
                        {
                            txtDakika.ReadOnly = true;
                            tmrZaman.Enabled = true;
                            dakika = Convert.ToInt32(txtDakika.Text) - 1;
                            lblDakika.Text = dakika.ToString();
                            lblMetin.Text = "Çalışıyor...";
                        }
                        else
                        {
                            lblMetin.Text = "Hatalı Sayı";
                            tmrZaman.Enabled = false;
                        }
                    }

                    System.Diagnostics.Process.Start("shutdown", "-s -t" + ToplamSaniye);//Bilgisayar Kapatma Kodu
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDakika.Text == "")
            {
                lblMetin.Text = "Sayı Girilmedi";
            }
            else
            {
                yenidenBaslama = true;

                ToplamSaniye = Convert.ToInt32(txtDakika.Text) * 60;

            DialogResult soru;
            soru = MessageBox.Show("Bilgisayar Yeniden Başlatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    if (txtDakika.Text == "")
                    {
                        lblMetin.Text = "Hatalı Sayı";
                        tmrZaman.Enabled = false;
                    }
                    else
                    {
                        sayi = Convert.ToInt32(txtDakika.Text);

                        if (sayi > 0)
                        {
                            txtDakika.ReadOnly = true;
                            tmrZaman.Enabled = true;
                            dakika = Convert.ToInt32(txtDakika.Text) - 1;
                            lblDakika.Text = dakika.ToString();
                            lblMetin.Text = "Çalışıyor...";
                        }
                        else
                        {
                            lblMetin.Text = "Hatalı Sayı";
                            tmrZaman.Enabled = false;
                        }
                    }

                    System.Diagnostics.Process.Start("shutdown", "-r -t " + ToplamSaniye);//Bilgisayar Yeniden Başlatma
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Bilgisayar Iptal Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (soru == DialogResult.Yes)
            {
                lblMetin.Text = "";
                saniye = 59;
                tmrZaman.Enabled = false;
                txtDakika.ReadOnly = false;

                lblDakika.Text = "0";
                lblSaniye.Text = "0";

                System.Diagnostics.Process.Start("shutdown", "-a");//Iptal Etme
            }
        }
        
        int dakika = 0, saniye = 59;


        bool kapat;
        bool yenidenBaslama;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kapat == true || yenidenBaslama==true)
            {
                DialogResult soru;
                soru = MessageBox.Show("Uygulama Kapatılsın mı ? Işlemler Iptal Edilecek !", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (soru == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("shutdown", "-a");
                }

            }

        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            saniye--;
            lblSaniye.Text = saniye.ToString();

            if (saniye == 0)
            {
                saniye = 59;

                if (dakika == 0)
                {
                    lblDakika.Text = dakika.ToString();
                    tmrZaman.Enabled = false;
                    lblMetin.Text = "Bitti";

                    txtDakika.ReadOnly = false;
                }
                else
                {
                    dakika--;
                    lblDakika.Text = dakika.ToString();
                }
            }
        }
    }
}
