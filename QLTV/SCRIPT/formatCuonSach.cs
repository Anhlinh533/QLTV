using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class formatCuonSach
    {
        private static formatCuonSach instance;

        internal static formatCuonSach Instance
        {
            get
            {
                if (instance == null) instance = new formatCuonSach(); return SCRIPT.formatCuonSach.instance;
            }

            private set
            {
                SCRIPT.formatCuonSach.instance = value;
            }
        }
        public void returnIDCuonSach(ref string id)
        {
            id = "CSA" + id;
        }
        public void checkCuonSach(string IDCuonSach, string IDSach)
        {
            if (IDCuonSach == "") MessageBox.Show("Không được để trống ID cuốn sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (IDSach == "") MessageBox.Show("Không được để trống ID sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
        }
    }
}
