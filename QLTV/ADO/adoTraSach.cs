﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTraSach
    {
        private static adoTraSach instance;

        internal static adoTraSach Instance
        {
            get
            {
                if (instance == null) instance = new adoTraSach(); return ADO.adoTraSach.instance;
            }

            private set
            {
                ADO.adoTraSach.instance = value;
            }
        }

        public void Them(string tb_IDPhieuTra, string cbb_IDDocGia, string dtp_NgayTra, string tb_SoTienTra)
        {
            SCRIPT.formatTraSach.Instance.returnIDPhieuTra(ref tb_IDPhieuTra);
            string sqlInsert = "INSERT INTO PHIEUTRA VALUES ('" + tb_IDPhieuTra + "','" + cbb_IDDocGia + "','" + dtp_NgayTra + "','" + tb_SoTienTra + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDPhieuTra)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM PHIEUTRA WHERE IDPhieuTra ='" + tb_IDPhieuTra + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDPhieuTra, string cbb_IDDocGia, string dtp_NgayTra, string tb_SoTienTra)
        {
            SCRIPT.formatTraSach.Instance.returnIDPhieuTra(ref tb_IDPhieuTra);
            string sqlUpdate = "UPDATE PHIEUTRA SET IDDocGia = '" + cbb_IDDocGia + "', NgayTra = '" + dtp_NgayTra + "', SoTienTra = '" + tb_SoTienTra + "' WHERE IDPhieuTra = '" + tb_IDPhieuTra + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
