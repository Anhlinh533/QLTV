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
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DAUSACH' table. You can move, or remove it, as needed.
            this.dAUSACHTableAdapter.Fill(this.quanLyThuVienDataSet.DAUSACH);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.quanLyThuVienDataSet.SACH);

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

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_IDDelete_Click(object sender, EventArgs e)
        {

        }
    }
}