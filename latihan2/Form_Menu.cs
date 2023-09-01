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
using System.IO;
using ADODB;


namespace latihan2
{
    public partial class Form_Menu : Form
    {
        static SqlDataReader reader;
        string str;
        SqlConnection con;
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-PH7811B5;Initial Catalog=latihan1;Integrated Security=True");
        

        public Form_Menu()
        {
            InitializeComponent();
            tampilan_data_mhs();

            //untuk membuat judul pada masing-masing kolom tabel transaksi
            dgv_transaksi.ColumnCount = 4;
            dgv_transaksi.Columns[0].Name = "nama barang";
            dgv_transaksi.Columns[1].Name = "jumlah";
            dgv_transaksi.Columns[2].Name = "harga";
            dgv_transaksi.Columns[3].Name = "Total";

            //mengatur lebar kolom secara otomatis
            dgv_transaksi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_transaksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_transaksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_transaksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //perintah untuk membuat tampilan data dari database
        void tampilan_data_mhs()
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_barang",koneksi);
            SqlDataAdapter sdt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdt.Fill(dt);
            dgv_item.DataSource = dt;
            koneksi.Close();
        }

        
        
        //perintah untuk tambah pada form Item
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = "insert into tbl_barang values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '"+textBox5.Text+"', '"+textBox6.Text+"')";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            tampilan_data_mhs();
            MessageBox.Show("Data berhasil Di Tambahkan");
        }

        //perintah untuk hapus pada form Item
        private void btn_hapus_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = "delete from tbl_barang where kd_barang = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            tampilan_data_mhs();
            MessageBox.Show("Data berhasil Di Hapus");

        }

        //perintah untuk edit pada form Item
        private void btn_edit_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = "update tbl_barang set nama_barang= '"+textBox2.Text+"', expired= '"+textBox3.Text+"', jumlah_barang= '"+textBox4.Text+"', satuan= '"+textBox5.Text+"', harga= '"+textBox6.Text+"' where kd_barang ='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            tampilan_data_mhs();
            MessageBox.Show("Data Berhasil Di Update!");
        }

        //perintah untuk tombol cari pada form Item
        private void btn_search_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = "select * from tbl_barang where nama_barang = '" + textBox7.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            dgv_item.DataSource = dt;
            koneksi.Close();
            textBox7.Text = "";
        }

        //perintah logout
        private void keluar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login panggil = new Form_Login();
            panggil.Show();
            MessageBox.Show("Berhasil Logout!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Perintah pada form setting
        private void btn_update_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = "insert into tbl_login values ('"+ null +"', '"+user.Text+"', '"+pass.Text+"', '"+nama.Text+"', '"+alamat.Text+"')";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan");
            nama.Text = "";
            alamat.Text = "";
            user.Text = "";
            pass.Text = "";
        }

        //perintah untuk combobox di form transaksi
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            string query = "select * from tbl_barang";
            Umum.Set_ComboBox(query, "nama_barang", pilih);
        }

        string pindah_harga(Object pilih_barang)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("select harga from tbl_barang where nama_barang = '"+pilih_barang+"'",koneksi);
            reader = cmd.ExecuteReader();
            reader.Read();
            string harga = reader[0].ToString();
            koneksi.Close();
            return harga;
        }

        //perintah untuk button reset
        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            dgv_transaksi.Columns.Clear();

            dgv_transaksi.ColumnCount = 4;
            dgv_transaksi.Columns[0].Name = "nama barang";
            dgv_transaksi.Columns[1].Name = "jumlah";
            dgv_transaksi.Columns[2].Name = "harga";
            dgv_transaksi.Columns[3].Name = "Total";

            dgv_transaksi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_transaksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_transaksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_transaksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        //untuk menampilkan hasil transaksi
        void hasiltransaksi(string harga, object pilih_barang, object jumlah) 
        {
            koneksi.Open();
            for (int i = 0; i < dgv_transaksi.Rows.Count; i++)
            {
                SqlCommand cmd = koneksi.CreateCommand();
                cmd = new SqlCommand("INSERT INTO tbl_transaksi (pilih_barang, jumlah, harga, total) VALUES ('" + dgv_transaksi.Rows[i].Cells[0].Value + "', '" + dgv_transaksi.Rows[i].Cells[1].Value + "', " + dgv_transaksi.Rows[i].Cells[2].Value + "," + dgv_transaksi.Rows[i].Cells[3].Value + ")", koneksi);
                cmd.ExecuteNonQuery();
            }
        }

        //perintah untuk tambah pada transaksi
        private void btn_tambah2_Click(object sender, EventArgs e)
        {
            string harga = pindah_harga(pilih.SelectedItem);

            int hrg, jml, tot;
            hrg = int.Parse(harga);
            jml = int.Parse(quanti.Text);
            tot = hrg * jml;

            dgv_transaksi.Rows.Add(pilih.SelectedItem, quanti.Text, harga, tot);
            dgv_transaksi.AllowUserToAddRows = false;

            int sum = 0;
            for (int i = 0; i < dgv_transaksi.Rows.Count; i++)
            {
                sum = sum + int.Parse(dgv_transaksi.Rows[i].Cells[3].Value.ToString());
            }
            lbl_total.Text = sum.ToString();

            pilih.Text = "";
            quanti.Text = "";
        }

        //perintah untuk bayar pada transaksi
        private void btn_bayar_Click(object sender, EventArgs e)
        {
            string harga = pindah_harga(pilih.SelectedItem);
            hasiltransaksi(harga, pilih.SelectedItem, quanti.Text);
            MessageBox.Show("terima kasih");
            pilih.Text = "";
            quanti.Text = "";

        }

        //perintah untuk menambahkan data perbaris pada datagridview
        private void addRow(string nama, string jumlah, string harga, string total)
        {
            String[] row = { nama, jumlah, harga, total };
            dgv_transaksi.Rows.Add(row);
        }

        //perintah untuk menampilkan uang kembali
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int bil1, bil2, hasil;
            bil1 = int.Parse(textBox10.Text);
            bil2 = int.Parse(lbl_total.Text);
            hasil = bil1 - bil2;
            label16.Text = hasil.ToString();
        }
    }
}