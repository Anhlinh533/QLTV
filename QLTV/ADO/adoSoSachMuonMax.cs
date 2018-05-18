using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoSoSachMuonMax
    {
        private static adoSoSachMuonMax instance;

        internal static adoSoSachMuonMax Instance
        {
            get
            {
                if (instance == null) instance = new adoSoSachMuonMax(); return ADO.adoSoSachMuonMax.instance;
            }

            private set
            {
                ADO.adoSoSachMuonMax.instance = value;
            }
        }

        public void Sua(string tb_SoSachMuonMax)
        {
            string sqlUpdate = "UPDATE THAMSO SET SoSachMuonMax = '" + tb_SoSachMuonMax + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
