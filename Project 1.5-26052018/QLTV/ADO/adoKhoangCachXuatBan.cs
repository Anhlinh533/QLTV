using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoKhoangCachXuatBan
    {
        private static adoKhoangCachXuatBan instance;

        internal static adoKhoangCachXuatBan Instance
        {
            get
            {
                if (instance == null) instance = new adoKhoangCachXuatBan(); return ADO.adoKhoangCachXuatBan.instance;
            }

            private set
            {
                ADO.adoKhoangCachXuatBan.instance = value;
            }
        }

        public void Sua(string tb_KhoangCach)
        {
            string sqlUpdate = "UPDATE THAMSO SET KhoangCachXB = '" + tb_KhoangCach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
