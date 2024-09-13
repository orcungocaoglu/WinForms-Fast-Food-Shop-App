namespace WindowsFormsApp3
{
    partial class Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kayitButon = new System.Windows.Forms.Button();
            this.sifreTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ePostaTextbox = new System.Windows.Forms.TextBox();
            this.ePostaLabel = new System.Windows.Forms.Label();
            this.geriDonButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.shop2;
            this.pictureBox1.Location = new System.Drawing.Point(118, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kayıt";
            // 
            // kayitButon
            // 
            this.kayitButon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kayitButon.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayitButon.Location = new System.Drawing.Point(118, 324);
            this.kayitButon.Name = "kayitButon";
            this.kayitButon.Size = new System.Drawing.Size(90, 30);
            this.kayitButon.TabIndex = 13;
            this.kayitButon.Text = "Kayıt Ol";
            this.kayitButon.UseVisualStyleBackColor = false;
            this.kayitButon.Click += new System.EventHandler(this.kayitButon_Click);
            // 
            // sifreTextbox
            // 
            this.sifreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextbox.Location = new System.Drawing.Point(138, 235);
            this.sifreTextbox.MaxLength = 30;
            this.sifreTextbox.Name = "sifreTextbox";
            this.sifreTextbox.PasswordChar = '*';
            this.sifreTextbox.Size = new System.Drawing.Size(149, 27);
            this.sifreTextbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre:";
            // 
            // adTextbox
            // 
            this.adTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTextbox.Location = new System.Drawing.Point(138, 188);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(149, 27);
            this.adTextbox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adınız:";
            // 
            // ePostaTextbox
            // 
            this.ePostaTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ePostaTextbox.Location = new System.Drawing.Point(138, 282);
            this.ePostaTextbox.MaxLength = 30;
            this.ePostaTextbox.Name = "ePostaTextbox";
            this.ePostaTextbox.Size = new System.Drawing.Size(149, 27);
            this.ePostaTextbox.TabIndex = 15;
            // 
            // ePostaLabel
            // 
            this.ePostaLabel.AutoSize = true;
            this.ePostaLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ePostaLabel.Location = new System.Drawing.Point(52, 282);
            this.ePostaLabel.Name = "ePostaLabel";
            this.ePostaLabel.Size = new System.Drawing.Size(75, 25);
            this.ePostaLabel.TabIndex = 14;
            this.ePostaLabel.Text = "E-Posta:";
            // 
            // geriDonButon
            // 
            this.geriDonButon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.geriDonButon.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriDonButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.geriDonButon.Location = new System.Drawing.Point(118, 360);
            this.geriDonButon.Name = "geriDonButon";
            this.geriDonButon.Size = new System.Drawing.Size(90, 30);
            this.geriDonButon.TabIndex = 16;
            this.geriDonButon.Text = "Geri Dön";
            this.geriDonButon.UseVisualStyleBackColor = false;
            this.geriDonButon.Click += new System.EventHandler(this.geriDonButon_Click);
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 410);
            this.Controls.Add(this.geriDonButon);
            this.Controls.Add(this.ePostaTextbox);
            this.Controls.Add(this.ePostaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitButon);
            this.Controls.Add(this.sifreTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adTextbox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitButon;
        private System.Windows.Forms.TextBox sifreTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ePostaTextbox;
        private System.Windows.Forms.Label ePostaLabel;
        private System.Windows.Forms.Button geriDonButon;
    }
}