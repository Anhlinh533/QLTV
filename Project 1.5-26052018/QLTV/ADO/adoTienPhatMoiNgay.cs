using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTienPhatMoiNgay
    {
        private static adoTienPhatMoiNgay instance;

        internal static adoTienPhatMoiNgay Instance
        {
            get
            {
                if (instance == null) instance = new adoTienPhatMoiNgay(); return ADO.adoTienPhatMoiNgay.instance;
            }

            private set
            {
                ADO.adoTienPhatMoiNgay.instance = value;
            }
        }

        #region Query
        public void Sua(string tb_TienPhatMoiNgay)
        {
            string sqlUpdate = "UPDATE THAMSO SET TienPhatMoiNgay = '" + tb_TienPhatMoiNgay + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion
    }
}
