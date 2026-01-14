using System;
using Microsoft.Data.SqlClient; // Dikkat: Microsoft kütüphanesi
using System.IO;

namespace izinpaneli1_1
{
    public class SqlBaglanti
    {
        // Giriş yapan kullanıcının bilgilerini tutacağımız yer
        public static string CurrentUserTC = "";
        public static string CurrentUserName = "";
        public static int CurrentUserDays = 0;

        public SqlConnection baglanti()
        {
            // Veritabanı yolunu dinamik bulma
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IzinPaneliDb.mdf");

            // Bağlantı cümlesi (Encrypt=False çok önemli!)
            string baglan = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Encrypt=False";

            SqlConnection bgl = new SqlConnection(baglan);
            bgl.Open();
            return bgl;
        }
    }
}