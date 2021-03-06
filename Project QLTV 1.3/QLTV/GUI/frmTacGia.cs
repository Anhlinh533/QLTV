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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            label5.Hide();
            pic_Ss.Hide();
            pic_Warning.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTacGia.Instance.checkTacGia(tb_IDTacGia.Text, tb_TenTacGia.Text, dtp_NgaySinh.Text);
            SCRIPT.formatTacGia.Instance.checkNull(tb_IDTacGia, tb_TenTacGia);
            if (tb_IDTacGia.Text != "" && tb_TenTacGia.Text != "" && dtp_NgaySinh.Text != "")
            {
                ADO.adoTacGia.Instance.Them(tb_IDTacGia.Text, tb_TenTacGia.Text, dtp_NgaySinh.Text);
                this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
                ResetForm();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SCRIPT.formatTacGia.Instance.checkTacGia(tb_IDTacGia.Text, tb_TenTacGia.Text, dtp_NgaySinh.Text);
            SCRIPT.formatTacGia.Instance.checkNull(tb_IDTacGia, tb_TenTacGia);

            if (tb_IDTacGia.Text != "" && tb_TenTacGia.Text != "" && dtp_NgaySinh.Text != "")
            {
                ADO.adoTacGia.Instance.Sua(tb_IDTacGia.Text, tb_TenTacGia.Text, dtp_NgaySinh.Text);
                this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
                ResetForm();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_IDTacGia.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (tb_IDTacGia.Text != "")
            {
                ADO.adoTacGia.Instance.Xoa(tb_IDTacGia.Text);
                this.tACGIATableAdapter.Fill(quanLyThuVienDataSet.TACGIA);
                ResetForm();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.tACGIATableAdapter.Fill(this.quanLyThuVienDataSet.TACGIA);
            ResetForm();
        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {
            if (cbb_IDDelete.Text == "") MessageBox.Show("Vui lòng chọn ID cần xóa.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cbb_IDDelete.Text != "")
            {
                ADO.adoTacGia.Instance.Xoa(cbb_IDDelete.Text);
                this.tACGIATableAdapter.Fill(quanLyThuVienDataSet.TACGIA);
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
            tb_IDTacGia.Text = dgv_Them.Rows[numrow].Cells[0].Value.ToString();
            tb_TenTacGia.Text = dgv_Them.Rows[numrow].Cells[1].Value.ToString();
            dtp_NgaySinh.Text = dgv_Them.Rows[numrow].Cells[2].Value.ToString();
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

        private void tb_IDTacGia_TextChanged(object sender, EventArgs e)
        {
            SCRIPT.useForm.Instance.checkID(ADO.adoTacGia.Instance.checkID(tb_IDTacGia.Text.Trim()), label5, tb_IDTacGia, pic_Warning, pic_Ss);

        }
    }
}