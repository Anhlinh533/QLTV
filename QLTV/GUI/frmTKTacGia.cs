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
    }
}