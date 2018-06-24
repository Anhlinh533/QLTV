using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLTV.SCRIPT
{
    class formatCTTacGia
    {
        private static formatCTTacGia instance;

        internal static formatCTTacGia Instance
        {
            get
            {
                if (instance == null) instance = new formatCTTacGia(); return SCRIPT.formatCTTacGia.instance;
            }

            private set
            {
                SCRIPT.formatCTTacGia.instance = value;
            }
        }

        public void returnIDCTTacGia(ref string id)
        {
            id = "CTG" + id;            
        }

        public void checkCTTacGia(string IDChiTietTacGia, string IDDauSach, string IDTacGia)
        {
            if (IDChiTietTacGia == "") MessageBox.Show("Không được để trống ID chi tiết tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDDauSach == "") MessageBox.Show("Không được để trống tên sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDTacGia == "") MessageBox.Show("Không được để trống tên tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void checkNull(Control IDCTTacGia,Control IDDauSach,Control IDTacGia)
        {
            if (useForm.Instance.checkNull(IDCTTacGia) == true) useForm.Instance.Focus(IDCTTacGia);
            else if (useForm.Instance.checkNull(IDDauSach) == true) useForm.Instance.Focus(IDDauSach);
            else if (useForm.Instance.checkNull(IDTacGia) == true) useForm.Instance.Focus(IDTacGia);
        }
    }
}
