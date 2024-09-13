namespace WindowsFormsApp3
{
    partial class siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisler));
            this.geriDonButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silButon = new System.Windows.Forms.Button();
            this.veriKaydetButon = new System.Windows.Forms.Button();
            this.guncelleButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDonButon
            // 
            this.geriDonButon.Location = new System.Drawing.Point(630, 443);
            this.geriDonButon.Name = "geriDonButon";
            this.geriDonButon.Size = new System.Drawing.Size(200, 60);
            this.geriDonButon.TabIndex = 0;
            this.geriDonButon.Text = "Geri Dön";
            this.geriDonButon.UseVisualStyleBackColor = true;
            this.geriDonButon.Click += new System.EventHandler(this.geriDonButon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 424);
            this.dataGridView1.TabIndex = 1;
            // 
            // silButon
            // 
            this.silButon.Location = new System.Drawing.Point(12, 443);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(200, 60);
            this.silButon.TabIndex = 2;
            this.silButon.Text = "Seçili Satırı Sil";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.silButon_Click_1);
            // 
            // veriKaydetButon
            // 
            this.veriKaydetButon.Location = new System.Drawing.Point(218, 443);
            this.veriKaydetButon.Name = "veriKaydetButon";
            this.veriKaydetButon.Size = new System.Drawing.Size(200, 60);
            this.veriKaydetButon.TabIndex = 3;
            this.veriKaydetButon.Text = "Verileri Kaydet";
            this.veriKaydetButon.UseVisualStyleBackColor = true;
            this.veriKaydetButon.Click += new System.EventHandler(this.veriKaydetButon_Click);
            // 
            // guncelleButon
            // 
            this.guncelleButon.Location = new System.Drawing.Point(424, 443);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(200, 60);
            this.guncelleButon.TabIndex = 4;
            this.guncelleButon.Text = "Tabloyu Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = true;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click);
            // 
            // siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 515);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.veriKaydetButon);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriDonButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "siparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDonButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Button veriKaydetButon;
        private System.Windows.Forms.Button guncelleButon;
    }
}