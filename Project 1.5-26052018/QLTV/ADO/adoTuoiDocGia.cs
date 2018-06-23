using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoTuoiDocGia
    {
        private static adoTuoiDocGia instance;

        internal static adoTuoiDocGia Instance
        {
            get
            {
                if (instance == null) instance = new adoTuoiDocGia(); return ADO.adoTuoiDocGia.instance;
            }

            private set
            {
                ADO.adoTuoiDocGia.instance = value;
            }
        }

        #region Query
        public void Sua(string tb_TuoiMin, string tb_TuoiMax)
        {
            string sqlUpdate = "UPDATE THAMSO SET TuoiMin = '" + tb_TuoiMin + "', TuoiMax = '" + tb_TuoiMax + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion
    }
}
