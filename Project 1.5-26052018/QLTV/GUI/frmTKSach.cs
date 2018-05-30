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
        private string UserName;
        private string Password;
        public frmTKSach(string userName, string password) : this()
        {
            UserName = userName;
            Password = password;
        }
        private void frmTKSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Fill(this.quanLyThuVienDataSet.CUONSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);
            if (ADO.adoLogin.Instance.checkDocGia(UserName, Password) == true)
            {
                btn_Luu.Enabled = false;
                btn_Sua.Enabled = false;
                //toolStripLabel1.Enabled = false;
                //toolStripLabel5.Enabled = false;
                //toolStripLabel2.Enabled = false;
                btn_Xoa.Enabled = false;
                toolStripLabel6.Enabled = false;
                toolStripLabel7.Enabled = false;
                toolStripLabel8.Enabled = false;
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
            }
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
            else
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
            if(rdb_IDCuonSach.Checked==true &&tb_IDCuonSach.Text!="")
            {
                dgv_TKCuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKCuonSach(tb_IDCuonSach.Text));
                ResetForm();
            }
            else
                if(rdb_IDSachCS.Checked==true && tb_IDSachCS.Text!="")
            {
                dgv_TKCuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKIDSachCS(tb_IDSachCS.Text));
                ResetForm();
            }
            else
                    if(rdb_TinhTrang.Checked==true && cbb_TinhTrang.Text!="")
            {
                dgv_TKCuonSach.DataSource = ADO.ConnectionSQL.Instance.ExecuteQuery(ADO.adoSach.Instance.TKTinhTrang(cbb_TinhTrang.Text));
                ResetForm();
            }
        }
        #region Form
        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl3);
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
        #region check on click
        private void tb_IDSach_Click(object sender, EventArgs e)
        {
            rdb_IDSach.Checked = true;

        }

        private void tb_IDDauSach_Click(object sender, EventArgs e)
        {
            rdb_IDDauSach.Checked = true;


        }

        private void tb_NhaXuatBan_Click(object sender, EventArgs e)
        {
            rdb_NhaXuatBan.Checked = true;


        }

        private void tb_NamXuatBan_Click(object sender, EventArgs e)
        {
            rdb_NamXuatBan.Checked = true;


        }

        private void tb_SoLuongTon_Click(object sender, EventArgs e)
        {
            rdb_SoLuongTon.Checked = true;


        }

        private void tb_GiaTien_Click(object sender, EventArgs e)
        {
            rdb_GiaTien.Checked = true;


        }

        private void tb_IDCuonSach_Click(object sender, EventArgs e)
        {
            rdb_IDCuonSach.Checked = true;


        }

        private void tb_IDSachCS_Click(object sender, EventArgs e)
        {
            rdb_IDSachCS.Checked = true;

        }

        private void cbb_TinhTrang_Click(object sender, EventArgs e)
        {
            rdb_TinhTrang.Checked = true;

        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dgv_TKCuonSach.DataSource = quanLyThuVienDataSet.CUONSACH;
            dgv_TKSach.DataSource = quanLyThuVienDataSet.SACH;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}