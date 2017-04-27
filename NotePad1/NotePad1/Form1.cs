using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstNotlar.Items.Add(txtNot.Text);
            txtNot.Text = "";
            txtNot.Focus();

            lstNotlar.Items.Remove(lstNotlar.SelectedItem);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstNotlar.Items.Remove(lstNotlar.SelectedItem);
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNot.Text = lstNotlar.Text;
            
        }
    }
}
