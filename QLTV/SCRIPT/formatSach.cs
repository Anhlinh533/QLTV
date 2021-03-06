﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatSach
    {
        private static formatSach instance;

        internal static formatSach Instance
        {
            get
            {
                if (instance == null) instance = new formatSach(); return SCRIPT.formatSach.instance;
            }

            private set
            {
                SCRIPT.formatSach.instance = value;
            }
        }

        public void returnIDSach(ref string id)
        {
            id = "ISA" + id;
        }

        public void checkSach(string IDSach, string IDDauSach, string IDCTTacGia, string NhaXuatBan, string NamXuatBan, string SoLuongTon, string GiaTien)
        {
            if (IDSach == "") MessageBox.Show("Không được để trống ID sách", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDDauSach == "") MessageBox.Show("Không được để trống ID đầu sách", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDCTTacGia == "") MessageBox.Show("Không được để trống ID chi tiết tác giả", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NhaXuatBan == "") MessageBox.Show("Không được để trống nhà xuất bản", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (NamXuatBan == "") MessageBox.Show("Không được để trống năm xuất bản", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (SoLuongTon == "") MessageBox.Show("Không được để trống số lượng tồn", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (GiaTien == "") MessageBox.Show("Không được để trống giá tiền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void checkNull(Control IDSach, Control IDDauSach, Control IDCTTacGia, Control NhaXuatBan, Control NamXuatBan, Control SoLuongTon, Control GiaTien)
        {
            if (useForm.Instance.checkNull(IDSach) == true) useForm.Instance.Focus(IDSach);
            else if (useForm.Instance.checkNull(IDDauSach) == true) useForm.Instance.Focus(IDDauSach);
            else if (useForm.Instance.checkNull(IDCTTacGia) == true) useForm.Instance.Focus(IDCTTacGia);
            else if (useForm.Instance.checkNull(NhaXuatBan) == true) useForm.Instance.Focus(NhaXuatBan);
            else if (useForm.Instance.checkNull(NamXuatBan) == true) useForm.Instance.Focus(NamXuatBan);
            else if (useForm.Instance.checkNull(SoLuongTon) == true) useForm.Instance.Focus(SoLuongTon);
            else if (useForm.Instance.checkNull(GiaTien) == true) useForm.Instance.Focus(GiaTien);

        }
    }
}
