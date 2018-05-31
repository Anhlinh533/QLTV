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
        #region Insert

        public void Them(string tb_IDCuonSach, string cbb_IDSach)
        {
            SCRIPT.formatCuonSach.Instance.returnIDCuonSach(ref tb_IDCuonSach);
            string sqlInsert = "INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('" + tb_IDCuonSach + "','" + cbb_IDSach + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDCuonSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CUONSACH WHERE IDCuonSach ='" + tb_IDCuonSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCuonSach, string cbb_IDSach)
        {
            //SCRIPT.formatCuonSach.Instance.returnIDCuonSach(ref tb_IDCuonSach);
            string sqlUpdate = "UPDATE CUONSACH SET IDSach = '" + cbb_IDSach + "' WHERE IDCuonSach = '" + tb_IDCuonSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        #region Tim Kiem
        public string TKIDCuonSach(string IDCuonSach)
        {
            IDCuonSach = "Select * from CUONSACH where IDCuonSach like '%" + IDCuonSach + "%' ";
            return IDCuonSach;
        }

        public string TKIDSach(string IDSach)
        {
            IDSach = "Select * from CUONSACH where IDSach like '%" + IDSach + "%' ";
            return IDSach;
        }

        public string TKTinhTrang(string TinhTrang)
        {
            TinhTrang = "Select * from CUONSACH where TinhTrang like '%" + TinhTrang + "%' ";
            return TinhTrang;
        }
        #endregion

        public bool checkID(string ID)
        {
            SCRIPT.formatCuonSach.Instance.returnIDCuonSach(ref ID);
            string sql = "Select *from CUONSACH where IDCuonSach='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
