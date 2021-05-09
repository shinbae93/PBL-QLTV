using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    internal class QLVP_BLL
    {
        private static QLVP_BLL _Instance;

        public static QLVP_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLVP_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLVP_BLL()
        {
        }
    }
}