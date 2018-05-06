using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatDauSach
    {
        private static formatDauSach instance;

        internal static formatDauSach Instance
        {
            get
            {
                if (instance == null) instance = new formatDauSach(); return SCRIPT.formatDauSach.instance;
            }

            private set
            {
                SCRIPT.formatDauSach.instance = value;
            }
        }

        public void returnIDDauSach(ref string id)
        {
            id = "DSA" + id;
        }

        public void checkDauSach(string IDDauSach, string TenDauSach,string IDTheLoaiSach)
        {
            if (IDDauSach=="") MessageBox.Show("Không được để trống ID đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(TenDauSach=="") MessageBox.Show("Không được để trống tên đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IDTheLoaiSach=="") MessageBox.Show("Không được để trống ID thể loại sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
