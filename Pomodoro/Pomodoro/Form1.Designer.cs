namespace Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.lblDakika = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmrCalisma = new System.Windows.Forms.Timer(this.components);
            this.tmrDinlenme = new System.Windows.Forms.Timer(this.components);
            this.txtCalismaDakika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDinlenmeDakika = new System.Windows.Forms.TextBox();
            this.chkbPomodoro1 = new System.Windows.Forms.CheckBox();
            this.chkbPomodoro2 = new System.Windows.Forms.CheckBox();
            this.chkbPomodoro3 = new System.Windows.Forms.CheckBox();
            this.chkbPomodoro4 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkb4 = new System.Windows.Forms.CheckBox();
            this.chkb3 = new System.Windows.Forms.CheckBox();
            this.chkb2 = new System.Windows.Forms.CheckBox();
            this.chkb1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.Lime;
            this.btnBaslat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnBaslat, "btnBaslat");
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Red;
            this.btnDurdur.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnDurdur, "btnDurdur");
            this.btnDurdur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // lblDakika
            // 
            resources.ApplyResources(this.lblDakika, "lblDakika");
            this.lblDakika.Name = "lblDakika";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblSaniye
            // 
            resources.ApplyResources(this.lblSaniye, "lblSaniye");
            this.lblSaniye.Name = "lblSaniye";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDakika);
            this.groupBox1.Controls.Add(this.lblSaniye);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tmrCalisma
            // 
            this.tmrCalisma.Interval = 250;
            this.tmrCalisma.Tick += new System.EventHandler(this.tmrCalisma_Tick);
            // 
            // tmrDinlenme
            // 
            this.tmrDinlenme.Interval = 250;
            this.tmrDinlenme.Tick += new System.EventHandler(this.tmrDinlenme_Tick);
            // 
            // txtCalismaDakika
            // 
            resources.ApplyResources(this.txtCalismaDakika, "txtCalismaDakika");
            this.txtCalismaDakika.Name = "txtCalismaDakika";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDinlenmeDakika
            // 
            resources.ApplyResources(this.txtDinlenmeDakika, "txtDinlenmeDakika");
            this.txtDinlenmeDakika.Name = "txtDinlenmeDakika";
            // 
            // chkbPomodoro1
            // 
            resources.ApplyResources(this.chkbPomodoro1, "chkbPomodoro1");
            this.chkbPomodoro1.Name = "chkbPomodoro1";
            this.chkbPomodoro1.UseVisualStyleBackColor = true;
            this.chkbPomodoro1.CheckedChanged += new System.EventHandler(this.chkbPomodoro1_CheckedChanged);
            // 
            // chkbPomodoro2
            // 
            resources.ApplyResources(this.chkbPomodoro2, "chkbPomodoro2");
            this.chkbPomodoro2.Name = "chkbPomodoro2";
            this.chkbPomodoro2.UseVisualStyleBackColor = true;
            this.chkbPomodoro2.CheckedChanged += new System.EventHandler(this.chkbPomodoro2_CheckedChanged);
            // 
            // chkbPomodoro3
            // 
            resources.ApplyResources(this.chkbPomodoro3, "chkbPomodoro3");
            this.chkbPomodoro3.Name = "chkbPomodoro3";
            this.chkbPomodoro3.UseVisualStyleBackColor = true;
            this.chkbPomodoro3.CheckedChanged += new System.EventHandler(this.chkbPomodoro3_CheckedChanged);
            // 
            // chkbPomodoro4
            // 
            resources.ApplyResources(this.chkbPomodoro4, "chkbPomodoro4");
            this.chkbPomodoro4.Name = "chkbPomodoro4";
            this.chkbPomodoro4.UseVisualStyleBackColor = true;
            this.chkbPomodoro4.CheckedChanged += new System.EventHandler(this.chkbPomodoro4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbPomodoro2);
            this.groupBox2.Controls.Add(this.chkbPomodoro1);
            this.groupBox2.Controls.Add(this.chkbPomodoro3);
            this.groupBox2.Controls.Add(this.chkbPomodoro4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chkb4
            // 
            resources.ApplyResources(this.chkb4, "chkb4");
            this.chkb4.Name = "chkb4";
            this.chkb4.UseVisualStyleBackColor = true;
            this.chkb4.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chkb3
            // 
            resources.ApplyResources(this.chkb3, "chkb3");
            this.chkb3.Name = "chkb3";
            this.chkb3.UseVisualStyleBackColor = true;
            this.chkb3.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chkb2
            // 
            resources.ApplyResources(this.chkb2, "chkb2");
            this.chkb2.Name = "chkb2";
            this.chkb2.UseVisualStyleBackColor = true;
            this.chkb2.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // chkb1
            // 
            resources.ApplyResources(this.chkb1, "chkb1");
            this.chkb1.Name = "chkb1";
            this.chkb1.UseVisualStyleBackColor = true;
            this.chkb1.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBaslat;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnDurdur;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkb4);
            this.Controls.Add(this.chkb3);
            this.Controls.Add(this.txtCalismaDakika);
            this.Controls.Add(this.chkb2);
            this.Controls.Add(this.txtDinlenmeDakika);
            this.Controls.Add(this.chkb1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBaslat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer tmrCalisma;
        private System.Windows.Forms.Timer tmrDinlenme;
        private System.Windows.Forms.TextBox txtCalismaDakika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDinlenmeDakika;
        private System.Windows.Forms.CheckBox chkbPomodoro1;
        private System.Windows.Forms.CheckBox chkbPomodoro2;
        private System.Windows.Forms.CheckBox chkbPomodoro3;
        private System.Windows.Forms.CheckBox chkbPomodoro4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkb4;
        private System.Windows.Forms.CheckBox chkb3;
        private System.Windows.Forms.CheckBox chkb2;
        private System.Windows.Forms.CheckBox chkb1;
        private System.Windows.Forms.Label label3;
    }
}

