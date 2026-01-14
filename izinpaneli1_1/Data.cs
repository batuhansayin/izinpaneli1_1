using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace izinpaneli1_1
    {
        // Kullanıcı Modeli
        public class User
        {
            public string TC { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Role { get; set; } // "Yonetici" veya "Calisan"
            public int RemainingLeaveDays { get; set; }
        }

        // İzin Talep Modeli
        public class LeaveRequest
        {
            public int Id { get; set; }
            public string EmployeeTC { get; set; }
            public string EmployeeName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string FilePath { get; set; } // Rapor dosya yolu
            public string Status { get; set; } // "Bekliyor", "Onaylandı", "Reddedildi"
        }

        // Geçici Veritabanı
        public static class MockDatabase
        {
            public static List<User> Users = new List<User>()
        {
            // Örnek Çalışan (TC: 12345, Şifre: 1234)
            new User { TC = "12345", Password = "1234", Name = "Ahmet Yılmaz", Role = "Calisan", RemainingLeaveDays = 14 },
            // Örnek Yönetici (TC: 99999, Şifre: admin)
            new User { TC = "99999", Password = "admin", Name = "Mehmet Müdür", Role = "Yonetici", RemainingLeaveDays = 30 }
        };

            public static List<LeaveRequest> Requests = new List<LeaveRequest>();
            public static User CurrentUser; // O an giriş yapan kişi
        }
    }

