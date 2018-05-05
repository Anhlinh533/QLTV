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
    public partial class frmDauSach : DevExpress.XtraEditors.XtraForm
    {
        public frmDauSach()
        {
            InitializeComponent();
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.LOAISACH' table. You can move, or remove it, as needed.
            this.lOAISACHTableAdapter.Fill(this.quanLyThuVienDataSet.LOAISACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SCRIPT.formatDauSach.Instance.checkDauSach(tb_IDDauSach.Text, tb_TenDauSach.Text, cbb_IDTheLoaiSach.Text);
            if (tb_IDDauSach.Text != "" && tb_TenDauSach.Text != "" && cbb_IDTheLoaiSach.Text != "")
            {
                ADO.adoDauSach.Instance.Them(tb_IDDauSach.Text, tb_TenDauSach.Text, cbb_IDTheLoaiSach.Text);
                this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }        

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}