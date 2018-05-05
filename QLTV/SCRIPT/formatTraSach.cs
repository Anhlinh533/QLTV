using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatTraSach
    {
        private static formatTraSach instance;

        internal static formatTraSach Instance
        {
            get
            {
                if (instance == null) instance = new formatTraSach(); return SCRIPT.formatTraSach.instance;
            }

            private set
            {
                SCRIPT.formatTraSach.instance = value;
            }
        }

        public void returnIDPhieuTra(ref string id)
        {
            id = "IPT" + id;
        }
        public void checkTraSach(string IDPhieuTra,string IDDocGia,string NgayTra,string TienPhatKiNay, string SoTienTra,string TienNoKiNay)
        {
             if(IDPhieuTra=="") MessageBox.Show("Không được để trống ID phiếu trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             else if (IDDocGia == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             else if (NgayTra == "") MessageBox.Show("Không được để trống ngày trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             else if (TienPhatKiNay == "") MessageBox.Show("Không được để trống tiền phạt kì này.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             else if (SoTienTra == "") MessageBox.Show("Không được để trống số tiền trả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             else if (TienNoKiNay == "") MessageBox.Show("Không được để trống tiền nợ kì này.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
