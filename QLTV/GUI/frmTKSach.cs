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
    public partial class frmTKSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTKSach()
        {
            InitializeComponent();
        }

        private void frmTKSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);

        }

        private void btn_TKSach_Click(object sender, EventArgs e)
        {
            if(rdb_GiaTien.Checked==true && tb_GiaTien.Text!="")
            {
                dgv_TKSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKGiaTien(tb_GiaTien.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDDauSach.Checked==true && tb_IDDauSach.Text!="")
            {
                dgv_TKSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKIDDauSach(tb_IDDauSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDSach.Checked==true && tb_IDSach.Text!="")
            {
                dgv_TKSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKIDSach(tb_IDSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NamXuatBan.Checked==true && tb_NamXuatBan.Text!="")
            {
                dgv_TKSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKNamXB(tb_NamXuatBan.Text.Trim()));
                ResetForm();
            }
            else if(rdb_NhaXuatBan.Checked==true && tb_NhaXuatBan.Text!="")
            {
                dgv_TKSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKNhaXB(tb_NhaXuatBan.Text.Trim()));
                ResetForm();
            }
            else if(rdb_SoLuongTon.Checked==true && tb_SoLuongTon.Text!="")
            {
                dgv_TKSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKSoLuongTon(tb_SoLuongTon.Text.Trim()));
                ResetForm();
            }
        }

        private void btn_TKCuonSach_Click(object sender, EventArgs e)
        {
            if(rdb_IDCuonSach.Checked==true && tb_IDCuonSach.Text!="")
            {
                dgv_TKCuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCuonSach.Instance.TKIDCuonSach(tb_IDCuonSach.Text.Trim()));
                ResetForm();
            }
            else if(rdb_IDSachCS.Checked==true && tb_IDSachCS.Text!="")
            {
                dgv_TKCuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCuonSach.Instance.TKIDSach(tb_IDSachCS.Text.Trim()));
                ResetForm();
            }
            else if(rdb_TinhTrang.Checked==true && cbb_TinhTrang.Text!="")
            {
                dgv_TKCuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoCuonSach.Instance.TKTinhTrang(cbb_TinhTrang.Text.Trim()));
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