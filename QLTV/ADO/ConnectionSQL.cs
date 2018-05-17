using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class ConnectionSQL
    {
        private static ConnectionSQL instance;

        internal static ConnectionSQL Instance
        {
            get
            {
                if (instance == null) instance = new ConnectionSQL(); return ADO.ConnectionSQL.instance;
            }

            private set
            {
                ADO.ConnectionSQL.instance = value;
            }
        }

        //#region SLQ
        //private ConnectionSQL() { }

        //private string connectionSTR = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        //Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True
        //Data Source=DESKTOP-P6BNJRC\BAODUYSQL;Initial Catalog=QuanLyThuVien;Integrated Security=True

        //Thực hiện các câu lệnh Select
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P6BNJRC\BAODUYSQL;Initial Catalog=QuanLyThuVien;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        ////Liên quan đến số lượng
        //public int ExecuteNonQuery(string query, object[] parameter = null)
        //{
        //    int data = 0;

        //    using (SqlConnection connection = new SqlConnection(connectionSTR))
        //    {
        //        connection.Open();

        //        SqlCommand command = new SqlCommand(query, connection);

        //        if (parameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }

        //        data = command.ExecuteNonQuery();

        //        connection.Close();
        //    }

        //    return data;
        //}

        //public object ExecuteSchalar(string query, object[] parameter = null)
        //{

        //    object data = 0;
        //    using (SqlConnection connection = new SqlConnection(connectionSTR))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        if (parameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //        data = command.ExecuteScalar();
        //        connection.Close();

        //    }
        //    return data;
        //}
        //#endregion

        public void Execute(string sql)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6BNJRC\BAODUYSQL;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Chú ý");
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                //str = str.Substring(67);
                MessageBox.Show(str, "Chú ý");
            }

            con.Close();
        }
    }
}
