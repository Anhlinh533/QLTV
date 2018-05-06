using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatTacGia
    {
        private static formatTacGia instance;

        internal static formatTacGia Instance
        {
            get
            {
                if (instance == null) instance = new formatTacGia(); return SCRIPT.formatTacGia.instance;
            }

            private set
            {
                SCRIPT.formatTacGia.instance = value;
            }
        }

        public void returnIDTacGia(ref string id)
        {
            id = "ITG" + id;
        }
        public void checkTacGia(string IDTacGia, string TenTacGia,string NgaySinh)
        {
            if(IDTacGia=="") MessageBox.Show("Không được để trống ID tác giả", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(TenTacGia=="") MessageBox.Show("Không được để trống tên tác giả", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(NgaySinh=="") MessageBox.Show("Không được để trống ngày sinh", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
