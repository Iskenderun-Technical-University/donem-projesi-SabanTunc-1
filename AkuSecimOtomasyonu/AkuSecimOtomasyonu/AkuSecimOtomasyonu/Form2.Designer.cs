namespace AkuSecimOtomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.guncelleSil_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMarkalar = new System.Windows.Forms.TabPage();
            this.marka_dgw = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.markaVazgec_btn = new System.Windows.Forms.Button();
            this.markaGuncelle_btn = new System.Windows.Forms.Button();
            this.markaEkle_tb = new System.Windows.Forms.TextBox();
            this.markaEkle_btn = new System.Windows.Forms.Button();
            this.markaEkle_lb = new System.Windows.Forms.Label();
            this.modelTabPage = new System.Windows.Forms.TabPage();
            this.model_dgw = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modelVazgec_btn = new System.Windows.Forms.Button();
            this.modelGuncelle_btn = new System.Windows.Forms.Button();
            this.modelEkle_btn = new System.Windows.Forms.Button();
            this.modelEkle_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.model_markalar_cb = new System.Windows.Forms.ComboBox();
            this.altGroupTabPage = new System.Windows.Forms.TabPage();
            this.altGroup_dgw = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxYil_tb = new System.Windows.Forms.TextBox();
            this.minYil_tb = new System.Windows.Forms.TextBox();
            this.yukseklik_tb = new System.Windows.Forms.TextBox();
            this.boy_tb = new System.Windows.Forms.TextBox();
            this.en_tb = new System.Windows.Forms.TextBox();
            this.altGroupVazgec_btn = new System.Windows.Forms.Button();
            this.altGroupGuncelle_btn = new System.Windows.Forms.Button();
            this.altGroupEkle_btn = new System.Windows.Forms.Button();
            this.altGroupEkle_tb = new System.Windows.Forms.TextBox();
            this.altGroup_model_cb = new System.Windows.Forms.ComboBox();
            this.altGroup_marka_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aku_dgw = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.akuVazgec_btn = new System.Windows.Forms.Button();
            this.akuGuncelle_btn = new System.Windows.Forms.Button();
            this.akuEkle_btn = new System.Windows.Forms.Button();
            this.akuYukseklik_tb = new System.Windows.Forms.TextBox();
            this.akuBoy_tb = new System.Windows.Forms.TextBox();
            this.akuEn_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.aku_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.guncelleSil_cms.SuspendLayout();
            this.tabMarkalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marka_dgw)).BeginInit();
            this.panel4.SuspendLayout();
            this.modelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model_dgw)).BeginInit();
            this.panel1.SuspendLayout();
            this.altGroupTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altGroup_dgw)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aku_dgw)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.guncelleSil_cms;
            this.tabControl1.Controls.Add(this.tabMarkalar);
            this.tabControl1.Controls.Add(this.modelTabPage);
            this.tabControl1.Controls.Add(this.altGroupTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // guncelleSil_cms
            // 
            this.guncelleSil_cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guncelleSil_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.guncelleSil_cms.Name = "aku_cms";
            this.guncelleSil_cms.Size = new System.Drawing.Size(136, 52);
            this.guncelleSil_cms.Opening += new System.ComponentModel.CancelEventHandler(this.aku_cms_Opening);
            this.guncelleSil_cms.VisibleChanged += new System.EventHandler(this.aku_cms_VisibleChanged);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tabMarkalar
            // 
            this.tabMarkalar.Controls.Add(this.marka_dgw);
            this.tabMarkalar.Controls.Add(this.panel4);
            this.tabMarkalar.Location = new System.Drawing.Point(4, 25);
            this.tabMarkalar.Name = "tabMarkalar";
            this.tabMarkalar.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarkalar.Size = new System.Drawing.Size(792, 421);
            this.tabMarkalar.TabIndex = 0;
            this.tabMarkalar.Text = "Markalar";
            this.tabMarkalar.UseVisualStyleBackColor = true;
            // 
            // marka_dgw
            // 
            this.marka_dgw.AllowUserToAddRows = false;
            this.marka_dgw.AllowUserToDeleteRows = false;
            this.marka_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.marka_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marka_dgw.ContextMenuStrip = this.guncelleSil_cms;
            this.marka_dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marka_dgw.Location = new System.Drawing.Point(3, 103);
            this.marka_dgw.Name = "marka_dgw";
            this.marka_dgw.ReadOnly = true;
            this.marka_dgw.RowHeadersWidth = 51;
            this.marka_dgw.RowTemplate.Height = 24;
            this.marka_dgw.Size = new System.Drawing.Size(786, 315);
            this.marka_dgw.TabIndex = 5;
            this.marka_dgw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_CellMouseDown);
            this.marka_dgw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tomato;
            this.panel4.Controls.Add(this.markaVazgec_btn);
            this.panel4.Controls.Add(this.markaGuncelle_btn);
            this.panel4.Controls.Add(this.markaEkle_tb);
            this.panel4.Controls.Add(this.markaEkle_btn);
            this.panel4.Controls.Add(this.markaEkle_lb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 100);
            this.panel4.TabIndex = 4;
            // 
            // markaVazgec_btn
            // 
            this.markaVazgec_btn.Location = new System.Drawing.Point(314, 43);
            this.markaVazgec_btn.Name = "markaVazgec_btn";
            this.markaVazgec_btn.Size = new System.Drawing.Size(75, 39);
            this.markaVazgec_btn.TabIndex = 5;
            this.markaVazgec_btn.Text = "Vazgeç";
            this.markaVazgec_btn.UseVisualStyleBackColor = true;
            this.markaVazgec_btn.Visible = false;
            this.markaVazgec_btn.Click += new System.EventHandler(this.markaVazgec_btn_Click);
            // 
            // markaGuncelle_btn
            // 
            this.markaGuncelle_btn.Location = new System.Drawing.Point(220, 43);
            this.markaGuncelle_btn.Name = "markaGuncelle_btn";
            this.markaGuncelle_btn.Size = new System.Drawing.Size(88, 39);
            this.markaGuncelle_btn.TabIndex = 4;
            this.markaGuncelle_btn.Text = "Güncelle";
            this.markaGuncelle_btn.UseVisualStyleBackColor = true;
            this.markaGuncelle_btn.Visible = false;
            this.markaGuncelle_btn.Click += new System.EventHandler(this.markaGuncelle_btn_Click);
            // 
            // markaEkle_tb
            // 
            this.markaEkle_tb.Location = new System.Drawing.Point(220, 15);
            this.markaEkle_tb.Name = "markaEkle_tb";
            this.markaEkle_tb.Size = new System.Drawing.Size(188, 22);
            this.markaEkle_tb.TabIndex = 2;
            // 
            // markaEkle_btn
            // 
            this.markaEkle_btn.Location = new System.Drawing.Point(279, 42);
            this.markaEkle_btn.Name = "markaEkle_btn";
            this.markaEkle_btn.Size = new System.Drawing.Size(75, 40);
            this.markaEkle_btn.TabIndex = 3;
            this.markaEkle_btn.Text = "Ekle";
            this.markaEkle_btn.UseVisualStyleBackColor = true;
            this.markaEkle_btn.Click += new System.EventHandler(this.markaEkle_btn_Click);
            // 
            // markaEkle_lb
            // 
            this.markaEkle_lb.AutoSize = true;
            this.markaEkle_lb.Location = new System.Drawing.Point(74, 33);
            this.markaEkle_lb.Name = "markaEkle_lb";
            this.markaEkle_lb.Size = new System.Drawing.Size(105, 16);
            this.markaEkle_lb.TabIndex = 1;
            this.markaEkle_lb.Text = "Yeni Marka Ekle";
            // 
            // modelTabPage
            // 
            this.modelTabPage.Controls.Add(this.model_dgw);
            this.modelTabPage.Controls.Add(this.panel1);
            this.modelTabPage.Location = new System.Drawing.Point(4, 25);
            this.modelTabPage.Name = "modelTabPage";
            this.modelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.modelTabPage.Size = new System.Drawing.Size(792, 421);
            this.modelTabPage.TabIndex = 1;
            this.modelTabPage.Text = "Modeller";
            this.modelTabPage.UseVisualStyleBackColor = true;
            // 
            // model_dgw
            // 
            this.model_dgw.AllowUserToAddRows = false;
            this.model_dgw.AllowUserToDeleteRows = false;
            this.model_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.model_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.model_dgw.ContextMenuStrip = this.guncelleSil_cms;
            this.model_dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model_dgw.Location = new System.Drawing.Point(3, 103);
            this.model_dgw.Name = "model_dgw";
            this.model_dgw.ReadOnly = true;
            this.model_dgw.RowHeadersWidth = 51;
            this.model_dgw.RowTemplate.Height = 24;
            this.model_dgw.Size = new System.Drawing.Size(786, 315);
            this.model_dgw.TabIndex = 1;
            this.model_dgw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_CellMouseDown);
            this.model_dgw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.modelVazgec_btn);
            this.panel1.Controls.Add(this.modelGuncelle_btn);
            this.panel1.Controls.Add(this.modelEkle_btn);
            this.panel1.Controls.Add(this.modelEkle_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.model_markalar_cb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 100);
            this.panel1.TabIndex = 0;
            // 
            // modelVazgec_btn
            // 
            this.modelVazgec_btn.Location = new System.Drawing.Point(341, 58);
            this.modelVazgec_btn.Name = "modelVazgec_btn";
            this.modelVazgec_btn.Size = new System.Drawing.Size(90, 36);
            this.modelVazgec_btn.TabIndex = 9;
            this.modelVazgec_btn.Text = "Vazgeç";
            this.modelVazgec_btn.UseVisualStyleBackColor = true;
            this.modelVazgec_btn.Visible = false;
            this.modelVazgec_btn.Click += new System.EventHandler(this.modelVazgec_btn_Click);
            // 
            // modelGuncelle_btn
            // 
            this.modelGuncelle_btn.Location = new System.Drawing.Point(223, 59);
            this.modelGuncelle_btn.Name = "modelGuncelle_btn";
            this.modelGuncelle_btn.Size = new System.Drawing.Size(90, 35);
            this.modelGuncelle_btn.TabIndex = 8;
            this.modelGuncelle_btn.Text = "Güncelle";
            this.modelGuncelle_btn.UseVisualStyleBackColor = true;
            this.modelGuncelle_btn.Visible = false;
            this.modelGuncelle_btn.Click += new System.EventHandler(this.modelGuncelle_btn_Click);
            // 
            // modelEkle_btn
            // 
            this.modelEkle_btn.Location = new System.Drawing.Point(269, 59);
            this.modelEkle_btn.Name = "modelEkle_btn";
            this.modelEkle_btn.Size = new System.Drawing.Size(118, 35);
            this.modelEkle_btn.TabIndex = 7;
            this.modelEkle_btn.Text = "Ekle";
            this.modelEkle_btn.UseVisualStyleBackColor = true;
            this.modelEkle_btn.Click += new System.EventHandler(this.modelEkle_btn_Click);
            // 
            // modelEkle_tb
            // 
            this.modelEkle_tb.Location = new System.Drawing.Point(407, 12);
            this.modelEkle_tb.Name = "modelEkle_tb";
            this.modelEkle_tb.Size = new System.Drawing.Size(130, 22);
            this.modelEkle_tb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Model Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka seçiniz";
            // 
            // model_markalar_cb
            // 
            this.model_markalar_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_markalar_cb.FormattingEnabled = true;
            this.model_markalar_cb.Location = new System.Drawing.Point(123, 10);
            this.model_markalar_cb.Name = "model_markalar_cb";
            this.model_markalar_cb.Size = new System.Drawing.Size(133, 24);
            this.model_markalar_cb.TabIndex = 3;
            this.model_markalar_cb.SelectedValueChanged += new System.EventHandler(this.model_markalar_cb_SelectedValueChanged);
            // 
            // altGroupTabPage
            // 
            this.altGroupTabPage.ContextMenuStrip = this.guncelleSil_cms;
            this.altGroupTabPage.Controls.Add(this.altGroup_dgw);
            this.altGroupTabPage.Controls.Add(this.panel2);
            this.altGroupTabPage.Location = new System.Drawing.Point(4, 25);
            this.altGroupTabPage.Name = "altGroupTabPage";
            this.altGroupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.altGroupTabPage.Size = new System.Drawing.Size(792, 421);
            this.altGroupTabPage.TabIndex = 2;
            this.altGroupTabPage.Text = "Alt Grup";
            this.altGroupTabPage.UseVisualStyleBackColor = true;
            // 
            // altGroup_dgw
            // 
            this.altGroup_dgw.AllowUserToAddRows = false;
            this.altGroup_dgw.AllowUserToDeleteRows = false;
            this.altGroup_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.altGroup_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.altGroup_dgw.ContextMenuStrip = this.guncelleSil_cms;
            this.altGroup_dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altGroup_dgw.Location = new System.Drawing.Point(3, 129);
            this.altGroup_dgw.Name = "altGroup_dgw";
            this.altGroup_dgw.ReadOnly = true;
            this.altGroup_dgw.RowHeadersWidth = 51;
            this.altGroup_dgw.RowTemplate.Height = 24;
            this.altGroup_dgw.Size = new System.Drawing.Size(786, 289);
            this.altGroup_dgw.TabIndex = 1;
            this.altGroup_dgw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_CellMouseDown);
            this.altGroup_dgw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.ContextMenuStrip = this.guncelleSil_cms;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.maxYil_tb);
            this.panel2.Controls.Add(this.minYil_tb);
            this.panel2.Controls.Add(this.yukseklik_tb);
            this.panel2.Controls.Add(this.boy_tb);
            this.panel2.Controls.Add(this.en_tb);
            this.panel2.Controls.Add(this.altGroupVazgec_btn);
            this.panel2.Controls.Add(this.altGroupGuncelle_btn);
            this.panel2.Controls.Add(this.altGroupEkle_btn);
            this.panel2.Controls.Add(this.altGroupEkle_tb);
            this.panel2.Controls.Add(this.altGroup_model_cb);
            this.panel2.Controls.Add(this.altGroup_marka_cb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 126);
            this.panel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Max Yıl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Min Yıl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Yükseklik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Boy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "En";
            // 
            // maxYil_tb
            // 
            this.maxYil_tb.Location = new System.Drawing.Point(438, 85);
            this.maxYil_tb.Name = "maxYil_tb";
            this.maxYil_tb.Size = new System.Drawing.Size(70, 22);
            this.maxYil_tb.TabIndex = 9;
            this.maxYil_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // minYil_tb
            // 
            this.minYil_tb.Location = new System.Drawing.Point(333, 85);
            this.minYil_tb.Name = "minYil_tb";
            this.minYil_tb.Size = new System.Drawing.Size(63, 22);
            this.minYil_tb.TabIndex = 8;
            this.minYil_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // yukseklik_tb
            // 
            this.yukseklik_tb.Location = new System.Drawing.Point(218, 85);
            this.yukseklik_tb.Name = "yukseklik_tb";
            this.yukseklik_tb.Size = new System.Drawing.Size(79, 22);
            this.yukseklik_tb.TabIndex = 7;
            this.yukseklik_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // boy_tb
            // 
            this.boy_tb.Location = new System.Drawing.Point(118, 85);
            this.boy_tb.Name = "boy_tb";
            this.boy_tb.Size = new System.Drawing.Size(69, 22);
            this.boy_tb.TabIndex = 6;
            this.boy_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // en_tb
            // 
            this.en_tb.Location = new System.Drawing.Point(10, 85);
            this.en_tb.Name = "en_tb";
            this.en_tb.Size = new System.Drawing.Size(66, 22);
            this.en_tb.TabIndex = 5;
            this.en_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // altGroupVazgec_btn
            // 
            this.altGroupVazgec_btn.Location = new System.Drawing.Point(654, 56);
            this.altGroupVazgec_btn.Name = "altGroupVazgec_btn";
            this.altGroupVazgec_btn.Size = new System.Drawing.Size(117, 31);
            this.altGroupVazgec_btn.TabIndex = 4;
            this.altGroupVazgec_btn.Text = "Vazgeç";
            this.altGroupVazgec_btn.UseVisualStyleBackColor = true;
            this.altGroupVazgec_btn.Visible = false;
            this.altGroupVazgec_btn.Click += new System.EventHandler(this.altGroupVazgec_btn_Click);
            // 
            // altGroupGuncelle_btn
            // 
            this.altGroupGuncelle_btn.Location = new System.Drawing.Point(531, 56);
            this.altGroupGuncelle_btn.Name = "altGroupGuncelle_btn";
            this.altGroupGuncelle_btn.Size = new System.Drawing.Size(117, 31);
            this.altGroupGuncelle_btn.TabIndex = 4;
            this.altGroupGuncelle_btn.Text = "Güncelle";
            this.altGroupGuncelle_btn.UseVisualStyleBackColor = true;
            this.altGroupGuncelle_btn.Visible = false;
            this.altGroupGuncelle_btn.Click += new System.EventHandler(this.altGroupGuncelle_btn_Click);
            // 
            // altGroupEkle_btn
            // 
            this.altGroupEkle_btn.Location = new System.Drawing.Point(602, 51);
            this.altGroupEkle_btn.Name = "altGroupEkle_btn";
            this.altGroupEkle_btn.Size = new System.Drawing.Size(117, 41);
            this.altGroupEkle_btn.TabIndex = 4;
            this.altGroupEkle_btn.Text = "Ekle";
            this.altGroupEkle_btn.UseVisualStyleBackColor = true;
            this.altGroupEkle_btn.Click += new System.EventHandler(this.altGroupEkle_btn_Click);
            // 
            // altGroupEkle_tb
            // 
            this.altGroupEkle_tb.Location = new System.Drawing.Point(389, 32);
            this.altGroupEkle_tb.Name = "altGroupEkle_tb";
            this.altGroupEkle_tb.Size = new System.Drawing.Size(130, 22);
            this.altGroupEkle_tb.TabIndex = 3;
            // 
            // altGroup_model_cb
            // 
            this.altGroup_model_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.altGroup_model_cb.FormattingEnabled = true;
            this.altGroup_model_cb.Location = new System.Drawing.Point(212, 32);
            this.altGroup_model_cb.Name = "altGroup_model_cb";
            this.altGroup_model_cb.Size = new System.Drawing.Size(121, 24);
            this.altGroup_model_cb.TabIndex = 2;
            this.altGroup_model_cb.SelectedValueChanged += new System.EventHandler(this.altGroup_model_cb_SelectedValueChanged);
            // 
            // altGroup_marka_cb
            // 
            this.altGroup_marka_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.altGroup_marka_cb.FormattingEnabled = true;
            this.altGroup_marka_cb.Location = new System.Drawing.Point(21, 32);
            this.altGroup_marka_cb.Name = "altGroup_marka_cb";
            this.altGroup_marka_cb.Size = new System.Drawing.Size(121, 24);
            this.altGroup_marka_cb.TabIndex = 1;
            this.altGroup_marka_cb.SelectedValueChanged += new System.EventHandler(this.altGroup_marka_cb_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alt Grup Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Model Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marka Seçiniz";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.aku_dgw);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Akü";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aku_dgw
            // 
            this.aku_dgw.AllowUserToAddRows = false;
            this.aku_dgw.AllowUserToDeleteRows = false;
            this.aku_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aku_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aku_dgw.ContextMenuStrip = this.guncelleSil_cms;
            this.aku_dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aku_dgw.Location = new System.Drawing.Point(3, 97);
            this.aku_dgw.Name = "aku_dgw";
            this.aku_dgw.ReadOnly = true;
            this.aku_dgw.RowHeadersWidth = 51;
            this.aku_dgw.RowTemplate.Height = 24;
            this.aku_dgw.Size = new System.Drawing.Size(786, 321);
            this.aku_dgw.TabIndex = 1;
            this.aku_dgw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_CellMouseDown);
            this.aku_dgw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Controls.Add(this.akuVazgec_btn);
            this.panel3.Controls.Add(this.akuGuncelle_btn);
            this.panel3.Controls.Add(this.akuEkle_btn);
            this.panel3.Controls.Add(this.akuYukseklik_tb);
            this.panel3.Controls.Add(this.akuBoy_tb);
            this.panel3.Controls.Add(this.akuEn_tb);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.aku_tb);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 94);
            this.panel3.TabIndex = 0;
            // 
            // akuVazgec_btn
            // 
            this.akuVazgec_btn.Location = new System.Drawing.Point(693, 49);
            this.akuVazgec_btn.Name = "akuVazgec_btn";
            this.akuVazgec_btn.Size = new System.Drawing.Size(75, 33);
            this.akuVazgec_btn.TabIndex = 7;
            this.akuVazgec_btn.Text = "Vazgeç";
            this.akuVazgec_btn.UseVisualStyleBackColor = true;
            this.akuVazgec_btn.Visible = false;
            this.akuVazgec_btn.Click += new System.EventHandler(this.akuVazgec_btn_Click);
            // 
            // akuGuncelle_btn
            // 
            this.akuGuncelle_btn.Location = new System.Drawing.Point(600, 49);
            this.akuGuncelle_btn.Name = "akuGuncelle_btn";
            this.akuGuncelle_btn.Size = new System.Drawing.Size(87, 33);
            this.akuGuncelle_btn.TabIndex = 6;
            this.akuGuncelle_btn.Text = "Güncelle";
            this.akuGuncelle_btn.UseVisualStyleBackColor = true;
            this.akuGuncelle_btn.Visible = false;
            this.akuGuncelle_btn.Click += new System.EventHandler(this.akuGuncelle_btn_Click);
            // 
            // akuEkle_btn
            // 
            this.akuEkle_btn.Location = new System.Drawing.Point(693, 49);
            this.akuEkle_btn.Name = "akuEkle_btn";
            this.akuEkle_btn.Size = new System.Drawing.Size(75, 33);
            this.akuEkle_btn.TabIndex = 5;
            this.akuEkle_btn.Text = "Ekle";
            this.akuEkle_btn.UseVisualStyleBackColor = true;
            this.akuEkle_btn.Click += new System.EventHandler(this.akuEkle_btn_Click);
            // 
            // akuYukseklik_tb
            // 
            this.akuYukseklik_tb.Location = new System.Drawing.Point(668, 7);
            this.akuYukseklik_tb.Name = "akuYukseklik_tb";
            this.akuYukseklik_tb.Size = new System.Drawing.Size(100, 22);
            this.akuYukseklik_tb.TabIndex = 4;
            // 
            // akuBoy_tb
            // 
            this.akuBoy_tb.Location = new System.Drawing.Point(458, 7);
            this.akuBoy_tb.Name = "akuBoy_tb";
            this.akuBoy_tb.Size = new System.Drawing.Size(100, 22);
            this.akuBoy_tb.TabIndex = 4;
            // 
            // akuEn_tb
            // 
            this.akuEn_tb.Location = new System.Drawing.Point(277, 7);
            this.akuEn_tb.Name = "akuEn_tb";
            this.akuEn_tb.Size = new System.Drawing.Size(100, 22);
            this.akuEn_tb.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(597, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Yükseklik";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(421, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Boy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "En";
            // 
            // aku_tb
            // 
            this.aku_tb.Location = new System.Drawing.Point(71, 7);
            this.aku_tb.Name = "aku_tb";
            this.aku_tb.Size = new System.Drawing.Size(149, 22);
            this.aku_tb.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Akü Ekle";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şaban Tunç-192523215";
            this.tabControl1.ResumeLayout(false);
            this.guncelleSil_cms.ResumeLayout(false);
            this.tabMarkalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marka_dgw)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.modelTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.model_dgw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.altGroupTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.altGroup_dgw)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aku_dgw)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMarkalar;
        private System.Windows.Forms.TabPage modelTabPage;
        private System.Windows.Forms.Label markaEkle_lb;
        private System.Windows.Forms.Button markaEkle_btn;
        private System.Windows.Forms.TextBox markaEkle_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox modelEkle_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox model_markalar_cb;
        private System.Windows.Forms.Button modelEkle_btn;
        private System.Windows.Forms.TabPage altGroupTabPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button altGroupEkle_btn;
        private System.Windows.Forms.TextBox altGroupEkle_tb;
        private System.Windows.Forms.ComboBox altGroup_model_cb;
        private System.Windows.Forms.ComboBox altGroup_marka_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView altGroup_dgw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxYil_tb;
        private System.Windows.Forms.TextBox minYil_tb;
        private System.Windows.Forms.TextBox yukseklik_tb;
        private System.Windows.Forms.TextBox boy_tb;
        private System.Windows.Forms.TextBox en_tb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button akuEkle_btn;
        private System.Windows.Forms.TextBox akuYukseklik_tb;
        private System.Windows.Forms.TextBox akuBoy_tb;
        private System.Windows.Forms.TextBox akuEn_tb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox aku_tb;
        private System.Windows.Forms.DataGridView aku_dgw;
        private System.Windows.Forms.ContextMenuStrip guncelleSil_cms;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button akuVazgec_btn;
        private System.Windows.Forms.Button akuGuncelle_btn;
        private System.Windows.Forms.Button altGroupVazgec_btn;
        private System.Windows.Forms.Button altGroupGuncelle_btn;
        private System.Windows.Forms.DataGridView model_dgw;
        private System.Windows.Forms.Button modelVazgec_btn;
        private System.Windows.Forms.Button modelGuncelle_btn;
        private System.Windows.Forms.DataGridView marka_dgw;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button markaVazgec_btn;
        private System.Windows.Forms.Button markaGuncelle_btn;
    }
}