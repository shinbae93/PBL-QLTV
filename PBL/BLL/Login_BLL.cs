using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    class Login_BLL
    {
        private static Login_BLL _Instance;

        public static Login_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Login_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private Login_BLL()
        {
        }
        public NguoiDung GetNguoiDungByUserAndPW(string user, string pass)
        {
            DHP_07Entities db = new DHP_07Entities();
            var l1 = db.NguoiDungs
                .Where(p => p.Username == user && p.Password == pass).ToList();
            if(l1.Count != 0)
            {
                return l1[0];
            }
            else
            {
                return null;
            }
        }
        public bool CheckNguoiDung(string user, string pass)
        {
            //DHP_07Entities db = new DHP_07Entities();
            //var l1 = db.NguoiDungs
            //    .Where(p => p.Username == user && p.Password == pass).ToList();

            if (GetNguoiDungByUserAndPW(user,pass) != null)
            {
                return true;
            }
            return false;
        }
    }
}
