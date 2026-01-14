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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlBaglanti bgl = new SqlBaglanti();
            DataTable dt = new DataTable();
            // Sadece giriş yapan kişinin verilerini çeken kısım
            SqlDataAdapter da = new SqlDataAdapter("Select * From Requests Where EmployeeTC=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", SqlBaglanti.CurrentUserTC);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
