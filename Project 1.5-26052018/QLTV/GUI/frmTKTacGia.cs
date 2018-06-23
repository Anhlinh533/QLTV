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
                //toolStripLabel1.Enabled = false;
                //toolStripLabel5.Enabled = false;
                //toolStripLabel2.Enabled = false;
                btn_Xoa.Enabled = false;
                //toolStripLabel6.Enabled = false;
                //toolStripLabel7.Enabled = false;
                //toolStripLabel8.Enabled = false;
                //toolStripButton1.Enabled = false;
                //toolStripButton2.Enabled = false;
                //toolStripButton3.Enabled = false;
            }

            //dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            //dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
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
            try
            {
                if (rdb_IDTacGia.Checked == true && tb_IDTacGia.Text != "")
                {
                    dgv_TKTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTacGia.Instance.TKIDTacGia(tb_IDTacGia.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_NgaySinh.Checked == true && dtp_NgaySinh.Text != "")
                {
                    dgv_TKTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTacGia.Instance.TKNgaySinh(dtp_NgaySinh.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_TenTacGia.Checked == true && tb_TenTacGia.Text != "")
                {
                    dgv_TKTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoTacGia.Instance.TKTenTacGia(tb_TenTacGia.Text.Trim()));
                    //ResetForm();
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
            catch { }
        }

        private void btn_TKCTTacGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_IDCTTacGia.Checked == true && tb_IDCTTacGia.Text != "")
                {
                    dgv_TKCTTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTacGia.Instance.TKIDCTTacGia(tb_IDCTTacGia.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_IDDauSach.Checked == true && tb_IDDauSach.Text != "")
                {
                    dgv_TKCTTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTacGia.Instance.TKIDDauSach(tb_IDDauSach.Text.Trim()));
                    //ResetForm();
                }
                else if (rdb_IDTacGiaCT.Checked == true && tb_IDTacGiaCT.Text != "")
                {
                    dgv_TKCTTacGia.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCTTacGia.Instance.TKIDTacGia(tb_IDTacGiaCT.Text.Trim()));
                    //ResetForm();
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
            catch { }
        }

        #region Form
        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl3);
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

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_TKCTTacGia.DataSource = quanLyThuVienDataSet.CT_TACGIA;
                dgv_TKTacGia.DataSource = quanLyThuVienDataSet.TACGIA;

                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            }
            catch { }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string idtg = dgv_TKTacGia.Rows[t].Cells[0].Value.ToString();
                string tentg = dgv_TKTacGia.Rows[t].Cells[1].Value.ToString();
                string ngaysinh = dgv_TKTacGia.Rows[t].Cells[2].Value.ToString();

                ADO.adoTacGia.Instance.Sua(idtg, tentg, ngaysinh);
            }
            catch { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string idtg = dgv_TKTacGia.CurrentRow.Cells[0].Value.ToString();
                ADO.adoTacGia.Instance.Xoa(idtg);
                dgv_TKTacGia.DataSource = quanLyThuVienDataSet.TACGIA;
            }
            catch { }
        }

        private void btn_LuuCTTG_Click(object sender, EventArgs e)
        {
            try
            {
                string idcttg = dgv_TKCTTacGia.Rows[t].Cells[0].Value.ToString();
                string idds = dgv_TKCTTacGia.Rows[t].Cells[1].Value.ToString();
                string idtg = dgv_TKCTTacGia.Rows[t].Cells[2].Value.ToString();

                ADO.adoCTTacGia.Instance.Sua(idcttg, idds, idtg);
            }
            catch { }
        }

        private void btn_XoaCTTG_Click(object sender, EventArgs e)
        {
            try
            {
                string idcttg = dgv_TKCTTacGia.CurrentRow.Cells[0].Value.ToString();
                ADO.adoCTTacGia.Instance.Xoa(idcttg);
                dgv_TKCTTacGia.DataSource = quanLyThuVienDataSet.CT_TACGIA;
            }
            catch { }
        }

        int t = 0;

        private void dgv_TKTacGia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_TKTacGia.CurrentCell != null)
                    t = dgv_TKTacGia.CurrentCell.RowIndex;
            }
            catch { }
        }

        private void dgv_TKCTTacGia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_TKCTTacGia.CurrentCell != null)
                    t = dgv_TKCTTacGia.CurrentCell.RowIndex;
            }
            catch { }
        }
    }
}