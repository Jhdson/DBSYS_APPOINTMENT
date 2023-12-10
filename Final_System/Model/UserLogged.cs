using Final_System.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_System.Model
{
    internal class UserLogged
    {

        private static UserLogged _instance;
        public tblUser User { get; set; }

        private UserLogged()
        {

        }

        public static UserLogged GetInstance()
        {
            if (_instance == null)
                _instance = new UserLogged();
            return _instance;
        }
    }
}   