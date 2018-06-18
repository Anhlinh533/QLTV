using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using DevComponents.DotNetBar;
using QLTV.ADO;

namespace QLTV
{
    public partial class frmConnection : DevExpress.XtraEditors.XtraForm
    {
        string str;
        public frmConnection()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = false;
            cmbAuthentication.Enabled = false;
            //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //DataTable table = instance.GetDataSources();
            //txtServer.DataSource = table;
            //txtServer.DisplayMember = "ServerName";
            cmbAuthentication.SelectedIndex = 0;

        }
        #region Click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbDatabase.Text.Length == 0)
            {
                MessageBoxEx.Show("Bạn chưa chọn CSDL ! ");
            }
            else
            {
                if (cmbAuthentication.SelectedIndex == 0)
                {
                    XML.XMLWriter("Connection.xml", txtServer.Text, cmbDatabase.Text, "true");
                }
                else
                    XML.XMLWriter("Connection.xml", txtServer.Text, txtUsername.Text, txtPassword.Text, cmbDatabase.Text, "false");
                this.DialogResult = DialogResult.OK;
            }
            //Application.Exit();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cmbAuthentication.SelectedIndex == 0)
            {
                cmbDatabase.Items.Clear();
                str = "Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;";
                SqlConnection m_Conn = new SqlConnection(str);
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //QLHS.Properties.Settings.Default.str = str;
                    //QLHS.Properties.Settings.Default.Save();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cmbAuthentication.SelectedIndex == 1)
            {
                cmbDatabase.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }
        #endregion

        #region SelectedIndexChanged event
        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
        #endregion

        private void frmConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            if (txtServer.Text.Length == 0)
            {
                cmbAuthentication.Enabled = false;
                btnTestConnection.Enabled = false;

            }
            else
            {
                cmbAuthentication.Enabled = true;
                btnTestConnection.Enabled = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
