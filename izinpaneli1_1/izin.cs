using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace izinpaneli1_1
{
    public partial class Form1 : Form      //(standart form sınıfından miras)
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }

        SqlBaglanti bgl = new SqlBaglanti();

        // Bu değişkeni ekledik: Timer çalışırken hangi role gideceğimizi burada tutacağız
        string gidilecekRol = "";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Parametreli güvenli giriş sorgusu (SQL)
            SqlCommand komut = new SqlCommand("Select * From Users Where TC=@p1 and Password=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                // 1. KULLANICI BİLGİLERİNİ AL (SQL)
                SqlBaglanti.CurrentUserTC = dr["TC"].ToString();
                SqlBaglanti.CurrentUserName = dr["Name"].ToString();    // ( bu kısımda bilgiyi static tutup form2 ve form3 e bildiriyoruz new ile )
                SqlBaglanti.CurrentUserDays = Convert.ToInt32(dr["RemainingLeaveDays"]); //( Veritabanındaki sayıyı C# integer'ına, metni string'e çevirme.)

                // Rolü global değişkene ata (Birazdan Timer içinde kullanacağız)
                gidilecekRol = dr["Role"].ToString();

                // ... (Giriş başarılı if bloğunun içi) ...

                pbTik.Visible = true;           
                progressBar1.Visible = true;    
                progressBar1.Value = 0;         

                btnGiris.Enabled = false;       
                timer1.Start();                 
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
        }

    


        private void timer1_Tick(object sender, EventArgs e)
        {
            // 
           
            progressBar1.Value += 2;

         
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();              // Sayacı durdur
                pbTik.Visible = false;      // Gizle
                progressBar1.Visible = false; // Gizle
                btnGiris.Enabled = true;    // Kilidi aç

                this.Hide(); // Giriş ekranını gizle

                // role göre formu aç (Yönetici ise Form3, değilse Form2)
                if (gidilecekRol == "Yonetici")
                {
                    Form3 frm = new Form3();
                    frm.ShowDialog();
                }
                else
                {
                    Form2 frm = new Form2();
                    frm.ShowDialog();
                }

                // Çıkış yapılıp geri dönüldüğünde burası çalışır
                this.Show();
                txtSifre.Text = "";
                progressBar1.Value = 0;
            }
        }

  

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

    