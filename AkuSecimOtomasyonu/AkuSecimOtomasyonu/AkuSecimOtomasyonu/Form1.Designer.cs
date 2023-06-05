namespace AkuSecimOtomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yil_cb = new System.Windows.Forms.ComboBox();
            this.marka_cb = new System.Windows.Forms.ComboBox();
            this.model_cb = new System.Windows.Forms.ComboBox();
            this.altModel_cb = new System.Windows.Forms.ComboBox();
            this.bul_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.en_lbl = new System.Windows.Forms.Label();
            this.boy_lbl = new System.Windows.Forms.Label();
            this.yukseklik_lbl = new System.Windows.Forms.Label();
            this.akuTipi_lbl = new System.Windows.Forms.Label();
            this.dbKayit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yil_cb
            // 
            this.yil_cb.BackColor = System.Drawing.SystemColors.Info;
            this.yil_cb.FormattingEnabled = true;
            this.yil_cb.Location = new System.Drawing.Point(60, 50);
            this.yil_cb.Name = "yil_cb";
            this.yil_cb.Size = new System.Drawing.Size(152, 24);
            this.yil_cb.TabIndex = 0;
            this.yil_cb.Text = "Yılı Seçiniz...";
            this.yil_cb.SelectedIndexChanged += new System.EventHandler(this.yil_cb_SelectedIndexChanged);
            // 
            // marka_cb
            // 
            this.marka_cb.BackColor = System.Drawing.SystemColors.Info;
            this.marka_cb.Enabled = false;
            this.marka_cb.FormattingEnabled = true;
            this.marka_cb.Location = new System.Drawing.Point(218, 50);
            this.marka_cb.Name = "marka_cb";
            this.marka_cb.Size = new System.Drawing.Size(161, 24);
            this.marka_cb.TabIndex = 1;
            this.marka_cb.Text = "Araç Markası Seçiniz...";
            this.marka_cb.SelectedIndexChanged += new System.EventHandler(this.marka_cb_SelectedIndexChanged);
            // 
            // model_cb
            // 
            this.model_cb.BackColor = System.Drawing.SystemColors.Info;
            this.model_cb.Enabled = false;
            this.model_cb.FormattingEnabled = true;
            this.model_cb.Location = new System.Drawing.Point(385, 50);
            this.model_cb.Name = "model_cb";
            this.model_cb.Size = new System.Drawing.Size(168, 24);
            this.model_cb.TabIndex = 2;
            this.model_cb.Text = "Araç Modelini Seçiniz...";
            this.model_cb.SelectedIndexChanged += new System.EventHandler(this.model_cb_SelectedIndexChanged);
            // 
            // altModel_cb
            // 
            this.altModel_cb.BackColor = System.Drawing.SystemColors.Info;
            this.altModel_cb.Enabled = false;
            this.altModel_cb.FormattingEnabled = true;
            this.altModel_cb.Location = new System.Drawing.Point(559, 50);
            this.altModel_cb.Name = "altModel_cb";
            this.altModel_cb.Size = new System.Drawing.Size(172, 24);
            this.altModel_cb.TabIndex = 3;
            this.altModel_cb.Text = "Model Alt Grup Seçiniz...";
            this.altModel_cb.SelectedIndexChanged += new System.EventHandler(this.altModel_cb_SelectedIndexChanged);
            // 
            // bul_btn
            // 
            this.bul_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bul_btn.Enabled = false;
            this.bul_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bul_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bul_btn.Location = new System.Drawing.Point(253, 101);
            this.bul_btn.Margin = new System.Windows.Forms.Padding(0);
            this.bul_btn.Name = "bul_btn";
            this.bul_btn.Size = new System.Drawing.Size(253, 48);
            this.bul_btn.TabIndex = 4;
            this.bul_btn.Text = "Akümü Bul";
            this.bul_btn.UseVisualStyleBackColor = false;
            this.bul_btn.Click += new System.EventHandler(this.bul_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Akü bilgilerinin gelmesi için katagorileri eksiksiz bir biçimde seçiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "En";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Boy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yükseklik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(302, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(302, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(302, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = ":";
            // 
            // en_lbl
            // 
            this.en_lbl.AutoSize = true;
            this.en_lbl.Location = new System.Drawing.Point(321, 230);
            this.en_lbl.Name = "en_lbl";
            this.en_lbl.Size = new System.Drawing.Size(0, 16);
            this.en_lbl.TabIndex = 10;
            // 
            // boy_lbl
            // 
            this.boy_lbl.AutoSize = true;
            this.boy_lbl.Location = new System.Drawing.Point(321, 268);
            this.boy_lbl.Name = "boy_lbl";
            this.boy_lbl.Size = new System.Drawing.Size(0, 16);
            this.boy_lbl.TabIndex = 10;
            // 
            // yukseklik_lbl
            // 
            this.yukseklik_lbl.AutoSize = true;
            this.yukseklik_lbl.Location = new System.Drawing.Point(321, 309);
            this.yukseklik_lbl.Name = "yukseklik_lbl";
            this.yukseklik_lbl.Size = new System.Drawing.Size(0, 16);
            this.yukseklik_lbl.TabIndex = 10;
            // 
            // akuTipi_lbl
            // 
            this.akuTipi_lbl.AutoSize = true;
            this.akuTipi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akuTipi_lbl.Location = new System.Drawing.Point(403, 260);
            this.akuTipi_lbl.Name = "akuTipi_lbl";
            this.akuTipi_lbl.Size = new System.Drawing.Size(0, 29);
            this.akuTipi_lbl.TabIndex = 11;
            // 
            // dbKayit_btn
            // 
            this.dbKayit_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dbKayit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbKayit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbKayit_btn.Location = new System.Drawing.Point(278, 375);
            this.dbKayit_btn.Margin = new System.Windows.Forms.Padding(0);
            this.dbKayit_btn.Name = "dbKayit_btn";
            this.dbKayit_btn.Size = new System.Drawing.Size(201, 48);
            this.dbKayit_btn.TabIndex = 12;
            this.dbKayit_btn.Text = "Yeni Veri Girişi";
            this.dbKayit_btn.UseVisualStyleBackColor = false;
            this.dbKayit_btn.Click += new System.EventHandler(this.dbKayit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbKayit_btn);
            this.Controls.Add(this.akuTipi_lbl);
            this.Controls.Add(this.yukseklik_lbl);
            this.Controls.Add(this.boy_lbl);
            this.Controls.Add(this.en_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bul_btn);
            this.Controls.Add(this.altModel_cb);
            this.Controls.Add(this.model_cb);
            this.Controls.Add(this.marka_cb);
            this.Controls.Add(this.yil_cb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akü Seçim Otomasyonu-Şaban TUNÇ-192523215";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yil_cb;
        private System.Windows.Forms.ComboBox marka_cb;
        private System.Windows.Forms.ComboBox model_cb;
        private System.Windows.Forms.ComboBox altModel_cb;
        private System.Windows.Forms.Button bul_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label en_lbl;
        private System.Windows.Forms.Label boy_lbl;
        private System.Windows.Forms.Label yukseklik_lbl;
        private System.Windows.Forms.Label akuTipi_lbl;
        private System.Windows.Forms.Button dbKayit_btn;
    }
}

