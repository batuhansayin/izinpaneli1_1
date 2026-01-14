using System;
using System.Data; // DataTable kullanmak için gerekli
using Microsoft.Data.SqlClient; // Sizin projenizdeki SQL kütüphanesi

namespace izinpaneli1_1
{
    // Bu sınıf IMessageService arayüzündeki kuralları uygular
    public class ManagerMessageService : IMessageService
    {
        // =============================================================
        // 1. MESAJ GÖNDERME METODU (Personel tarafı kullanır)
        // =============================================================
        public void SendMessage(string senderTC, string senderName, string message)
        {
            // Boş mesaj kontrolü
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new Exception("Lütfen mesaj içeriğini boş bırakmayınız.");
            }

            SqlBaglanti bgl = new SqlBaglanti();

            try
            {
                string sorgu = "INSERT INTO Messages (SenderTC, SenderName, MessageContent, SentDate) VALUES (@p1, @p2, @p3, @p4)";

                // bgl.baglanti() metodunuz Microsoft.Data.SqlClient kullandığı için burada da aynısını kullanıyoruz.
                using (SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti()))
                {
                    komut.Parameters.AddWithValue("@p1", senderTC);
                    komut.Parameters.AddWithValue("@p2", senderName);
                    komut.Parameters.AddWithValue("@p3", message);
                    komut.Parameters.AddWithValue("@p4", DateTime.Now);

                    komut.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Mesaj gönderilirken veritabanı hatası oluştu: " + ex.Message);
            }
        }

        // =============================================================
        // 2. MESAJLARI LİSTELEME METODU (Yönetici tarafı kullanır)
        // =============================================================
        public DataTable GetMessages()
        {
            SqlBaglanti bgl = new SqlBaglanti();
            DataTable dt = new DataTable();

            try
            {
                // Mesajları en yeniden eskiye doğru sıralayarak getirir (ORDER BY SentDate DESC)
                // Sütun isimlerini 'AS' kullanarak Türkçeleştiriyoruz ki DataGridView'de güzel görünsün.
                string sorgu = "SELECT SenderName AS 'Gönderen', SenderTC AS 'TC No', MessageContent AS 'Mesaj', SentDate AS 'Tarih' FROM Messages ORDER BY SentDate DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti()))
                {
                    da.Fill(dt); // Verileri tabloya doldurur
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Mesajlar yüklenirken hata oluştu: " + ex.Message);
            }

            return dt; // Dolu tabloyu forma gönderir
        }
    }
}