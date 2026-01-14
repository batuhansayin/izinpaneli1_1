using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izinpaneli1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*'; // Şifreyi gizle
            this.Text = "izinpaneli1.1 - Giriş";
        }


private void btnGiris_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text;
            string pass = txtSifre.Text;

            var user = MockDatabase.Users.FirstOrDefault(u => u.TC == tc && u.Password == pass);

            if (user != null)
            {
                MockDatabase.CurrentUser = user;

                // 1. Giriş ekranını gizle
                this.Hide();

                // 2. Diğer formu aç (ShowDialog programı burada bekletir)
                if (user.Role == "Yonetici")
                {
                    Form3 yoneticiForm = new Form3();
                    yoneticiForm.ShowDialog();
                }
                else
                {
                    Form2 calisanForm = new Form2();
                    calisanForm.ShowDialog();
                }

                // 3. Diğer form kapandığında kod buradan devam eder ve giriş ekranı geri gelir
                this.Show();
                txtSifre.Text = ""; // Şifre kutusunu temizle
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!");
            }
        }
    }
    }

