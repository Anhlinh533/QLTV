﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoCTTacGia
    {
        private static adoCTTacGia instance;

        internal static adoCTTacGia Instance
        {
            get
            {
                if (instance == null) instance = new adoCTTacGia(); return ADO.adoCTTacGia.instance;
            }

            private set
            {
                ADO.adoCTTacGia.instance = value;
            }
        }

        #region Insert
        public void Them(string tb_IDCTTacGia, string cbb_IDDauSach, string cbb_IDTacGia)
        {
            SCRIPT.formatCTTacGia.Instance.returnIDCTTacGia(ref tb_IDCTTacGia);
            string sqlInsert = "INSERT INTO CT_TACGIA VALUES ('" + tb_IDCTTacGia + "','" + cbb_IDDauSach + "','" + cbb_IDTacGia + "')";
            ADO.ConnectionSQL.Instance.Execute(sqlInsert);
        }

        public void Xoa(string tb_IDCTTacGia)
        {
            //SCRIPT.formatTheDocGia.Instance.returnIDDocGia(ref tb_IDDocGia);
            string sqlDelete = "DELETE FROM CT_TACGIA WHERE IDCTTacGia ='" + tb_IDCTTacGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlDelete);
        }

        public void Sua(string tb_IDCTTacGia, string cbb_IDDauSach, string cbb_IDTacGia)
        {
            //SCRIPT.formatCTTacGia.Instance.returnIDCTTacGia(ref tb_IDCTTacGia);
            string sqlUpdate = "UPDATE CT_TACGIA SET IDDauSach = '" + cbb_IDDauSach + "', IDTacGia = '" + cbb_IDTacGia + "' WHERE IDCTTacGia = '" + tb_IDCTTacGia + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion

        #region Tim Kiem
        public string TKIDCTTacGia(string IDCTTacGia)
        {
            IDCTTacGia = "Select * from CT_TACGIA where IDCTTacGia like '%" + IDCTTacGia + "%' ";
            return IDCTTacGia;
        }
        public string TKIDDauSach(string IDDauSach)
        {
            IDDauSach = "Select * from CT_TACGIA where IDDauSach like '%" + IDDauSach + "%' ";
            return IDDauSach;
        }
        public string TKIDTacGia(string IDTacGia)
        {
            IDTacGia = "Select * from CT_TACGIA where IDTacGia like '%" + IDTacGia + "%' ";
            return IDTacGia;
        }
        #endregion

        public bool checkID(string ID)
        {
            SCRIPT.formatCTTacGia.Instance.returnIDCTTacGia(ref ID);
            string sql = "Select *from CT_TACGIA where IDCTTacGia='" + ID + "'";
            if (ADO.ConnectionSQL.Instance.check(sql) == true)
                return true;
            return false;
        }
    }
}
