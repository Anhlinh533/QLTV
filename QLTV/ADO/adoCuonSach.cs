using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCuonSach
    {
        private static adoCuonSach instance;

        internal static adoCuonSach Instance
        {
            get
            {
                if (instance == null) instance = new adoCuonSach(); return ADO.adoCuonSach.instance;
            }

            private set
            {
                ADO.adoCuonSach.instance = value;
            }
        }

        public void Them(string tb_IDCuonSach, string cbb_IDSach, string cbb_TinhTrang)
        {
            SCRIPT.formatCuonSach.Instance.returnIDCuonSach(ref tb_IDCuonSach);
            string sqlInsert = "INSERT INTO CUONSACH VALUES ('" + tb_IDCuonSach + "','" + cbb_IDSach + "',N'" + cbb_TinhTrang + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDCuonSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CUONSACH WHERE IDCuonSach ='" + tb_IDCuonSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCuonSach, string cbb_IDSach, string cbb_TinhTrang)
        {
            SCRIPT.formatCuonSach.Instance.returnIDCuonSach(ref tb_IDCuonSach);
            string sqlUpdate = "UPDATE CUONSACH SET IDSach = '" + cbb_IDSach + "', TinhTrang = N'" + cbb_TinhTrang +"' WHERE IDCuonSach = '" + tb_IDCuonSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
