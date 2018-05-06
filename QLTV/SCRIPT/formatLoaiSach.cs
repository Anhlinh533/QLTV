using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatLoaiSach
    {
        private static formatLoaiSach instance;

        internal static formatLoaiSach Instance
        {
            get
            {
                if (instance == null) instance = new formatLoaiSach(); return SCRIPT.formatLoaiSach.instance;
            }

            private set
            {
                SCRIPT.formatLoaiSach.instance = value;
            }

        }
        public void returnIDLoaiSach(ref string id)
        {
            id = "LSA" + id;
        }
        public void checkLoaiSach(string IDLoaiSach, string TenLoaiSach)
        {
            if(IDLoaiSach=="") MessageBox.Show("Không được để trống ID loại sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(TenLoaiSach=="") MessageBox.Show("Không được để trống tên loại sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
