using System;
using System.Data;

namespace izinpaneli1_1
{
    public interface IMessageService
    {
        // Sadece metodun imzasını atıyoruz (Gövdesi yok)
        void SendMessage(string senderTC, string senderName, string message); //proje sözleşmesi 
            DataTable GetMessages();
        }
    }
