using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace izinpaneli1_1
{
    public partial class Form3 : Form
    {
        // 1. Interface referansını tanımlanması
        private readonly IMessageService _messageService;
        SqlBaglanti bgl = new SqlBaglanti();

        public Form3()
        {
            InitializeComponent();

            // 2. Servisi burada new'liyoruz (Polimorfizm) bu andaki çalışma modunu yönetici olarak ayarlıyor
            _messageService = new ManagerMessageService();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Listele();       // Mevcut izinleri yükler (dataGridView1)
            MesajlariGetir(); // Yeni mesajları yükler (dgvMesajlar)
        }

        // --- MEVCUT İZİN LİSTELEME METODUNUZ ---
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Requests", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // --- YENİ EKLENEN MESAJ LİSTELEME METODU ---
        void MesajlariGetir()
        {
            try
            {
                // Interface üzerinden verileri çekip ikinci tabloya basıyoruz
                dgvMesajlar.DataSource = _messageService.GetMessages();

                // Sütun genişlik ayarları (İsteğe bağlı)
                if (dgvMesajlar.Columns.Count > 0)
                {
                    dgvMesajlar.Columns[0].Width = 120; // Gönderen
                    dgvMesajlar.Columns[2].Width = 300; // Mesaj İçeriği
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesajlar yüklenirken hata: " + ex.Message);
            }
        }

        // --- MEVCUT BUTON KODLARINIZ (Aynen Korundu) ---
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                string tcNo = dataGridView1.CurrentRow.Cells["EmployeeTC"].Value.ToString();
                int talepID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                string mevcutDurum = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();

                int dusulecekGun = 0;
                var gunDegeri = dataGridView1.CurrentRow.Cells["Days"].Value;

                if (gunDegeri == DBNull.Value || gunDegeri == null)
                {
                    DateTime baslangic = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["StartDate"].Value);
                    DateTime bitis = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["EndDate"].Value);
                    TimeSpan fark = bitis - baslangic;
                    dusulecekGun = (int)fark.TotalDays;
                }
                else
                {
                    dusulecekGun = Convert.ToInt32(gunDegeri);
                }

                if (mevcutDurum == "Onaylandı")
                {
                    MessageBox.Show("Bu izin zaten onaylanmış.");
                    return;
                }

                SqlBaglanti bgl = new SqlBaglanti();
                SqlCommand komutDurum = new SqlCommand("UPDATE Requests SET Status='Onaylandı' WHERE Id=@id", bgl.baglanti());
                komutDurum.Parameters.AddWithValue("@id", talepID);
                komutDurum.ExecuteNonQuery();

                SqlCommand komutDus = new SqlCommand("UPDATE Users SET RemainingLeaveDays = RemainingLeaveDays - @gun WHERE TC=@tc", bgl.baglanti());
                komutDus.Parameters.AddWithValue("@gun", dusulecekGun);
                komutDus.Parameters.AddWithValue("@tc", tcNo);
                komutDus.ExecuteNonQuery();

                MessageBox.Show("İzin onaylandı ve " + dusulecekGun + " gün bakiyeden düşüldü.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele(); // Listeyi yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    SqlCommand komut = new SqlCommand("Update Requests Set Status='Reddedildi' where Id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("İzin talebi reddedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce listeden işlem yapmak istediğiniz talebi seçin.");
            }
        }

        private void btnBelgeGor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string path = dataGridView1.CurrentRow.Cells["FilePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı veya yüklenmemiş.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}