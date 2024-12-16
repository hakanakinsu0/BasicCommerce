namespace Project.WinFormUI
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
            this.BtnPasif = new System.Windows.Forms.Button();
            this.BtnGuncel = new System.Windows.Forms.Button();
            this.BtnAktif = new System.Windows.Forms.Button();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.BtnYokEt = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnPasif
            // 
            this.BtnPasif.Location = new System.Drawing.Point(932, 518);
            this.BtnPasif.Name = "BtnPasif";
            this.BtnPasif.Size = new System.Drawing.Size(176, 53);
            this.BtnPasif.TabIndex = 12;
            this.BtnPasif.Text = "Pasifleri Getir";
            this.BtnPasif.UseVisualStyleBackColor = true;
            this.BtnPasif.Click += new System.EventHandler(this.BtnPasif_Click);
            // 
            // BtnGuncel
            // 
            this.BtnGuncel.Location = new System.Drawing.Point(713, 518);
            this.BtnGuncel.Name = "BtnGuncel";
            this.BtnGuncel.Size = new System.Drawing.Size(193, 53);
            this.BtnGuncel.TabIndex = 13;
            this.BtnGuncel.Text = "Guncelleneleri Getir";
            this.BtnGuncel.UseVisualStyleBackColor = true;
            this.BtnGuncel.Click += new System.EventHandler(this.BtnGuncel_Click);
            // 
            // BtnAktif
            // 
            this.BtnAktif.Location = new System.Drawing.Point(497, 518);
            this.BtnAktif.Name = "BtnAktif";
            this.BtnAktif.Size = new System.Drawing.Size(176, 53);
            this.BtnAktif.TabIndex = 14;
            this.BtnAktif.Text = "Aktfileri Getir";
            this.BtnAktif.UseVisualStyleBackColor = true;
            this.BtnAktif.Click += new System.EventHandler(this.BtnAktif_Click);
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(93, 462);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(136, 20);
            this.TxtAciklama.TabIndex = 10;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(94, 407);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(136, 20);
            this.TxtIsim.TabIndex = 11;
            // 
            // BtnYokEt
            // 
            this.BtnYokEt.Location = new System.Drawing.Point(112, 307);
            this.BtnYokEt.Name = "BtnYokEt";
            this.BtnYokEt.Size = new System.Drawing.Size(140, 40);
            this.BtnYokEt.TabIndex = 9;
            this.BtnYokEt.Text = "Yok Et";
            this.BtnYokEt.UseVisualStyleBackColor = true;
            this.BtnYokEt.Click += new System.EventHandler(this.BtnYokEt_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(112, 224);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(140, 39);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(112, 146);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(140, 39);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(112, 79);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(140, 39);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LstResult
            // 
            this.LstResult.FormattingEnabled = true;
            this.LstResult.Location = new System.Drawing.Point(314, 79);
            this.LstResult.Margin = new System.Windows.Forms.Padding(4);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(1094, 394);
            this.LstResult.TabIndex = 5;
            this.LstResult.Click += new System.EventHandler(this.LstResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 651);
            this.Controls.Add(this.BtnPasif);
            this.Controls.Add(this.BtnGuncel);
            this.Controls.Add(this.BtnAktif);
            this.Controls.Add(this.TxtAciklama);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.BtnYokEt);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LstResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPasif;
        private System.Windows.Forms.Button BtnGuncel;
        private System.Windows.Forms.Button BtnAktif;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Button BtnYokEt;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox LstResult;
    }
}

