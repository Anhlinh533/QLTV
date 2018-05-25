using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTV.GUI
{
    public partial class frmTKTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTKTacGia()
        {
            InitializeComponent();
        }

        private void frmTKTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_TACGIA' table. You can move, or remove it, as needed.
            this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            if (ADO.adoLogin.Instance.checkDocGia(UserName, Password) == true)
            {
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = false;
                toolStripLabel1.Enabled = false;
                toolStripLabel5.Enabled = false;
                toolStripLabel2.Enabled = false;
                btn_Xoa.Enabled = false;
                toolStripLabel6.Enabled = false;
                toolStripLabel7.Enabled = false;
                toolStripLabel8.Enabled = false;
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
            }
        }
        private string UserName;
        private string Password;
        public frmTKTacGia(string userName, string password) : this()
        {
            UserName = userName;
            Password = password;
        }
        private void btn_TKTacGia_Click(object sender, EventArgs e)
        {
            if(rdb_IDTacGia.Checked==true && tb_IDTacGia.Text!="")
            {
                dgv_TKTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTacGia.Instance.TKIDTacGia(tb_IDTacGia.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NgaySinh.Checked==true && dtp_NgaySinh.Text!="")
            {
                dgv_TKTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTacGia.Instance.TKNgaySinh(dtp_NgaySinh.Text.Trim()));
                ResetForm();
            }
            else if(rdb_TenTacGia.Checked==true && tb_TenTacGia.Text!="")
            {
                dgv_TKTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTacGia.Instance.TKTenTacGia(tb_TenTacGia.Text.Trim()));
                ResetForm();
            }

            if (rdb_IDTacGia.Checked == true && tb_IDTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID tác giả cần tìm!!");
                tb_IDTacGia.Focus();
            }
            else if (rdb_TenTacGia.Checked == true && tb_TenTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên tác giả cần tìm!!");
                tb_TenTacGia.Focus();
            }

        }

        private void btn_TKCTTacGia_Click(object sender, EventArgs e)
        {
            if(rdb_IDCTTacGia.Checked==true && tb_IDCTTacGia.Text!="")
            {
                dgv_TKCTTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTacGia.Instance.TKIDCTTacGia(tb_IDCTTacGia.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDDauSach.Checked==true && tb_IDDauSach.Text!="")
            {
                dgv_TKCTTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTacGia.Instance.TKIDDauSach(tb_IDDauSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDTacGiaCT.Checked==true && tb_IDTacGiaCT.Text!="")
            {
                dgv_TKCTTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTacGia.Instance.TKIDTacGia(tb_IDTacGiaCT.Text.Trim()));
                ResetForm();
            }

            if (rdb_IDCTTacGia.Checked == true && tb_IDCTTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID chi tiết tác giả cần tìm!!");
                tb_IDCTTacGia.Focus();
            }
            else if (rdb_IDDauSach.Checked == true && tb_IDDauSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID đầu sách cần tìm!!");
                tb_IDDauSach.Focus();
            }
            else if (rdb_IDTacGiaCT.Checked == true && tb_IDTacGiaCT.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID tác giả cần tìm!!");
                tb_IDTacGiaCT.Focus();
            }

        }
        #region Form
        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }
        #endregion
        #region check on click
        private void tb_IDTacGia_Click(object sender, EventArgs e)
        {
            rdb_IDTacGia.Checked = true;
        }

        private void tb_TenTacGia_Click(object sender, EventArgs e)
        {
            rdb_TenTacGia.Checked = true;
        }

        private void tb_IDCTTacGia_Click(object sender, EventArgs e)
        {
            rdb_IDCTTacGia.Checked = true;
        }

        private void tb_IDDauSach_Click(object sender, EventArgs e)
        {
            rdb_IDDauSach.Checked = true;
        }

        private void tb_IDTacGiaCT_Click(object sender, EventArgs e)
        {
            rdb_IDTacGiaCT.Checked = true;
        }
        #endregion
    }
}