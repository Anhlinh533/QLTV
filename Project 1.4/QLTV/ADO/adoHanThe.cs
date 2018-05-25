using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.ADO
{
    class adoHanThe
    {
        private static adoHanThe instance;

        internal static adoHanThe Instance
        {
            get
            {
                if (instance == null) instance = new adoHanThe(); return ADO.adoHanThe.instance;
            }

            private set
            {
                ADO.adoHanThe.instance = value;
            }
        }

        public void Sua(string tb_HanThe)
        {
            string sqlUpdate = "UPDATE THAMSO SET HanThe = '" + tb_HanThe + "'";
            ADO.ConnectionSQL.Instance.Execute(sqlUpdate);
        }
    }
}
