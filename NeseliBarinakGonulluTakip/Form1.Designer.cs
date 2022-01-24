namespace NeseliBarinakGonulluTakip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGirisKaydol = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAdSyd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKaydolTelNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKaydolSifre2 = new System.Windows.Forms.TextBox();
            this.txtKaydolSifre1 = new System.Windows.Forms.TextBox();
            this.txtKaydolAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBDuzenleAd = new System.Windows.Forms.TextBox();
            this.btnBDüzenleIleri = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBDuzenleTelNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBDüzenleTemizle = new System.Windows.Forms.Button();
            this.btnBDüzenleSil = new System.Windows.Forms.Button();
            this.btnBDüzenleListele = new System.Windows.Forms.Button();
            this.btnBDüzenleGüncelle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBDuzenleSifre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btbGonulluGoreviIleri = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gonullulerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barinakTakipDataSet1 = new NeseliBarinakGonulluTakip.BarinakTakipDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnYeniGorevILERI = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbYeniGorevCins = new System.Windows.Forms.ComboBox();
            this.cinslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barinakTakipDataSet2 = new NeseliBarinakGonulluTakip.BarinakTakipDataSet2();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbYeniGorevAdSyd = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cmbYeniGorevGun = new System.Windows.Forms.ComboBox();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHavalandirma = new System.Windows.Forms.RadioButton();
            this.rdHayvanTemizligi = new System.Windows.Forms.RadioButton();
            this.rdSaglik = new System.Windows.Forms.RadioButton();
            this.rdAlanTemizligi = new System.Windows.Forms.RadioButton();
            this.rdAsi = new System.Windows.Forms.RadioButton();
            this.rdOyun = new System.Windows.Forms.RadioButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbDGATur = new System.Windows.Forms.ComboBox();
            this.turlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barinakTakipDataSet3 = new NeseliBarinakGonulluTakip.BarinakTakipDataSet3();
            this.cmbDGACins = new System.Windows.Forms.ComboBox();
            this.cmbDGAgorevAdi = new System.Windows.Forms.ComboBox();
            this.txtDGAAdSyd = new System.Windows.Forms.TextBox();
            this.chckTur = new System.Windows.Forms.CheckBox();
            this.chckCins = new System.Windows.Forms.CheckBox();
            this.chckGorevAdi = new System.Windows.Forms.CheckBox();
            this.chckAdSyd = new System.Windows.Forms.CheckBox();
            this.barinakTakipDataSet = new NeseliBarinakGonulluTakip.BarinakTakipDataSet();
            this.barinakTakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevlerTableAdapter = new NeseliBarinakGonulluTakip.BarinakTakipDataSetTableAdapters.GorevlerTableAdapter();
            this.gonullulerTableAdapter = new NeseliBarinakGonulluTakip.BarinakTakipDataSet1TableAdapters.GonullulerTableAdapter();
            this.cinslerTableAdapter = new NeseliBarinakGonulluTakip.BarinakTakipDataSet2TableAdapters.CinslerTableAdapter();
            this.turlerTableAdapter = new NeseliBarinakGonulluTakip.BarinakTakipDataSet3TableAdapters.TurlerTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gonullulerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.btnGirisKaydol);
            this.tabPage1.Controls.Add(this.btnGirisYap);
            this.tabPage1.Controls.Add(this.txtSifre);
            this.tabPage1.Controls.Add(this.txtAdSyd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gönüllü Giriş";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGirisKaydol
            // 
            this.btnGirisKaydol.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGirisKaydol.Location = new System.Drawing.Point(213, 415);
            this.btnGirisKaydol.Name = "btnGirisKaydol";
            this.btnGirisKaydol.Size = new System.Drawing.Size(231, 58);
            this.btnGirisKaydol.TabIndex = 17;
            this.btnGirisKaydol.Text = "Kaydol";
            this.btnGirisKaydol.UseVisualStyleBackColor = false;
            this.btnGirisKaydol.Click += new System.EventHandler(this.btnGirisKaydol_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGirisYap.Location = new System.Drawing.Point(213, 328);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(231, 58);
            this.btnGirisYap.TabIndex = 16;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(213, 288);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(231, 22);
            this.txtSifre.TabIndex = 15;
            // 
            // txtAdSyd
            // 
            this.txtAdSyd.Location = new System.Drawing.Point(213, 200);
            this.txtAdSyd.Name = "txtAdSyd";
            this.txtAdSyd.Size = new System.Drawing.Size(231, 22);
            this.txtAdSyd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gönüllü ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(206, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Neşeli Barınak";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.txtKaydolTelNo);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btnKaydol);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtKaydolSifre2);
            this.tabPage2.Controls.Add(this.txtKaydolSifre1);
            this.tabPage2.Controls.Add(this.txtKaydolAd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gönüllü Kaydol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKaydolTelNo
            // 
            this.txtKaydolTelNo.Location = new System.Drawing.Point(280, 296);
            this.txtKaydolTelNo.Name = "txtKaydolTelNo";
            this.txtKaydolTelNo.Size = new System.Drawing.Size(156, 22);
            this.txtKaydolTelNo.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(151, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Telefon No";
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKaydol.Location = new System.Drawing.Point(154, 362);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(282, 76);
            this.btnKaydol.TabIndex = 9;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = false;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 8;
            // 
            // txtKaydolSifre2
            // 
            this.txtKaydolSifre2.Location = new System.Drawing.Point(280, 246);
            this.txtKaydolSifre2.Name = "txtKaydolSifre2";
            this.txtKaydolSifre2.Size = new System.Drawing.Size(156, 22);
            this.txtKaydolSifre2.TabIndex = 6;
            // 
            // txtKaydolSifre1
            // 
            this.txtKaydolSifre1.Location = new System.Drawing.Point(280, 187);
            this.txtKaydolSifre1.Name = "txtKaydolSifre1";
            this.txtKaydolSifre1.Size = new System.Drawing.Size(156, 22);
            this.txtKaydolSifre1.TabIndex = 5;
            // 
            // txtKaydolAd
            // 
            this.txtKaydolAd.Location = new System.Drawing.Point(280, 124);
            this.txtKaydolAd.Name = "txtKaydolAd";
            this.txtKaydolAd.Size = new System.Drawing.Size(156, 22);
            this.txtKaydolAd.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Şifre Tekrar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gönüllü ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.txtBDuzenleAd);
            this.tabPage3.Controls.Add(this.btnBDüzenleIleri);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtBDuzenleTelNo);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btnBDüzenleTemizle);
            this.tabPage3.Controls.Add(this.btnBDüzenleSil);
            this.tabPage3.Controls.Add(this.btnBDüzenleListele);
            this.tabPage3.Controls.Add(this.btnBDüzenleGüncelle);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtBDuzenleSifre);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(674, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bilgileri Düzenle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBDuzenleAd
            // 
            this.txtBDuzenleAd.Location = new System.Drawing.Point(177, 95);
            this.txtBDuzenleAd.Name = "txtBDuzenleAd";
            this.txtBDuzenleAd.Size = new System.Drawing.Size(153, 22);
            this.txtBDuzenleAd.TabIndex = 15;
            // 
            // btnBDüzenleIleri
            // 
            this.btnBDüzenleIleri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBDüzenleIleri.Location = new System.Drawing.Point(494, 488);
            this.btnBDüzenleIleri.Name = "btnBDüzenleIleri";
            this.btnBDüzenleIleri.Size = new System.Drawing.Size(133, 38);
            this.btnBDüzenleIleri.TabIndex = 14;
            this.btnBDüzenleIleri.Text = "İLERİ";
            this.btnBDüzenleIleri.UseVisualStyleBackColor = false;
            this.btnBDüzenleIleri.Click += new System.EventHandler(this.btnBDüzenleIleri_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Telefon No";
            // 
            // txtBDuzenleTelNo
            // 
            this.txtBDuzenleTelNo.Location = new System.Drawing.Point(177, 188);
            this.txtBDuzenleTelNo.Name = "txtBDuzenleTelNo";
            this.txtBDuzenleTelNo.Size = new System.Drawing.Size(153, 22);
            this.txtBDuzenleTelNo.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(39, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 165);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnBDüzenleTemizle
            // 
            this.btnBDüzenleTemizle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBDüzenleTemizle.Location = new System.Drawing.Point(394, 95);
            this.btnBDüzenleTemizle.Name = "btnBDüzenleTemizle";
            this.btnBDüzenleTemizle.Size = new System.Drawing.Size(233, 56);
            this.btnBDüzenleTemizle.TabIndex = 9;
            this.btnBDüzenleTemizle.Text = "Temizle";
            this.btnBDüzenleTemizle.UseVisualStyleBackColor = false;
            this.btnBDüzenleTemizle.Click += new System.EventHandler(this.btnBDüzenleTemizle_Click);
            // 
            // btnBDüzenleSil
            // 
            this.btnBDüzenleSil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBDüzenleSil.Location = new System.Drawing.Point(520, 157);
            this.btnBDüzenleSil.Name = "btnBDüzenleSil";
            this.btnBDüzenleSil.Size = new System.Drawing.Size(107, 53);
            this.btnBDüzenleSil.TabIndex = 8;
            this.btnBDüzenleSil.Text = "Kaydımı Sil";
            this.btnBDüzenleSil.UseVisualStyleBackColor = false;
            this.btnBDüzenleSil.Click += new System.EventHandler(this.btnBDüzenleSil_Click);
            // 
            // btnBDüzenleListele
            // 
            this.btnBDüzenleListele.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBDüzenleListele.Location = new System.Drawing.Point(39, 251);
            this.btnBDüzenleListele.Name = "btnBDüzenleListele";
            this.btnBDüzenleListele.Size = new System.Drawing.Size(588, 59);
            this.btnBDüzenleListele.TabIndex = 7;
            this.btnBDüzenleListele.Text = "Listele";
            this.btnBDüzenleListele.UseVisualStyleBackColor = false;
            this.btnBDüzenleListele.Click += new System.EventHandler(this.btnBDuzenleListele_Click);
            // 
            // btnBDüzenleGüncelle
            // 
            this.btnBDüzenleGüncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBDüzenleGüncelle.Location = new System.Drawing.Point(394, 157);
            this.btnBDüzenleGüncelle.Name = "btnBDüzenleGüncelle";
            this.btnBDüzenleGüncelle.Size = new System.Drawing.Size(107, 53);
            this.btnBDüzenleGüncelle.TabIndex = 6;
            this.btnBDüzenleGüncelle.Text = "Güncelle";
            this.btnBDüzenleGüncelle.UseVisualStyleBackColor = false;
            this.btnBDüzenleGüncelle.Click += new System.EventHandler(this.btnBDüzenleGüncelle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 5;
            // 
            // txtBDuzenleSifre
            // 
            this.txtBDuzenleSifre.Location = new System.Drawing.Point(177, 144);
            this.txtBDuzenleSifre.Name = "txtBDuzenleSifre";
            this.txtBDuzenleSifre.Size = new System.Drawing.Size(153, 22);
            this.txtBDuzenleSifre.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sifre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ad Soyad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Gönüllü ID";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.btbGonulluGoreviIleri);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(674, 561);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gönüllü Görevi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btbGonulluGoreviIleri
            // 
            this.btbGonulluGoreviIleri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btbGonulluGoreviIleri.Location = new System.Drawing.Point(469, 486);
            this.btbGonulluGoreviIleri.Name = "btbGonulluGoreviIleri";
            this.btbGonulluGoreviIleri.Size = new System.Drawing.Size(155, 39);
            this.btbGonulluGoreviIleri.TabIndex = 4;
            this.btbGonulluGoreviIleri.Text = "İLERİ";
            this.btbGonulluGoreviIleri.UseVisualStyleBackColor = false;
            this.btbGonulluGoreviIleri.Click += new System.EventHandler(this.btbGonulluGoreviIleri_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gonullulerBindingSource;
            this.comboBox1.DisplayMember = "AdiSoyadi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "GonulluID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gonullulerBindingSource
            // 
            this.gonullulerBindingSource.DataMember = "Gonulluler";
            this.gonullulerBindingSource.DataSource = this.barinakTakipDataSet1;
            // 
            // barinakTakipDataSet1
            // 
            this.barinakTakipDataSet1.DataSetName = "BarinakTakipDataSet1";
            this.barinakTakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(584, 285);
            this.dataGridView2.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Adı Soyadı";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.Controls.Add(this.btnYeniGorevILERI);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.comboBox8);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.cmbYeniGorevCins);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.cmbYeniGorevAdSyd);
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Controls.Add(this.cmbYeniGorevGun);
            this.tabPage5.Controls.Add(this.btnGorevEkle);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(674, 561);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Yeni Görev Ekle";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnYeniGorevILERI
            // 
            this.btnYeniGorevILERI.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnYeniGorevILERI.Location = new System.Drawing.Point(494, 510);
            this.btnYeniGorevILERI.Name = "btnYeniGorevILERI";
            this.btnYeniGorevILERI.Size = new System.Drawing.Size(144, 32);
            this.btnYeniGorevILERI.TabIndex = 13;
            this.btnYeniGorevILERI.Text = "İLERİ";
            this.btnYeniGorevILERI.UseVisualStyleBackColor = false;
            this.btnYeniGorevILERI.Click += new System.EventHandler(this.btnYeniGorevILERI_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(25, 212);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(613, 120);
            this.dataGridView5.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(146, 355);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 17);
            this.label21.TabIndex = 11;
            this.label21.Text = "Tablolar";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Gonulluler",
            "Gorevler",
            "GorevGunleri",
            "Cinsler",
            "Turler"});
            this.comboBox8.Location = new System.Drawing.Point(236, 348);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(238, 24);
            this.comboBox8.TabIndex = 10;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(481, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 17);
            this.label20.TabIndex = 9;
            this.label20.Text = "Cins Seçiniz";
            // 
            // cmbYeniGorevCins
            // 
            this.cmbYeniGorevCins.DataSource = this.cinslerBindingSource;
            this.cmbYeniGorevCins.DisplayMember = "CinsAdi";
            this.cmbYeniGorevCins.FormattingEnabled = true;
            this.cmbYeniGorevCins.Location = new System.Drawing.Point(413, 103);
            this.cmbYeniGorevCins.Name = "cmbYeniGorevCins";
            this.cmbYeniGorevCins.Size = new System.Drawing.Size(225, 24);
            this.cmbYeniGorevCins.TabIndex = 8;
            this.cmbYeniGorevCins.ValueMember = "CinsID";
            // 
            // cinslerBindingSource
            // 
            this.cinslerBindingSource.DataMember = "Cinsler";
            this.cinslerBindingSource.DataSource = this.barinakTakipDataSet2;
            // 
            // barinakTakipDataSet2
            // 
            this.barinakTakipDataSet2.DataSetName = "BarinakTakipDataSet2";
            this.barinakTakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(481, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "Gün Seçiniz";
            // 
            // cmbYeniGorevAdSyd
            // 
            this.cmbYeniGorevAdSyd.DataSource = this.gonullulerBindingSource;
            this.cmbYeniGorevAdSyd.DisplayMember = "AdiSoyadi";
            this.cmbYeniGorevAdSyd.FormattingEnabled = true;
            this.cmbYeniGorevAdSyd.Location = new System.Drawing.Point(149, 21);
            this.cmbYeniGorevAdSyd.Name = "cmbYeniGorevAdSyd";
            this.cmbYeniGorevAdSyd.Size = new System.Drawing.Size(187, 24);
            this.cmbYeniGorevAdSyd.TabIndex = 6;
            this.cmbYeniGorevAdSyd.ValueMember = "GonulluID";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(25, 378);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(613, 126);
            this.dataGridView4.TabIndex = 5;
            // 
            // cmbYeniGorevGun
            // 
            this.cmbYeniGorevGun.FormattingEnabled = true;
            this.cmbYeniGorevGun.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşeme",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cmbYeniGorevGun.Location = new System.Drawing.Point(413, 41);
            this.cmbYeniGorevGun.Name = "cmbYeniGorevGun";
            this.cmbYeniGorevGun.Size = new System.Drawing.Size(225, 24);
            this.cmbYeniGorevGun.TabIndex = 4;
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGorevEkle.Location = new System.Drawing.Point(413, 150);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(225, 56);
            this.btnGorevEkle.TabIndex = 3;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = false;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Adı Soyadı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHavalandirma);
            this.groupBox1.Controls.Add(this.rdHayvanTemizligi);
            this.groupBox1.Controls.Add(this.rdSaglik);
            this.groupBox1.Controls.Add(this.rdAlanTemizligi);
            this.groupBox1.Controls.Add(this.rdAsi);
            this.groupBox1.Controls.Add(this.rdOyun);
            this.groupBox1.Location = new System.Drawing.Point(25, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görev Seçiniz";
            // 
            // rdHavalandirma
            // 
            this.rdHavalandirma.AutoSize = true;
            this.rdHavalandirma.Location = new System.Drawing.Point(195, 113);
            this.rdHavalandirma.Name = "rdHavalandirma";
            this.rdHavalandirma.Size = new System.Drawing.Size(116, 21);
            this.rdHavalandirma.TabIndex = 5;
            this.rdHavalandirma.TabStop = true;
            this.rdHavalandirma.Text = "Havalandırma";
            this.rdHavalandirma.UseVisualStyleBackColor = true;
            // 
            // rdHayvanTemizligi
            // 
            this.rdHayvanTemizligi.AutoSize = true;
            this.rdHayvanTemizligi.Location = new System.Drawing.Point(28, 113);
            this.rdHayvanTemizligi.Name = "rdHayvanTemizligi";
            this.rdHayvanTemizligi.Size = new System.Drawing.Size(136, 21);
            this.rdHayvanTemizligi.TabIndex = 4;
            this.rdHayvanTemizligi.TabStop = true;
            this.rdHayvanTemizligi.Text = "Hayvan Temizliği";
            this.rdHayvanTemizligi.UseVisualStyleBackColor = true;
            // 
            // rdSaglik
            // 
            this.rdSaglik.AutoSize = true;
            this.rdSaglik.Location = new System.Drawing.Point(195, 68);
            this.rdSaglik.Name = "rdSaglik";
            this.rdSaglik.Size = new System.Drawing.Size(67, 21);
            this.rdSaglik.TabIndex = 3;
            this.rdSaglik.TabStop = true;
            this.rdSaglik.Text = "Sağlık";
            this.rdSaglik.UseVisualStyleBackColor = true;
            // 
            // rdAlanTemizligi
            // 
            this.rdAlanTemizligi.AutoSize = true;
            this.rdAlanTemizligi.Location = new System.Drawing.Point(28, 68);
            this.rdAlanTemizligi.Name = "rdAlanTemizligi";
            this.rdAlanTemizligi.Size = new System.Drawing.Size(116, 21);
            this.rdAlanTemizligi.TabIndex = 2;
            this.rdAlanTemizligi.TabStop = true;
            this.rdAlanTemizligi.Text = "Alan Temizliği";
            this.rdAlanTemizligi.UseVisualStyleBackColor = true;
            // 
            // rdAsi
            // 
            this.rdAsi.AutoSize = true;
            this.rdAsi.Location = new System.Drawing.Point(195, 28);
            this.rdAsi.Name = "rdAsi";
            this.rdAsi.Size = new System.Drawing.Size(48, 21);
            this.rdAsi.TabIndex = 1;
            this.rdAsi.TabStop = true;
            this.rdAsi.Text = "Aşı";
            this.rdAsi.UseVisualStyleBackColor = true;
            // 
            // rdOyun
            // 
            this.rdOyun.AutoSize = true;
            this.rdOyun.Location = new System.Drawing.Point(28, 26);
            this.rdOyun.Name = "rdOyun";
            this.rdOyun.Size = new System.Drawing.Size(63, 21);
            this.rdOyun.TabIndex = 0;
            this.rdOyun.TabStop = true;
            this.rdOyun.Text = "Oyun";
            this.rdOyun.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.Controls.Add(this.btnCikis);
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Controls.Add(this.btnAra);
            this.tabPage6.Controls.Add(this.cmbDGATur);
            this.tabPage6.Controls.Add(this.cmbDGACins);
            this.tabPage6.Controls.Add(this.cmbDGAgorevAdi);
            this.tabPage6.Controls.Add(this.txtDGAAdSyd);
            this.tabPage6.Controls.Add(this.chckTur);
            this.tabPage6.Controls.Add(this.chckCins);
            this.tabPage6.Controls.Add(this.chckGorevAdi);
            this.tabPage6.Controls.Add(this.chckAdSyd);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(674, 561);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Detaylı Görev Arama";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCikis.Location = new System.Drawing.Point(494, 503);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(153, 46);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(33, 285);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(614, 212);
            this.dataGridView3.TabIndex = 9;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAra.Location = new System.Drawing.Point(438, 175);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(209, 88);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbDGATur
            // 
            this.cmbDGATur.DataSource = this.turlerBindingSource;
            this.cmbDGATur.DisplayMember = "TürAdi";
            this.cmbDGATur.Enabled = false;
            this.cmbDGATur.FormattingEnabled = true;
            this.cmbDGATur.Location = new System.Drawing.Point(225, 239);
            this.cmbDGATur.Name = "cmbDGATur";
            this.cmbDGATur.Size = new System.Drawing.Size(168, 24);
            this.cmbDGATur.TabIndex = 7;
            this.cmbDGATur.ValueMember = "TürID";
            // 
            // turlerBindingSource
            // 
            this.turlerBindingSource.DataMember = "Turler";
            this.turlerBindingSource.DataSource = this.barinakTakipDataSet3;
            // 
            // barinakTakipDataSet3
            // 
            this.barinakTakipDataSet3.DataSetName = "BarinakTakipDataSet3";
            this.barinakTakipDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDGACins
            // 
            this.cmbDGACins.DataSource = this.cinslerBindingSource;
            this.cmbDGACins.DisplayMember = "CinsAdi";
            this.cmbDGACins.Enabled = false;
            this.cmbDGACins.FormattingEnabled = true;
            this.cmbDGACins.Location = new System.Drawing.Point(225, 186);
            this.cmbDGACins.Name = "cmbDGACins";
            this.cmbDGACins.Size = new System.Drawing.Size(168, 24);
            this.cmbDGACins.TabIndex = 6;
            this.cmbDGACins.ValueMember = "CinsID";
            // 
            // cmbDGAgorevAdi
            // 
            this.cmbDGAgorevAdi.Enabled = false;
            this.cmbDGAgorevAdi.FormattingEnabled = true;
            this.cmbDGAgorevAdi.Items.AddRange(new object[] {
            "Oyun",
            "Sağlık",
            "Hayvan Temizliği",
            "Alan Temizliği",
            "Aşı",
            "Havalandırma",
            "Sahiplendirme"});
            this.cmbDGAgorevAdi.Location = new System.Drawing.Point(225, 128);
            this.cmbDGAgorevAdi.Name = "cmbDGAgorevAdi";
            this.cmbDGAgorevAdi.Size = new System.Drawing.Size(168, 24);
            this.cmbDGAgorevAdi.TabIndex = 5;
            // 
            // txtDGAAdSyd
            // 
            this.txtDGAAdSyd.Enabled = false;
            this.txtDGAAdSyd.Location = new System.Drawing.Point(225, 70);
            this.txtDGAAdSyd.Name = "txtDGAAdSyd";
            this.txtDGAAdSyd.Size = new System.Drawing.Size(168, 22);
            this.txtDGAAdSyd.TabIndex = 4;
            // 
            // chckTur
            // 
            this.chckTur.AutoSize = true;
            this.chckTur.Location = new System.Drawing.Point(62, 242);
            this.chckTur.Name = "chckTur";
            this.chckTur.Size = new System.Drawing.Size(52, 21);
            this.chckTur.TabIndex = 3;
            this.chckTur.Text = "Tür";
            this.chckTur.UseVisualStyleBackColor = true;
            this.chckTur.CheckedChanged += new System.EventHandler(this.chckTur_CheckedChanged);
            // 
            // chckCins
            // 
            this.chckCins.AutoSize = true;
            this.chckCins.Location = new System.Drawing.Point(62, 188);
            this.chckCins.Name = "chckCins";
            this.chckCins.Size = new System.Drawing.Size(57, 21);
            this.chckCins.TabIndex = 2;
            this.chckCins.Text = "Cins";
            this.chckCins.UseVisualStyleBackColor = true;
            this.chckCins.CheckedChanged += new System.EventHandler(this.chckCins_CheckedChanged);
            // 
            // chckGorevAdi
            // 
            this.chckGorevAdi.AutoSize = true;
            this.chckGorevAdi.Location = new System.Drawing.Point(62, 128);
            this.chckGorevAdi.Name = "chckGorevAdi";
            this.chckGorevAdi.Size = new System.Drawing.Size(93, 21);
            this.chckGorevAdi.TabIndex = 1;
            this.chckGorevAdi.Text = "Görev Adı";
            this.chckGorevAdi.UseVisualStyleBackColor = true;
            this.chckGorevAdi.CheckedChanged += new System.EventHandler(this.chckGorevAdi_CheckedChanged);
            // 
            // chckAdSyd
            // 
            this.chckAdSyd.AutoSize = true;
            this.chckAdSyd.Location = new System.Drawing.Point(62, 72);
            this.chckAdSyd.Name = "chckAdSyd";
            this.chckAdSyd.Size = new System.Drawing.Size(150, 21);
            this.chckAdSyd.TabIndex = 0;
            this.chckAdSyd.Text = "Gönüllü Adı Soyadı";
            this.chckAdSyd.UseVisualStyleBackColor = true;
            this.chckAdSyd.CheckedChanged += new System.EventHandler(this.chckAdSyd_CheckedChanged);
            // 
            // barinakTakipDataSet
            // 
            this.barinakTakipDataSet.DataSetName = "BarinakTakipDataSet";
            this.barinakTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barinakTakipDataSetBindingSource
            // 
            this.barinakTakipDataSetBindingSource.DataSource = this.barinakTakipDataSet;
            this.barinakTakipDataSetBindingSource.Position = 0;
            // 
            // gorevlerBindingSource
            // 
            this.gorevlerBindingSource.DataMember = "Gorevler";
            this.gorevlerBindingSource.DataSource = this.barinakTakipDataSetBindingSource;
            // 
            // gorevlerTableAdapter
            // 
            this.gorevlerTableAdapter.ClearBeforeFill = true;
            // 
            // gonullulerTableAdapter
            // 
            this.gonullulerTableAdapter.ClearBeforeFill = true;
            // 
            // cinslerTableAdapter
            // 
            this.cinslerTableAdapter.ClearBeforeFill = true;
            // 
            // turlerTableAdapter
            // 
            this.turlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gonullulerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barinakTakipDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGirisKaydol;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAdSyd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKaydolSifre2;
        private System.Windows.Forms.TextBox txtKaydolSifre1;
        private System.Windows.Forms.TextBox txtKaydolAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBDüzenleTemizle;
        private System.Windows.Forms.Button btnBDüzenleSil;
        private System.Windows.Forms.Button btnBDüzenleListele;
        private System.Windows.Forms.Button btnBDüzenleGüncelle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBDuzenleSifre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHavalandirma;
        private System.Windows.Forms.RadioButton rdHayvanTemizligi;
        private System.Windows.Forms.RadioButton rdSaglik;
        private System.Windows.Forms.RadioButton rdAlanTemizligi;
        private System.Windows.Forms.RadioButton rdAsi;
        private System.Windows.Forms.RadioButton rdOyun;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbDGATur;
        private System.Windows.Forms.ComboBox cmbDGACins;
        private System.Windows.Forms.ComboBox cmbDGAgorevAdi;
        private System.Windows.Forms.TextBox txtDGAAdSyd;
        private System.Windows.Forms.CheckBox chckTur;
        private System.Windows.Forms.CheckBox chckCins;
        private System.Windows.Forms.CheckBox chckGorevAdi;
        private System.Windows.Forms.CheckBox chckAdSyd;
        private System.Windows.Forms.TextBox txtKaydolTelNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnBDüzenleIleri;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBDuzenleTelNo;
        private System.Windows.Forms.TextBox txtBDuzenleAd;
        private System.Windows.Forms.BindingSource barinakTakipDataSetBindingSource;
        private BarinakTakipDataSet barinakTakipDataSet;
        private System.Windows.Forms.BindingSource gorevlerBindingSource;
        private BarinakTakipDataSetTableAdapters.GorevlerTableAdapter gorevlerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private BarinakTakipDataSet1 barinakTakipDataSet1;
        private System.Windows.Forms.BindingSource gonullulerBindingSource;
        private BarinakTakipDataSet1TableAdapters.GonullulerTableAdapter gonullulerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox cmbYeniGorevGun;
        private System.Windows.Forms.Button btbGonulluGoreviIleri;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbYeniGorevAdSyd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbYeniGorevCins;
        private BarinakTakipDataSet2 barinakTakipDataSet2;
        private System.Windows.Forms.BindingSource cinslerBindingSource;
        private BarinakTakipDataSet2TableAdapters.CinslerTableAdapter cinslerTableAdapter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnYeniGorevILERI;
        private BarinakTakipDataSet3 barinakTakipDataSet3;
        private System.Windows.Forms.BindingSource turlerBindingSource;
        private BarinakTakipDataSet3TableAdapters.TurlerTableAdapter turlerTableAdapter;
        private System.Windows.Forms.Button btnCikis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

