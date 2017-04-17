using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaşımı_Bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> yerListesi = new List<string>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string strYer = txtYer.Text;
            yerListesi.Add(strYer);
            lstYerler.Items.Add(strYer);

            txtYer.Text = "";//string.Empty;
            txtYer.Focus();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue <= yerListesi.Count && e.NewValue>0)
            {
                string yeniYer = yerListesi[e.NewValue-1];
                txtSiradakiYer.Text = yeniYer;
            }
            else
            {
                MessageBox.Show("Böyle bir yer yok !!!");
            }
        }
    }
}
