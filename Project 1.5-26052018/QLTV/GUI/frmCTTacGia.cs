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
    public partial class frmCTTacGia : DevExpress.XtraEditors.XtraForm
    {
        private DataGridView dgv = new DataGridView();

        public frmCTTacGia()
        {
            InitializeComponent();
            this.Controls.Add(this.dgv);
        }

        private void frmCTTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.CT_TACGIA' table. You can move, or remove it, as needed.
            this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
            label5.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();

            //cbb_IDDauSach -> Tên sách. cần đưa về định dạng ID
            ADO.ConnectionSQL.autoSach(cbb_IDDauSach, "Select TenDauSach from DAUSACH");

            //cbb_IDTacGia-> tên tác giả, cần đưa về dạng ID

            ADO.ConnectionSQL.autoSach(cbb_IDTacGia, "Select TenTacGia from TACGIA");

            this.dgv.VirtualMode = true;
            dgv.Columns.Add("IDCTTacGia", "ID chi tiết tác giả");
            dgv.Columns[0].DataPropertyName = "IDCTTacGia";
            dgv.Columns.Add("IDDauSach", "ID đầu sách");
            dgv.Columns[1].DataPropertyName = "IDDauSach";
            dgv.Columns.Add("TenDauSach", "Tên đầu sách");
            dgv.Columns[2].DataPropertyName = "TenDauSach";
            dgv.Columns.Add("IDTacGia", "ID tác giả");
            dgv.Columns[3].DataPropertyName = "IDTacGia";
            dgv.Columns.Add("TenTacGia", "Tên tác giả");
            dgv.Columns[4].DataPropertyName = "TenTacGia";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTacGia.Instance.checkCTTacGia(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
            SCRIPT.formatCTTacGia.Instance.checkNull(tb_IDCTTacGia, cbb_IDDauSach, cbb_IDTacGia);
            if (tb_IDCTTacGia.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDTacGia.Text != "")
            {
                ADO.adoCTTacGia.Instance.Them(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatCTTacGia.Instance.checkCTTacGia(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
            SCRIPT.formatCTTacGia.Instance.checkNull(tb_IDCTTacGia, cbb_IDDauSach, cbb_IDTacGia);

            if (tb_IDCTTacGia.Text != "" && cbb_IDDauSach.Text != "" && cbb_IDTacGia.Text != "")
            {
                ADO.adoCTTacGia.Instance.Sua(tb_IDCTTacGia.Text, cbb_IDDauSach.Text, cbb_IDTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDCTTacGia.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDCTTacGia.Text != "")
            {
                ADO.adoCTTacGia.Instance.Xoa(tb_IDCTTacGia.Text);
                this.cT_TACGIATableAdapter.Fill(this.quanLyThuVienDataSet.CT_TACGIA);
                ResetForm();
            }
        }



        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.cT_TACGIATableAdapter.Fill(quanLyThuVienDataSet.CT_TACGIA);
            ResetForm();
        }

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_IDCTTacGia.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            cbb_IDDauSach.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            cbb_IDTacGia.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
        }

        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);

        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDCTTacGia_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoCTTacGia.Instance.checkID(tb_IDCTTacGia.Text.Trim()), label5, tb_IDCTTacGia, pic_Warning, pic_Ss);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string idcttg = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string idds = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string idtg = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            ADO.adoCTTacGia.Instance.Sua(idcttg, idds, idtg);
            dataGridView1.DataSource = quanLyThuVienDataSet.CT_TACGIA;
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                sfd.Title = "Save an Excel File";
                sfd.ShowDialog();

                string DuongDan;
                DuongDan = sfd.FileName;

                string sql = ADO.adoCTTacGia.Instance.GetQueryFillDgv();
                ADO.adoAdmin.Instance.XuatExcel(ref dgv, sql, DuongDan);
            }
        }
    }
}