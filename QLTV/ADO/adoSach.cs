﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoSach
    {
        private static adoSach instance;

        internal static adoSach Instance
        {
            get
            {
                if (instance == null) instance = new adoSach(); return ADO.adoSach.instance;
            }

            private set
            {
                ADO.adoSach.instance = value;
            }
        }

        public void Them(string tb_IDSach, string cbb_IDDauSach, string tb_NXB, string cbb_NXB, string tb_SoLuongTon, string tb_GiaTien)
        {
            SCRIPT.formatSach.Instance.returnIDSach(ref tb_IDSach);
            string sqlInsert = "INSERT INTO SACH VALUES ('" + tb_IDSach + "','" + cbb_IDDauSach + "',N'" + tb_NXB + "','" + cbb_NXB + "','" + tb_SoLuongTon + "','" + tb_GiaTien + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDSach)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM SACH WHERE IDSach ='" + tb_IDSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDSach, string cbb_IDDauSach, string tb_NXB, string cbb_NXB, string tb_SoLuongTon, string tb_GiaTien)
        {
            SCRIPT.formatSach.Instance.returnIDSach(ref tb_IDSach);
            string sqlUpdate = "UPDATE SACH SET IDDauSach = '" + cbb_IDDauSach + "', NhaXB = N'" + tb_NXB + "', NamXB = '" + cbb_NXB + "', SoLuongTon = '" + tb_SoLuongTon + "', GiaTien = '" + tb_GiaTien + "' WHERE IDSach = '" + tb_IDSach + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
