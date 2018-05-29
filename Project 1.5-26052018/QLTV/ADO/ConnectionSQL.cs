using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;
using static QLTV.Utilities;

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
        #region checkConnection
        private static SqlConnection m_Connection;
        public static String m_ConnectString = "";

        #region Field
        #endregion
        private static XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
        private static XmlElement xmlEle = xmlDoc.DocumentElement;
        private ConnectionSQL() { }
        public static bool OpenConnection() // Hàm mở connection
        {
            if (m_ConnectString == "")
                ConnectionString();
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }

        public static void ConnectionString() // hàm lấy lệnh connection
        {
            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";

                }
                else
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                Utilities.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static String ConSTR()
        {
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;
            String connectionST = "";
            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    connectionST = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";

                }
                else
                {
                    connectionST = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                Utilities.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return connectionST;
        }


        #endregion
        public string dataSource = ConSTR();
        //#region SLQ
        //private ConnectionSQL() { }

        //private string connectionSTR = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        //Data Source=DESKTOP-5C45L67\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True
        //Data Source=DESKTOP-LUHFR97\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True

        //Thực hiện các câu lệnh Select
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(dataSource))
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

        public void InfoMessageHandler(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        public void Execute(string sql)
        {
            SqlConnection con = new SqlConnection(dataSource);

            con.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công!!", "Chú ý!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                //str = str.Substring(67);
                MessageBox.Show(str, "Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            con.Close();
        }

        public SqlDataAdapter ExcuteAdapter(string sql)
        {
            SqlConnection con = new SqlConnection(dataSource);

            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            return adp;
        }

        public int ExcuteInt(string sql)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                i = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                //str = str.Substring(67);
                MessageBox.Show(str, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
            return i;
        }

        public bool check(string sql)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read() == true)
            {
                return true;
            }
            return false;
        }

        public string readData(string sql,string tb,string name)
        {
            SqlConnection con = new SqlConnection(dataSource);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();
            //tb = dta.ToString();
            if (dta.Read())
            {
                tb = (dta[name].ToString());

                //tb = dta.GetValue(name).ToString();
                //tb = dta.GetString(name);
            }
            return tb;

            //OleDbConnection cn = new OleDbConnection(dataSource);

            //cn.Open();
            //OleDbCommand cmd = new OleDbCommand(sql, cn);
            //OleDbDataReader reader = cmd.ExecuteReader();

            //reader.Read();
            //tb = reader[name].ToString();
            //return tb;
        }

        public static void autoSach(TextBox tb, string sql)
        {
            string ConString = ConSTR();

            using (SqlConnection con = new SqlConnection(ConString))
            {
                tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                tb.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
        }
    }
}
