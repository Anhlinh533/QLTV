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

            if (rdb_GiaTien.Checked == true && tb_GiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng điền giá tiền cần tìm!!");
                tb_GiaTien.Focus();
            }
            else if (rdb_IDDauSach.Checked == true && tb_IDDauSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID đầu sách cần tìm!!");
                tb_IDDauSach.Focus();
            }
            else if (rdb_IDSach.Checked == true && tb_IDSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID sách cần tìm!!");
                tb_IDSach.Focus();
            }
            else if (rdb_NhaXuatBan.Checked == true && tb_NhaXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng điền nhà xuất bản cần tìm!!");
                tb_NhaXuatBan.Focus();
            }
            else if (rdb_NamXuatBan.Checked == true && tb_NamXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng điền năm xuất bản cần tìm!!");
                tb_NamXuatBan.Focus();
            }
            else if (rdb_SoLuongTon.Checked == true && tb_SoLuongTon.Text == "")
            {
                MessageBox.Show("Vui lòng điền số lượng tồn cần tìm!!");
                tb_SoLuongTon.Focus();
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

            if (rdb_IDCuonSach.Checked == true && tb_IDCuonSach.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID cuốn sách cần tìm!!");
                tb_IDCuonSach.Focus();
            }
            else if (rdb_IDSachCS.Checked == true && tb_IDSachCS.Text == "")
            {
                MessageBox.Show("Vui lòng điền ID sách cần tìm !!");
                tb_IDSachCS.Focus();
            }
            else if (rdb_TinhTrang.Checked == true && cbb_TinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tình trạng cần tìm!!");
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
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void chu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }
        #endregion

    }
}