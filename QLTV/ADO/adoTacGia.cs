using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTacGia
    {
        private static adoTacGia instance;

        internal static adoTacGia Instance
        {
            get
            {
                if (instance == null) instance = new adoTacGia(); return ADO.adoTacGia.instance;
            }

            private set
            {
                ADO.adoTacGia.instance = value;
            }
        }

        public void Them(string tb_IDTacGia, string tb_TenTacGia, string dtp_NgaySinh)
        {
            SCRIPT.formatTacGia.Instance.returnIDTacGia(ref tb_IDTacGia);
            string sqlInsert = "INSERT INTO TACGIA VALUES ('" + tb_IDTacGia + "',N'" + tb_TenTacGia + "','" + dtp_NgaySinh + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDTacGia)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM TACGIA WHERE IDTacGia ='" + tb_IDTacGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDTacGia, string tb_TenTacGia, string dtp_NgaySinh)
        {
            SCRIPT.formatTacGia.Instance.returnIDTacGia(ref tb_IDTacGia);
            string sqlUpdate = "UPDATE TACGIA SET TenTacGia = N'" + tb_TenTacGia + "', NgaySinh = '" + dtp_NgaySinh + "' WHERE IDTacGia = '" + tb_IDTacGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
