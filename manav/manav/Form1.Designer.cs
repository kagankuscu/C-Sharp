namespace manav
{
    partial class form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmDomatesKilo = new System.Windows.Forms.NumericUpDown();
            this.nmDomatesFiyat = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmPatatesToplamKilo = new System.Windows.Forms.NumericUpDown();
            this.nmDomatesToplamKilo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nmToplamfiyat = new System.Windows.Forms.NumericUpDown();
            this.btnSepet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmPatatesFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmPatatesKilo = new System.Windows.Forms.NumericUpDown();
            this.nmOdenenPara = new System.Windows.Forms.NumericUpDown();
            this.nmParaUstu = new System.Windows.Forms.NumericUpDown();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnParaUstuHesaplama = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesFiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatesToplamKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesToplamKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatesFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatesKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOdenenPara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmParaUstu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(281, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // nmDomatesKilo
            // 
            this.nmDomatesKilo.Location = new System.Drawing.Point(176, 82);
            this.nmDomatesKilo.Name = "nmDomatesKilo";
            this.nmDomatesKilo.Size = new System.Drawing.Size(83, 20);
            this.nmDomatesKilo.TabIndex = 3;
            // 
            // nmDomatesFiyat
            // 
            this.nmDomatesFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmDomatesFiyat.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmDomatesFiyat.Location = new System.Drawing.Point(284, 82);
            this.nmDomatesFiyat.Name = "nmDomatesFiyat";
            this.nmDomatesFiyat.ReadOnly = true;
            this.nmDomatesFiyat.Size = new System.Drawing.Size(83, 20);
            this.nmDomatesFiyat.TabIndex = 4;
            this.nmDomatesFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmPatatesToplamKilo);
            this.groupBox1.Controls.Add(this.nmDomatesToplamKilo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nmToplamfiyat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fiyat";
            // 
            // nmPatatesToplamKilo
            // 
            this.nmPatatesToplamKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmPatatesToplamKilo.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmPatatesToplamKilo.Location = new System.Drawing.Point(123, 80);
            this.nmPatatesToplamKilo.Name = "nmPatatesToplamKilo";
            this.nmPatatesToplamKilo.ReadOnly = true;
            this.nmPatatesToplamKilo.Size = new System.Drawing.Size(83, 23);
            this.nmPatatesToplamKilo.TabIndex = 13;
            this.nmPatatesToplamKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmDomatesToplamKilo
            // 
            this.nmDomatesToplamKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmDomatesToplamKilo.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmDomatesToplamKilo.InterceptArrowKeys = false;
            this.nmDomatesToplamKilo.Location = new System.Drawing.Point(123, 50);
            this.nmDomatesToplamKilo.Name = "nmDomatesToplamKilo";
            this.nmDomatesToplamKilo.ReadOnly = true;
            this.nmDomatesToplamKilo.Size = new System.Drawing.Size(83, 23);
            this.nmDomatesToplamKilo.TabIndex = 12;
            this.nmDomatesToplamKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Patates";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Lime;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(260, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 81);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Domates";
            // 
            // nmToplamfiyat
            // 
            this.nmToplamfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmToplamfiyat.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmToplamfiyat.InterceptArrowKeys = false;
            this.nmToplamfiyat.Location = new System.Drawing.Point(123, 19);
            this.nmToplamfiyat.Name = "nmToplamfiyat";
            this.nmToplamfiyat.ReadOnly = true;
            this.nmToplamfiyat.Size = new System.Drawing.Size(83, 23);
            this.nmToplamfiyat.TabIndex = 0;
            this.nmToplamfiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSepet
            // 
            this.btnSepet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSepet.Location = new System.Drawing.Point(284, 168);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(85, 23);
            this.btnSepet.TabIndex = 6;
            this.btnSepet.Text = "Sepete Ekle";
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(75, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patates";
            // 
            // nmPatatesFiyat
            // 
            this.nmPatatesFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmPatatesFiyat.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmPatatesFiyat.Location = new System.Drawing.Point(284, 125);
            this.nmPatatesFiyat.Name = "nmPatatesFiyat";
            this.nmPatatesFiyat.ReadOnly = true;
            this.nmPatatesFiyat.Size = new System.Drawing.Size(83, 20);
            this.nmPatatesFiyat.TabIndex = 9;
            this.nmPatatesFiyat.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nmPatatesKilo
            // 
            this.nmPatatesKilo.Location = new System.Drawing.Point(176, 125);
            this.nmPatatesKilo.Name = "nmPatatesKilo";
            this.nmPatatesKilo.Size = new System.Drawing.Size(83, 20);
            this.nmPatatesKilo.TabIndex = 8;
            // 
            // nmOdenenPara
            // 
            this.nmOdenenPara.Location = new System.Drawing.Point(168, 74);
            this.nmOdenenPara.Name = "nmOdenenPara";
            this.nmOdenenPara.Size = new System.Drawing.Size(85, 20);
            this.nmOdenenPara.TabIndex = 10;
            this.nmOdenenPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmParaUstu
            // 
            this.nmParaUstu.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmParaUstu.InterceptArrowKeys = false;
            this.nmParaUstu.Location = new System.Drawing.Point(168, 110);
            this.nmParaUstu.Name = "nmParaUstu";
            this.nmParaUstu.ReadOnly = true;
            this.nmParaUstu.Size = new System.Drawing.Size(85, 20);
            this.nmParaUstu.TabIndex = 11;
            this.nmParaUstu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeme.Location = new System.Drawing.Point(66, 77);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(59, 17);
            this.lblOdeme.TabIndex = 12;
            this.lblOdeme.Text = "Ödeme";
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.Location = new System.Drawing.Point(66, 113);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(80, 17);
            this.lblParaUstu.TabIndex = 13;
            this.lblParaUstu.Text = "Para Üstü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnParaUstuHesaplama);
            this.groupBox2.Controls.Add(this.lblOdeme);
            this.groupBox2.Controls.Add(this.lblParaUstu);
            this.groupBox2.Controls.Add(this.nmOdenenPara);
            this.groupBox2.Controls.Add(this.nmParaUstu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(505, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 214);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para";
            // 
            // btnParaUstuHesaplama
            // 
            this.btnParaUstuHesaplama.BackColor = System.Drawing.Color.Lime;
            this.btnParaUstuHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaUstuHesaplama.Location = new System.Drawing.Point(69, 139);
            this.btnParaUstuHesaplama.Name = "btnParaUstuHesaplama";
            this.btnParaUstuHesaplama.Size = new System.Drawing.Size(184, 57);
            this.btnParaUstuHesaplama.TabIndex = 14;
            this.btnParaUstuHesaplama.Text = "Hesapla";
            this.btnParaUstuHesaplama.UseVisualStyleBackColor = false;
            this.btnParaUstuHesaplama.Click += new System.EventHandler(this.btnParaUstuHesaplama_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(16, 29);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(228, 20);
            this.txtTarih.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(32, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tarih";
            // 
            // form1
            // 
            this.AcceptButton = this.btnParaUstuHesaplama;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 329);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nmPatatesFiyat);
            this.Controls.Add(this.nmPatatesKilo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nmDomatesFiyat);
            this.Controls.Add(this.nmDomatesKilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(683, 384);
            this.MaximumSize = new System.Drawing.Size(842, 367);
            this.MinimumSize = new System.Drawing.Size(842, 367);
            this.Name = "form1";
            this.Opacity = 0.1D;
            this.Text = "Manav";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesFiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatesToplamKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomatesToplamKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToplamfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatesFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatatesKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOdenenPara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmParaUstu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmDomatesKilo;
        private System.Windows.Forms.NumericUpDown nmDomatesFiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmToplamfiyat;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmPatatesFiyat;
        private System.Windows.Forms.NumericUpDown nmPatatesKilo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmPatatesToplamKilo;
        private System.Windows.Forms.NumericUpDown nmDomatesToplamKilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmOdenenPara;
        private System.Windows.Forms.NumericUpDown nmParaUstu;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParaUstuHesaplama;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label8;
    }
}

