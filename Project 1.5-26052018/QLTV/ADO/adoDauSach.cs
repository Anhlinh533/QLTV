using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoDauSach
    {
        private static adoDauSach instance;

        internal static adoDauSach Instance
        {
            get
            {
                if (instance == null) instance = new adoDauSach(); return ADO.adoDauSach.instance;
            }

            private set
            {
                ADO.adoDauSach.instance = value;
            }
        }

        public void Them(string tb_IDDauSach, string tb_TenDauSach, string cbb_IDTheLoaiSach)
        {
            cbb_IDTheLoaiSach = ADO.ConnectionSQL.Instance.ExcuteString("SELECT IDLoaiSach FROM LOAISACH WHERE TenLoaiSach = N'" + cbb_IDTheLoaiSach + "'");

            SCRIPT.formatDauSach.Instance.returnIDDauSach(ref tb_IDDauSach);
            string sqlInsert = "INSERT INTO DAUSACH VALUES ('" + tb_IDDauSach + "',N'" + tb_TenDauSach + "','" + cbb_IDTheLoaiSach + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDDauSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM DAUSACH WHERE IDDauSach ='" + tb_IDDauSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDDauSach, string tb_TenDauSach, string cbb_IDTheLoaiSach)
        {
            //SCRIPT.formatDauSach.Instance.returnIDDauSach(ref tb_IDDauSach);
            string sqlUpdate = "UPDATE DAUSACH SET TenDauSach = N'" + tb_TenDauSach + "', IDLoaiSach = '" + cbb_IDTheLoaiSach + "' WHERE IDDauSach = '" + tb_IDDauSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }

        public bool checkID(string ID)
        {
            SCRIPT.formatDauSach.Instance.returnIDDauSach(ref ID);
            string sql = "Select *from DAUSACH where IDDauSach='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }

        public string GetQueryFillDgv()
        {
            string sql = "SELECT IDDauSach, TenDauSach, A.IDLoaiSach, TenLoaiSach FROM DAUSACH A, LOAISACH B WHERE A.IDLoaiSach = B.IDLoaiSach";
            return sql;
        }

        public string AutoFill(string idls, string TenBox)
        {
            string str = "";

            if (TenBox == "cbb_IDTheLoaiSach")
            {
                string sql = "SELECT TenLoaiSach FROM LOAISACH WHERE IDLoaiSach = '" + idls + "'";
                str = ADO.ConnectionSQL.Instance.ExcuteString(sql);
            }            

            return str;
        }
    }
}
