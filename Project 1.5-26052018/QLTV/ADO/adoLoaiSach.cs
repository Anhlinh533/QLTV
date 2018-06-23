using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoLoaiSach
    {
        private static adoLoaiSach instance;

        internal static adoLoaiSach Instance
        {
            get
            {
                if (instance == null) instance = new adoLoaiSach(); return ADO.adoLoaiSach.instance;
            }

            private set
            {
                ADO.adoLoaiSach.instance = value;
            }
        }

        #region Query
        public void Them(string tb_IDLoaiSach, string tb_TenLoaiSach)
        {
            SCRIPT.formatLoaiSach.Instance.returnIDLoaiSach(ref tb_IDLoaiSach);
            string sqlInsert = "INSERT INTO LOAISACH VALUES ('" + tb_IDLoaiSach + "',N'" + tb_TenLoaiSach + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDLoaiSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM LOAISACH WHERE IDLoaiSach ='" + tb_IDLoaiSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDLoaiSach, string tb_TenLoaiSach)
        {
            //SCRIPT.formatLoaiSach.Instance.returnIDLoaiSach(ref tb_IDLoaiSach);
            string sqlUpdate = "UPDATE LOAISACH SET TenLoaiSach = N'" + tb_TenLoaiSach + "' WHERE IDLoaiSach = '" + tb_IDLoaiSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        public string GetQueryFillDgv()
        {
            string sql = "SELECT * FROM LOAISACH";
            return sql;
        }

        public bool checkID(string ID)
        {
            SCRIPT.formatLoaiSach.Instance.returnIDLoaiSach(ref ID);
            string sql = "Select *from LOAISACH where IDLoaiSach='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }        
    }
}
