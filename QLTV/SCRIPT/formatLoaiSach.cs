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
        public string returnIDLoaiSach(string id)
        {
            string IDDocGia;
            IDDocGia = "LSA" + id;
            return IDDocGia;
        }
    }
}
