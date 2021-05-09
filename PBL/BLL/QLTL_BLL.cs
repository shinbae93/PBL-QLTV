using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    internal class QLTL_BLL
    {
        private static QLTL_BLL _Instance;

        public static QLTL_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTL_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLTL_BLL()
        {
        }
    }
}