using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace izinpaneli1_1
{
    public partial class Form2 : Form
    {
 
            // Interface referansı (Class değil, Interface )
            private readonly IMessageService _messageService;

            public Form2()
            {
                InitializeComponent();
                _messageService = new ManagerMessageService();
            }

           

            // --- GLOBAL DEĞİŞKENLER (Sayac İçin) --- // bilgisayardan çekilen veriler // kapsülleme 
            DateTime izinBitisTarihi;
        bool aktifIzinVar = false;

        // --- FORM YÜKLENİRKEN ÇALIŞAN KISIM ---
        private void Form2_Load(object sender, EventArgs e)
        {
            //  SAATE GÖRE SELAMLAMA
            int saat = DateTime.Now.Hour;
            string selamlama = "";

            if (saat >= 5 && saat < 12) selamlama = "Günaydın";
            else if (saat >= 12 && saat < 18) selamlama = "İyi Günler";
            else if (saat >= 18 && saat < 24) selamlama = "İyi Akşamlar";
            else selamlama = "İyi Geceler";

            lblKarsilama.Text = selamlama + ", " + SqlBaglanti.CurrentUserName;

            // KALAN İZİN GÜNÜ
            lblKalanIzin.Text = "Kalan İzin Hakkınız: " + SqlBaglanti.CurrentUserDays + " Gün";

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            // --- AKTİF İZİN SAYACI ---
            try
            {
                SqlBaglanti bgl = new SqlBaglanti();
                // Veritabanından Status='Onaylandi' olan ve tarihi geçmemiş izni çekiyoruz
                // Tablo: Requests, Sütunlar: EndDate, Status, EmployeeTC
                SqlCommand komut = new SqlCommand("SELECT TOP 1 EndDate FROM Requests WHERE EmployeeTC=@p1 AND Status='Onaylandi' AND EndDate > GETDATE() ORDER BY EndDate ASC", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", SqlBaglanti.CurrentUserTC);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    izinBitisTarihi = Convert.ToDateTime(dr["EndDate"]);
                    aktifIzinVar = true;

                    // Sayacı başlat
                    timerSayac.Start();
                }
                else
                {
                    lblKalanSure.Text = "Şu an aktif bir izniniz yok.";
                    lblKalanSure.ForeColor = Color.LightGray;
                }
            }
            catch (Exception)
            {
                // Veritabanı hatası olursa program çökmesin
                lblKalanSure.Text = "";
            }
        }

        // --- GERİ SAYIM SAYACI (HER SANİYE ÇALIŞIR) ---
        private void timerSayac_Tick(object sender, EventArgs e)
        {
            if (aktifIzinVar)
            {
                TimeSpan fark = izinBitisTarihi - DateTime.Now;

                // Süre bittiyse
                if (fark.TotalSeconds <= 0)
                {
                    timerSayac.Stop();
                    lblKalanSure.Text = "İzin Süreniz Doldu! İş Başı Yapmalısınız.";
                    lblKalanSure.ForeColor = Color.Red;
                }
                else
                {
                    // Ekrana kalan süreyi yazdır
                    lblKalanSure.Text = string.Format("İş Başına Kalan: {0} Gün {1} Saat {2} Dakika {3} Saniye",
                        fark.Days, fark.Hours, fark.Minutes, fark.Seconds);
                }
            }
        }

        // --- BELGE / RAPOR SEÇ BUTONU ---
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Rapor veya Belge Seçin";
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;|PDF Dosyaları|*.pdf|Tüm Dosyalar|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblDosyaYolu.Text = "Seçilen: " + ofd.SafeFileName;
                this.Tag = ofd.FileName;
            }
        }

        // --- İZİN İSTE (GÖNDER) BUTONU ---
        private void btnGonder_Click(object sender, EventArgs e)
        {
            //Tarih Hesaplaması
            TimeSpan fark = dtBitis.Value - dtBaslangic.Value;
            int istenenGun = (int)fark.TotalDays+1;

            //Kontroller
            if (istenenGun <= 0)
            {
                MessageBox.Show("Hata: Bitiş tarihi başlangıç tarihinden sonra olmalıdır.", "Tarih Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (istenenGun > SqlBaglanti.CurrentUserDays)
            {
                MessageBox.Show("Hata: Yeterli izin hakkınız bulunmamaktadır. (Kalan: " + SqlBaglanti.CurrentUserDays + ")", "Yetersiz Hak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına Kayıt 
            try
            {
                SqlBaglanti bgl = new SqlBaglanti();

                SqlCommand komut = new SqlCommand("insert into Requests (EmployeeTC, EmployeeName, StartDate, EndDate, FilePath, Status) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", SqlBaglanti.CurrentUserTC);
                komut.Parameters.AddWithValue("@p2", SqlBaglanti.CurrentUserName);
                komut.Parameters.AddWithValue("@p3", dtBaslangic.Value);
                komut.Parameters.AddWithValue("@p4", dtBitis.Value);

                if (this.Tag != null)
                    komut.Parameters.AddWithValue("@p5", this.Tag.ToString());
                else
                    komut.Parameters.AddWithValue("@p5", "");

                komut.Parameters.AddWithValue("@p6", "Bekliyor");

                komut.ExecuteNonQuery();
                



                // İzin gününü güncelle ve eksilt
                SqlBaglanti.CurrentUserDays = SqlBaglanti.CurrentUserDays - istenenGun;
                lblKalanIzin.Text = "Kalan İzin Hakkınız: " + SqlBaglanti.CurrentUserDays + " Gün";

                MessageBox.Show("İzin talebiniz başarıyla yöneticiye iletildi.\nİzin gününüz güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // --- izin durumları butonları ---
        private void btnDurum_Click(object sender, EventArgs e)
        {
            Form4 durumForm = new Form4();
            durumForm.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- SAAT ---
        private void timerSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        { try
            {
                // Interface üzerinden mesajı gönderiyoruz
                _messageService.SendMessage(
                    SqlBaglanti.CurrentUserTC,    // Sizin sistemdeki TC değişkeniniz
                    SqlBaglanti.CurrentUserName,  // Sizin sistemdeki İsim değişkeniniz
                    txtYoneticiMesaj.Text         // TextBox'tan gelen yazı
                );

                MessageBox.Show("Mesajınız yöneticiye iletildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtYoneticiMesaj.Text = ""; // Kutuyu temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
