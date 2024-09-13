namespace WindowsFormsApp3
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label2 = new System.Windows.Forms.Label();
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreTextbox = new System.Windows.Forms.TextBox();
            this.kayitButon = new System.Windows.Forms.Button();
            this.girisButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adınız:";
            // 
            // adTextbox
            // 
            this.adTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTextbox.Location = new System.Drawing.Point(118, 187);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(176, 27);
            this.adTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre:";
            // 
            // sifreTextbox
            // 
            this.sifreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextbox.Location = new System.Drawing.Point(118, 234);
            this.sifreTextbox.MaxLength = 30;
            this.sifreTextbox.Name = "sifreTextbox";
            this.sifreTextbox.PasswordChar = '*';
            this.sifreTextbox.Size = new System.Drawing.Size(176, 27);
            this.sifreTextbox.TabIndex = 4;
            // 
            // kayitButon
            // 
            this.kayitButon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kayitButon.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayitButon.Location = new System.Drawing.Point(118, 277);
            this.kayitButon.Name = "kayitButon";
            this.kayitButon.Size = new System.Drawing.Size(90, 30);
            this.kayitButon.TabIndex = 5;
            this.kayitButon.Text = "Kayıt Ol";
            this.kayitButon.UseVisualStyleBackColor = false;
            this.kayitButon.Click += new System.EventHandler(this.kayitButon_Click);
            // 
            // girisButon
            // 
            this.girisButon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.girisButon.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.girisButon.Location = new System.Drawing.Point(118, 313);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(90, 30);
            this.girisButon.TabIndex = 6;
            this.girisButon.Text = "Giriş Yap";
            this.girisButon.UseVisualStyleBackColor = false;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.shop2;
            this.pictureBox1.Location = new System.Drawing.Point(118, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitButon);
            this.Controls.Add(this.sifreTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adTextbox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreTextbox;
        private System.Windows.Forms.Button kayitButon;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

