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
        private List<ViewModel> notes;
        private bool IsNew { get; set; }

        public Form1()
        {
            InitializeComponent();

            rbtnNormal.AutoCheck = true;
            notes = new List<ViewModel>();
            ToggleControlls();

            //Load sample notes
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ClearValues();
            ToggleControlls();

            IsNew = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                notes.Remove((lstNotlar.SelectedItem as ViewModel));
                UpdateList();
            }

            ToggleControlls();
            ClearValues();
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearValues();

            var note = (lstNotlar.SelectedItem as ViewModel);
            txtBaslık.Text = note.Baslık;
            txtNot.Text = note.Not;
            txtBaslık.Tag = note.Id;

            if (note.Oncelik == 1)
                rbtnOnemsiz.Checked = true;
            if (note.Oncelik == 2)
                rbtnNormal.Checked = true;
            if (note.Oncelik == 3)
                rbtnOnemli.Checked = true;

            if (!txtNot.Enabled)
                ToggleControlls();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {
                ViewModel note = new ViewModel();
                note.Baslık = txtBaslık.Text;
                note.Not = txtNot.Text;
                note.Oncelik = rbtnOnemsiz.Checked ? 1 : (rbtnNormal.Checked ? 2 : 3);

                notes.Add(note);
            }
            else
            {
                Guid id = new Guid(txtBaslık.Tag.ToString());
                var note = notes.Where(a => a.Id == id).FirstOrDefault();
                note.Baslık = txtBaslık.Text;
                note.Not = txtNot.Text;
                note.Oncelik = rbtnOnemsiz.Checked ? 1 : (rbtnNormal.Checked ? 2 : 3);

                notes.Remove(note);
                notes.Add(note);
            }

            UpdateList();

            ToggleControlls();
            ClearValues();

            IsNew = false;
        }

        private void UpdateList()
        {
            lstNotlar.BeginUpdate();
            lstNotlar.DataSource = notes;
            lstNotlar.EndUpdate();
        }

        private void ClearValues()
        {
            txtBaslık.Text = "";
            txtNot.Text = "";
            rbtnOnemsiz.Checked = false;
            rbtnNormal.Checked = true;
            rbtnOnemli.Checked = false;
        }

        private void ToggleControlls()
        {
            txtBaslık.Enabled = txtBaslık.Enabled ? false : true;
            txtNot.Enabled = txtNot.Enabled ? false : true;
            rbtnOnemsiz.Enabled = rbtnOnemsiz.Enabled ? false : true;
            rbtnNormal.Enabled = rbtnNormal.Enabled ? false : true;
            rbtnOnemli.Enabled = rbtnOnemli.Enabled ? false : true;
            btnKaydet.Enabled = btnKaydet.Enabled ? false : true;
            btnSil.Enabled = btnSil.Enabled ? false : true;
        }

        //private void lstNotlar_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    Graphics g = e.Graphics;
        //    Brush myBrush = Brushes.Black;
        //    Brush myBrush2 = Brushes.Red;
        //    g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
        //    e.Graphics.DrawString(lstNotlar.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
        //    for (int i = 0; i < lstNotlar.Items.Count; i++)
        //    {
        //        for (int j = 0; j < notes.Count; j++)
        //        {
        //            notes.Select(a=>a.Baslık)
        //            if (lstNotlar.Items[i].ToString().Contains())
        //            {
        //                e.Graphics.DrawString(lstNotlar.Items[i].ToString(),
        //                e.Font, myBrush2, e.Bounds, StringFormat.GenericDefault);
        //            }
        //        }
        //    }
        //    e.DrawFocusRectangle();

        //}
    }
}
