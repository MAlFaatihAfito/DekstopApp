using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan2
{
    internal class Umum
    {
        static SqlConnection conn;
        static SqlDataReader myreader;
        
        //isi ComboBox
        public static void Set_ComboBox(string Query, string row, ComboBox box)
        {
            try
            {
                conn = koneksi.Conn;
                conn.Open();
                SqlCommand comm = new SqlCommand(Query, conn);

                myreader = comm.ExecuteReader();
                box.Items.Clear();
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        box.Items.Add(myreader[row]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(myreader != null)
                    myreader.Close();
                conn.Close();
            }
        }
    }
}
