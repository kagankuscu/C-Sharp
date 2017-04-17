namespace Yaşımı_Bul
{
    partial class Form1
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
            this.txtYer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstYerler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.txtSiradakiYer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtYer
            // 
            this.txtYer.Location = new System.Drawing.Point(12, 55);
            this.txtYer.Multiline = true;
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(120, 55);
            this.txtYer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görülecek Yerler";
            // 
            // lstYerler
            // 
            this.lstYerler.FormattingEnabled = true;
            this.lstYerler.Location = new System.Drawing.Point(12, 147);
            this.lstYerler.Name = "lstYerler";
            this.lstYerler.Size = new System.Drawing.Size(120, 160);
            this.lstYerler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tüm Yerler";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(177, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 55);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(135, 290);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(175, 17);
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // txtSiradakiYer
            // 
            this.txtSiradakiYer.BackColor = System.Drawing.Color.Lime;
            this.txtSiradakiYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiradakiYer.ForeColor = System.Drawing.Color.Black;
            this.txtSiradakiYer.Location = new System.Drawing.Point(139, 147);
            this.txtSiradakiYer.Multiline = true;
            this.txtSiradakiYer.Name = "txtSiradakiYer";
            this.txtSiradakiYer.Size = new System.Drawing.Size(171, 140);
            this.txtSiradakiYer.TabIndex = 6;
            this.txtSiradakiYer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 316);
            this.Controls.Add(this.txtSiradakiYer);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstYerler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstYerler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox txtSiradakiYer;
    }
}

