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

namespace latihan2
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //perintah untuk membuat koneksi
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-PH7811B5;Initial Catalog=latihan1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from tbl_login where username = '"+textBox1.Text+"' and pass = '"+textBox2.Text+"'",koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form_Menu panggil = new Form_Menu();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password Salah!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
