﻿using System;
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
    public partial class frmLoaiSach : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
            label4.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatLoaiSach.Instance.checkLoaiSach(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
            SCRIPT.formatLoaiSach.Instance.checkNull(tb_IDLoaiSach, tb_TenLoaiSach);
            if (tb_IDLoaiSach.Text != "" && tb_TenLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Them(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatLoaiSach.Instance.checkLoaiSach(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
            SCRIPT.formatLoaiSach.Instance.checkNull(tb_IDLoaiSach, tb_TenLoaiSach);

            if (tb_IDLoaiSach.Text != "" && tb_TenLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Sua(tb_IDLoaiSach.Text, tb_TenLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDLoaiSach.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDLoaiSach.Text != "")
            {
                ADO.adoLoaiSach.Instance.Xoa(tb_IDLoaiSach.Text);
                this.lOAISACHTableAdapter.Fill(quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
            ResetForm();
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoLoaiSach.Instance.Xoa(cbb_IDDelete.Text);
                this.lOAISACHTableAdapter.Fill(quanLyThuVienDataSet.LOAISACH);
                ResetForm();
            }
        }

        #region Form
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_Them_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tb_IDLoaiSach.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            tb_TenLoaiSach.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
        }

        public void ResetForm()
        {
            SCRIPT.useForm.ResetAllControls(groupControl1);
            SCRIPT.useForm.ResetAllControls(groupControl2);
            SCRIPT.useForm.ResetAllControls(groupControl3);
            SCRIPT.useForm.ResetAllControls(groupControl4);
        }

        private void chu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_IDLoaiSach_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoLoaiSach.Instance.checkID(tb_IDLoaiSach.Text.Trim()), label4, tb_IDLoaiSach, pic_Warning, pic_Ss);

        }
    }
}