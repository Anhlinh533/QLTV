using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoSoNgayMuonMax
    {
        private static adoSoNgayMuonMax instance;

        internal static adoSoNgayMuonMax Instance
        {
            get
            {
                if (instance == null) instance = new adoSoNgayMuonMax(); return ADO.adoSoNgayMuonMax.instance;
            }

            private set
            {
                ADO.adoSoNgayMuonMax.instance = value;
            }
        }

        #region Query
        public void Sua(string tb_SoNgayMuonMax)
        {
            string sqlUpdate = "UPDATE THAMSO SET SoNgayMuonMax = '" + tb_SoNgayMuonMax + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
        #endregion
    }
}
