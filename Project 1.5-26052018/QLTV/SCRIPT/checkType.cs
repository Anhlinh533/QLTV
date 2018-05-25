using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class checkType
    {
        private static checkType instance;

        internal static checkType Instance
        {
            get
            {
                if (instance == null) instance = new checkType(); return SCRIPT.checkType.instance;
            }

            private set
            {
                SCRIPT.checkType.instance = value;
            }
        }
        public static string formatHoTen(string str)
        {
            string STRING = "";
            str = str.Trim().ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                    STRING = STRING + str[i].ToString().ToUpper();
                else
                    STRING = STRING + str[i];
                if (str[i] == ' ')
                {
                    while (str[i] == ' ')
                        i++;
                    STRING = STRING + str[i].ToString().ToUpper();
                }
            }
            return STRING.ToString();
        }
        public bool checkIsPhone(string phone)
        {
            if (phone.Length > 11 || phone.Length < 10)
            {
                return false;
            }
            Regex reg = new Regex("(\\+84|0)\\d{9,10}");
            return reg.IsMatch(phone);
        }

        public bool checkIsMail(string email)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            return reg.IsMatch(email);
        }

    }
}
