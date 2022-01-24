using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NeseliBarinakGonulluTakip
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-7QUPKGJB\\SQLEXPRESS; Initial Catalog=BarinakTakip; Integrated Security=SSPI");
        SqlCommand Komut;
        SqlDataAdapter verial;
        DataSet ds;
        SqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
        }

        public void listele()
        {
           //Label14'te yer alan id'ye göre gonulluler tablosu getirilir
            baglanti.Open();
            Komut = new SqlCommand("select * from Gonulluler where GonulluID = @GonulluID  ", baglanti);
            Komut.Parameters.AddWithValue("@GonulluID", label14.Text);
            verial = new SqlDataAdapter();//veri getirmek için 
            verial.SelectCommand = Komut;//komutu sqldataadapter'a atadık
            ds = new DataSet();//sqldataadpter tarafından getirilen verileri saklar
            verial.Fill(ds);//verileri doldurduk
            dataGridView1.DataSource = ds.Tables[0];//datagridview1'in veri kaynağı 0'ıncı tabloda saklanır 
            baglanti.Close();
        }

        public void idGetir()
        {
            //Kaydol kısmında eklenen kullanıcının otomatik gelen id'sini ismine göre filtreleyip label'a yazdırmak için fonksiyon
            baglanti.Open();
            Komut = new SqlCommand("select * from Gonulluler where AdiSoyadi = @AdiSoyadi", baglanti);
            Komut.Parameters.AddWithValue("@AdiSoyadi", txtKaydolAd.Text); // kayıt için girilen ismi alıyoruz
            dr = Komut.ExecuteReader();
            dr.Read();
            label10.Text = dr["GonulluID"].ToString();
            baglanti.Close();
        }


        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Komut = new SqlCommand("select * from Gonulluler where AdiSoyadi = @AdiSoyadi and Sifre= @Sifre", baglanti);
            Komut.Parameters.AddWithValue("@AdiSoyadi", txtAdSyd.Text);
            Komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            if (txtAdSyd.Text == "" || txtSifre.Text == "")// Şifre ve Ad soyad bilgisinin girildiğinin kontrolü
            {
                MessageBox.Show("Giriş Bilgileri Boş Bırakılamaz.");
                baglanti.Close();
            }
            else
            //Giriş bilgileri doldurulduysa sqldatareader ile okuma işlemi yapılır
            {
                dr = Komut.ExecuteReader();// Sqlcommand’ın sorgusundan executereader ile dönen değeri sqldatareader'a atıyoruz.
                if (dr.Read()) //sorgu okunacak true döndürüyorsa okunacak değer varsa çalışır 
                {
                    MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                    label4.Text = dr["GonulluID"].ToString(); // GonulluID kolonundan alınan id'yi label'a atıyoruz 
                    txtBDuzenleSifre.Text = dr["Sifre"].ToString();// Sifre kolonundan alınan bilgiyi atıyoruz düzenle ekranını doldurması için
                    txtBDuzenleTelNo.Text = dr["TelNo"].ToString();// TelNo kolonundan alınan bilgiyi atıyoruz düzenle ekranını doldurması için
                    txtBDuzenleAd.Text = dr["AdiSoyadi"].ToString(); //AdiSoyadi kolonundan alınan bilgiyi atıyoruz düzenle ekranını doldurması için
                    label14.Text = dr["GonulluID"].ToString();
                    baglanti.Close();
                    tabControl1.SelectedTab = tabPage3;
                    label4.Text = "";
                    txtAdSyd.Clear();
                    txtSifre.Clear();

                }
                else //Bilgiler eşleşmiyorsa false ise çalışır
                {
                    MessageBox.Show("Girilen bilgilere ait kullanıcı bulunamadı bilgilerinizi kontrol ediniz veya kayıt olunuz.");
                    baglanti.Close();

                }
            }
        }

        private void btnGirisKaydol_Click(object sender, EventArgs e)
        {
        //Kaydolmak isteyen kullanıcılar için Gönüllü Kaydol ekranına yönlendirilirler
            txtAdSyd.Clear();
            txtSifre.Clear();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {

            if (txtKaydolAd.Text == "" || txtKaydolTelNo.Text == "")
            {
                //Kayıt için alanların doldurulması kontrol edilir
                MessageBox.Show("Alanlar Boş Bırakılamaz");
            }
            else
            {
                if (txtKaydolSifre1.Text == txtKaydolSifre2.Text)
                //Şifrelerin eşleşip eşleşmediği kontrol edilir
                {

                    baglanti.Open();
                    //İnsert into ile textboxtan girilen bilgiler parametre aracılığı ile sorguda aratılır
                    Komut = new SqlCommand("insert into Gonulluler (AdiSoyadi,Sifre,TelNo) values(@Ad, @Sifre,@TelNo)", baglanti);
                    Komut.Parameters.AddWithValue("@Sifre", txtKaydolSifre1.Text);
                    Komut.Parameters.AddWithValue("@ad", txtKaydolAd.Text);
                    Komut.Parameters.AddWithValue("@TelNo", txtKaydolTelNo.Text);
                    Komut.ExecuteNonQuery();// komuttan geriye değer getirmediği için executenonquery
                    baglanti.Close();
                   // Kaydol kısmında girilen bilgilere göre düzenle ekranındaki yerler doldurulur
                    idGetir();//txtKaydolAd ile girilen ismin id si alınır bu fonksiyon ile ve label10'a aktarılır
                    label14.Text = label10.Text;//idgetir ile alınan id label14'e(düzenle akranında) aktarılır.
                    txtBDuzenleSifre.Text = txtKaydolSifre1.Text;
                    txtBDuzenleAd.Text = txtKaydolAd.Text;
                    txtBDuzenleTelNo.Text = txtKaydolTelNo.Text;
                    //Kaydolma işlemi gerçekleştiği için ekrana mesaj yazdırılır.
                    MessageBox.Show("Neşeli BarınaK Ailesine Hoşgeldiniz :) ");
                    //Bilgileri düzenle ekranına geçilir
                    tabControl1.SelectedTab = tabPage3;
                    //Ekrana girilen bilgiler aktarıldığı ve yeni sayfaya geçildiği için bilgiler temizlenir.
                    label10.Text = "";
                    txtKaydolAd.Clear();
                    txtKaydolSifre1.Clear();
                    txtKaydolSifre2.Clear();
                    txtKaydolTelNo.Clear();

                }
                else
                {
                    //şifreler eşleşmiyorsa ekrana bu mesaj verdirilir
                    MessageBox.Show("Şifreleriniz Uyumsuz Kontrol Edip Tekrar Deneyiniz");

                }
            }
        }

        private void btnBDuzenleListele_Click(object sender, EventArgs e)
        {
            listele();// listele fonsiyonu içinde id bilgisine göre gonulluler tablosundaki bilgiler getirilir
        }

        private void btnBDüzenleGüncelle_Click(object sender, EventArgs e)
        {
            DialogResult tus = MessageBox.Show("Bilgileriniz Güncellensin mi ?", "Neşeli Barınak", MessageBoxButtons.YesNo);
            if (tus == DialogResult.Yes)
            {
                baglanti.Open();
                //textboxlardaki girilen veriler parametre olarak sorgu içine gönderilir ve güncelleme işlemi yapılır
                Komut = new SqlCommand("Update Gonulluler set AdiSoyadi=@Ad, Sifre=@Sifre, TelNo=@TelNo where GonulluID=@GonulluID", baglanti);
                Komut.Parameters.AddWithValue("@GonulluID", label14.Text);
                Komut.Parameters.AddWithValue("@Ad", txtBDuzenleAd.Text);
                Komut.Parameters.AddWithValue("@Sifre", txtBDuzenleSifre.Text);
                Komut.Parameters.AddWithValue("@TelNo", txtBDuzenleTelNo.Text);
                Komut.ExecuteNonQuery();
                baglanti.Close();
                listele();//Listele fonksiyou ile güncellenen veriler datagridview'de gösterilir 
                MessageBox.Show("Bilgileriniz Güncellendi");
            }
        }
        //herhangi bir hücreye tıklandığında yapılacak işlemler için datagridview'in olayıdır
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // datagridview'in tıklanan satırındaki hücre değerleri
            label14.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//0. hücre id hücresi
            txtBDuzenleAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // 1.hücre adısoyadı hücresi
            txtBDuzenleSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//2.hücre sifre hücresi
            txtBDuzenleTelNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();//3.hücre telno hücresi
        }

        private void btnBDüzenleSil_Click(object sender, EventArgs e)
        {
            //tıklandığında ekrana soru yazdırılır kaydınız silinsin mi eğer evetse silme işlemi gerçekleştirilir.
            DialogResult tus = MessageBox.Show("Kaydınız Silinsin mi?", "Neşeli Barınak", MessageBoxButtons.YesNo);
            if (tus == DialogResult.Yes)// cevap evetse
            {
                baglanti.Open();
                Komut = new SqlCommand("delete from Gonulluler where GonulluID = @GonulluID", baglanti);// gonulluID'ye göre kişi silinir
                Komut.Parameters.AddWithValue("@GonulluID", label14.Text);
                Komut.ExecuteNonQuery();
                baglanti.Close();
                //textboxlar temizlenir
                txtBDuzenleAd.Clear();
                txtBDuzenleSifre.Clear();
                txtBDuzenleTelNo.Clear();
                label14.Text = "";
                // silindiği için ekrana mesaj yazdırılır
                MessageBox.Show("Kaydınız Silindi. Sizi Özleyeceğiz.");
                //kişi kaydı silindiği için giriş ekranına yönlendirilir
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btnBDüzenleTemizle_Click(object sender, EventArgs e)
        {
            //Textboxlardaki alanlar temizlenir 
            //id temizlemiyoruz çünkü kalıcı olarak silme değil
            txtBDuzenleAd.Clear();
            txtBDuzenleSifre.Clear();
            txtBDuzenleTelNo.Clear();
            
        }

        private void btnBDüzenleIleri_Click(object sender, EventArgs e)
        {
            // Düzenleme işlemi bittikten sonraki ekrana geçmek için bulunduğumz ekrandaki alanlar temizlenir ve sonraki ekrana geçilir
            txtBDuzenleAd.Clear();
            txtBDuzenleSifre.Clear();
            txtBDuzenleTelNo.Clear();
            dataGridView1.Columns.Clear();
            tabControl1.SelectedTab = tabPage4;
            label14.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'barinakTakipDataSet3.Turler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.turlerTableAdapter.Fill(this.barinakTakipDataSet3.Turler);
            // TODO: Bu kod satırı 'barinakTakipDataSet2.Cinsler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cinslerTableAdapter.Fill(this.barinakTakipDataSet2.Cinsler);
            // TODO: Bu kod satırı 'barinakTakipDataSet1.Gonulluler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gonullulerTableAdapter.Fill(this.barinakTakipDataSet1.Gonulluler);
            // TODO: Bu kod satırı 'barinakTakipDataSet.Gorevler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gorevlerTableAdapter.Fill(this.barinakTakipDataSet.Gorevler);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comboboxta seçilen isme göre sorgudaki select kısmında belirtilen alanların getirilmesi
            //ve datagridview2 için gelen verilerin doldurulması
            baglanti.Open();
            SqlDataAdapter verial2 = new SqlDataAdapter("Select gn.GonulluID, gn.AdiSoyadi, g.GorevAdi, gg.GorevGunu, c.CinsAdi " +
            "from Gonulluler gn, Gorevler g, GorevGunleri gg, Cinsler c " +
            "where gn.GonulluID = g.GonulluID and g.GorevID = gg.GorevID  and gg.CinsID = c.CinsID " +
            "and AdiSoyadi ='" + comboBox1.Text + "' ", baglanti);
            DataSet ds2 = new DataSet();
            verial2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            baglanti.Close();

        }

        private void btbGonulluGoreviIleri_Click(object sender, EventArgs e)
        {
            //Sonraki sayfaya geçilir ve ekrandaki veriler temizlenir
            tabControl1.SelectedTab = tabPage5;
            comboBox1.Text = "";
            dataGridView2.Columns.Clear();
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            //Gorevler Tablosuna Ekleme
            //Gorevler tablosuna ekleme için sadece GorevAdi alanı gerekiyor Gorevid otomatik geliyor
            //Comboboxtan kişi ismini seçtiği için oradan da Gonulluid alınıyor.
            baglanti.Open();
            Komut = new SqlCommand("insert into Gorevler(GonulluID,GorevAdi) values (@GonulluID, @GorevAdi)", baglanti);
            Komut.Parameters.AddWithValue("@GonulluID", cmbYeniGorevAdSyd.SelectedValue);//Comboboxta seçilen kişi isminin değeri yani idsi geliyor
            // radiobuttonlar içinde hangisi seçiliyse textini gorev'e atama işlemi
            string gorev = "";
            if (rdOyun.Checked) 
            gorev = rdOyun.Text;
            if (rdAlanTemizligi.Checked)
            gorev = rdAlanTemizligi.Text;
            if (rdHayvanTemizligi.Checked) 
            gorev = rdHayvanTemizligi.Text;
            if (rdAsi.Checked)
            gorev = rdAsi.Text;
            if (rdSaglik.Checked) 
            gorev = rdSaglik.Text;
            if (rdHavalandirma.Checked) 
            gorev = rdHavalandirma.Text;
            //bütün alanların seçili olup olmadığının kontrolü 
            if (gorev == "" || cmbYeniGorevGun.Text == "" || cmbYeniGorevCins.Text == "" || cmbYeniGorevAdSyd.Text == "")
                MessageBox.Show("Bütün Alanların Doldurulması Zorunludur");
            else
            // Bütün alanlar doldurulmuş ise çalışacak kısım;
            {
            //radiobuttonda seçilip göreve atanmış olan değer(radiobuttonun texti) parametre olarak sorgu için veriliyor
                Komut.Parameters.AddWithValue("@GorevAdi", gorev);
                Komut.ExecuteNonQuery();
             //Gorevler Tablosuna Ekleme Bitti

          //GorevGunleri Tablosuna Ekleme
                int Gorevid;//Sorgudan dönen Gorevid'yi tutmak için
                Komut = new SqlCommand("select max(GorevID) from Gorevler", baglanti);// en son eklenen görevin idsini max ile alıyoruz
                //executescalar çünkü tek bir değer dönecek görevidsi en büyük olan kişi
                Gorevid = Convert.ToInt32(Komut.ExecuteScalar());//son eklenen görevin idsi Gorevid'ye atandı
             //Ekleme işlemi için insert sorgusu 
                Komut = new SqlCommand("insert into GorevGunleri(GorevID, CinsID,GorevGunu) values (@GorevID,@CinsID,@GorevGunu)", baglanti);
                Komut.Parameters.AddWithValue("@GorevID", Gorevid);//Son eklenen görevi Gorevid'ye atamıştık bunu parametre olarak sorguya verdik
                Komut.Parameters.AddWithValue("@CinsID", Convert.ToInt32(cmbYeniGorevCins.SelectedValue));//Seçilen cins isminin idsini aldık
                Komut.Parameters.AddWithValue("@GorevGunu", cmbYeniGorevGun.Text);
                Komut.ExecuteNonQuery();
             //GorevGunleri Tablosuna Ekleme Bitti

             //dataGridView5'e Ekleme Sonuçlarını yazdırma
             //Comboboxta ismi seçilen kişiyi sorguya parametre olarak gönderek
             //select kısmındaki filtreleme ile kişiye ait yeni eklenmiş alanlarda dahil olmak üzere alanların getirilmesi.
                Komut = new SqlCommand("select gn.GonulluID, gn.AdiSoyadi, g.GorevAdi, gg.GorevGunu, c.CinsAdi " +
                "from Gonulluler gn, Gorevler g, GorevGunleri gg, Cinsler c " +
                "Where gn.GonulluID = g.GonulluID and g.GorevID = gg.GorevID and gg.CinsID = c.CinsID " +
                "and AdiSoyadi = @AdiSoyadi", baglanti);
                Komut.Parameters.AddWithValue("@AdiSoyadi", cmbYeniGorevAdSyd.Text);
                verial = new SqlDataAdapter();
                verial.SelectCommand = Komut;
                ds = new DataSet();
                verial.Fill(ds);
                dataGridView5.DataSource = ds.Tables[0];
                MessageBox.Show("Göreviniz başarıyla eklendi");
            }
            baglanti.Close();

        }
        //Dinamik Tablolar getirmek için tablo isimlerinin seçildiği combobox
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            string secilentablo = comboBox8.Text; //Comboboxta seçilen alanı secilentabloya atadık
            SqlDataAdapter verial = new SqlDataAdapter("Select * From " + secilentablo, baglanti);// seçilen tabloyu getirdik
            DataSet ds = new DataSet();
            if (ds.Tables.Count > 0) ds.Tables.Clear();// Eğer Tablo sayısı 0'dan fazlaysa sonraki seçilen tabloyu yanına eklememek için öncekinin verilerini sildik
            verial.Fill(ds);//Verileri doldur
            dataGridView4.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnYeniGorevILERI_Click(object sender, EventArgs e)
        {
            // Yeni sayfaya geçtik ve alanları temizledik radiobutton seçimlerini kaldırdık
            tabControl1.SelectedTab = tabPage6;
            cmbYeniGorevCins.Text = "";
            cmbYeniGorevGun.Text = "";
            cmbYeniGorevAdSyd.Text = "";
            comboBox8.Text = "";
            dataGridView5.Columns.Clear();
            dataGridView4.Columns.Clear();
            rdAlanTemizligi.Checked = false;
            rdAsi.Checked = false;
            rdOyun.Checked = false;
            rdSaglik.Checked = false;
            rdHavalandirma.Checked = false;
            rdHayvanTemizligi.Checked = false;
        }


     //Detaylı Arama için checkboxların seçili olma durumlarını kontrol etme 
     //Seçili alanların karşısına gelen alanları aktif etme 
     //Seçimlerin kaldırılması halinde Alanların temizlenmesi

        private void chckAdSyd_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAdSyd.Checked == true) txtDGAAdSyd.Enabled = true;
            else
                txtDGAAdSyd.Enabled = false;
            txtDGAAdSyd.Clear();
        }
        private void chckGorevAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chckGorevAdi.Checked == true) cmbDGAgorevAdi.Enabled = true;
            else
                cmbDGAgorevAdi.Enabled = false;
            cmbDGAgorevAdi.Text = "";
        }
        private void chckCins_CheckedChanged(object sender, EventArgs e)
        {
            if (chckCins.Checked == true) cmbDGACins.Enabled = true;
            else
                cmbDGACins.Enabled = false;
            cmbDGACins.Text = "";
        }
        private void chckTur_CheckedChanged(object sender, EventArgs e)
        {
            if (chckTur.Checked == true) cmbDGATur.Enabled = true;
            else
                cmbDGATur.Enabled = false;
            cmbDGATur.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secilen = secilenchck(); // Fonsiyondaki değeri secilen'e atadık
            //Secileni sorguya ekledik bu sayede secilenin içinde yer alan sorgu ana sorguya dahil edildi. secilen filtreleme yapıyor anasorgu için
            //Eğer secilenin içi boşsa yani hiçbir alan seçilmediyse ana sorgu çalışır herhangi bir filtreleme olmadan bütün alanlar getirilir
            SqlDataAdapter verial = new SqlDataAdapter("Select * from " +
            "Gonulluler gn, Gorevler g, GorevGunleri gg, Cinsler c, Turler t " +
            "where gn.GonulluID = g.GonulluID and g.GorevID = gg.GorevID  and gg.CinsID = c.CinsID and c.TürID = t.TürID " +
            secilen, baglanti);
            DataSet ds = new DataSet();
            verial.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            baglanti.Close();
        }

         //Seçilen alanların kontrolü ve alan seçiliyse sorguya eklenecek sorguyu gösteren fonksiyon
        public string secilenchck()
       {
            string secilen = " ";//Hiçbirini seçmezse
            if (chckAdSyd.Checked == true) secilen += "and AdiSoyadi like '%" + txtDGAAdSyd.Text + "%' ";
            if (chckGorevAdi.Checked == true) secilen += "and GorevAdi ='" + cmbDGAgorevAdi.Text + "' ";
            if (chckCins.Checked == true) secilen += "and CinsAdi ='" + cmbDGACins.Text + "' ";
            if (chckTur.Checked == true) secilen += "and TürAdi ='" + cmbDGATur.Text + "' ";
            return secilen;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //Çıkış butonu kişiye soru yöneltilir eğer evetse veriler temizlenir ve giriş ekranına yönlendirilir.
            DialogResult tus = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Neşeli Barınak", MessageBoxButtons.YesNo);
            if (tus == DialogResult.Yes)
            {
                chckAdSyd.Checked = false;
                chckCins.Checked = false;
                chckGorevAdi.Checked = false;
                chckTur.Checked = false;
                dataGridView3.Columns.Clear();
                tabControl1.SelectedTab = tabPage1;

            }
        }
    }
}
