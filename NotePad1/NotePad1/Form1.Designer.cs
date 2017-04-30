namespace NotePad1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.viewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNot = new System.Windows.Forms.TextBox();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaslık = new System.Windows.Forms.TextBox();
            this.rbtnOnemsiz = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnOnemli = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Green;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(12, 437);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 37);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(93, 437);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 39);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKaydet.Location = new System.Drawing.Point(174, 439);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(451, 37);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstNotlar
            // 
            this.lstNotlar.DataSource = this.viewModelBindingSource;
            this.lstNotlar.DisplayMember = "Baslık";
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.Location = new System.Drawing.Point(12, 38);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(75, 394);
            this.lstNotlar.TabIndex = 999;
            this.lstNotlar.SelectedIndexChanged += new System.EventHandler(this.lstNotlar_SelectedIndexChanged);
            // 
            // viewModelBindingSource
            // 
            this.viewModelBindingSource.DataSource = typeof(NotePad1.ViewModel);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(93, 64);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(532, 344);
            this.txtNot.TabIndex = 2;
            // 
            // lblNotlar
            // 
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotlar.Location = new System.Drawing.Point(13, 13);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(57, 20);
            this.lblNotlar.TabIndex = 5;
            this.lblNotlar.Text = "Notlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Not Ekleme";
            // 
            // txtBaslık
            // 
            this.txtBaslık.Location = new System.Drawing.Point(93, 38);
            this.txtBaslık.Name = "txtBaslık";
            this.txtBaslık.Size = new System.Drawing.Size(532, 20);
            this.txtBaslık.TabIndex = 1;
            // 
            // rbtnOnemsiz
            // 
            this.rbtnOnemsiz.AutoSize = true;
            this.rbtnOnemsiz.Location = new System.Drawing.Point(93, 414);
            this.rbtnOnemsiz.Name = "rbtnOnemsiz";
            this.rbtnOnemsiz.Size = new System.Drawing.Size(65, 17);
            this.rbtnOnemsiz.TabIndex = 1000;
            this.rbtnOnemsiz.TabStop = true;
            this.rbtnOnemsiz.Text = "Onemsiz";
            this.rbtnOnemsiz.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Location = new System.Drawing.Point(164, 414);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(58, 17);
            this.rbtnNormal.TabIndex = 1001;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Normal";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // rbtnOnemli
            // 
            this.rbtnOnemli.AutoSize = true;
            this.rbtnOnemli.Location = new System.Drawing.Point(228, 414);
            this.rbtnOnemli.Name = "rbtnOnemli";
            this.rbtnOnemli.Size = new System.Drawing.Size(57, 17);
            this.rbtnOnemli.TabIndex = 1002;
            this.rbtnOnemli.TabStop = true;
            this.rbtnOnemli.Text = "Onemli";
            this.rbtnOnemli.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSil;
            this.ClientSize = new System.Drawing.Size(659, 488);
            this.Controls.Add(this.rbtnOnemli);
            this.Controls.Add(this.rbtnNormal);
            this.Controls.Add(this.rbtnOnemsiz);
            this.Controls.Add(this.txtBaslık);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotlar);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.viewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslık;
        private System.Windows.Forms.RadioButton rbtnOnemsiz;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.RadioButton rbtnOnemli;
        private System.Windows.Forms.BindingSource viewModelBindingSource;
    }
}

